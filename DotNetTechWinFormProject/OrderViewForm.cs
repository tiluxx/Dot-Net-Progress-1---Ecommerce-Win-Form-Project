using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace DotNetTechWinFormProject
{
    public partial class OrderViewForm : Form
    {
        readonly String dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        DataTable tb;

        public OrderViewForm()
        {
            InitializeComponent();
        }

        private void OrderViewForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbConn);
            conn.Open();
            showGRD();
        }

        public void showGRD()
        {
            string sql = "select O.OrderID as 'Order ID', O.OrderDate as 'Order date', A.CustName as 'Customer name'" +
                " from _Order O, Customer A" +
                " where O.CustID = A.CustID";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            orderGrd.DataSource = tb;
        }

        private void printPreviewBtn_Click(object sender, EventArgs e)
        {
            if (orderIdTxt.Text.Equals("") || orderIdTxt == null)
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "select * from OrderDetail where OrderID = '" + orderIdTxt.Text + "'";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);

            try
            {
                using (PdfDocument document = new PdfDocument())
                {
                    document.PageSettings.Orientation = PdfPageOrientation.Landscape;
                    document.PageSettings.Margins.All = 50;
                    PdfPage page = document.Pages.Add();
                    PdfGraphics graphics = page.Graphics;

                    RectangleF bounds = new RectangleF(176, 0, 390, 130);
                    PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                    bounds = new RectangleF(0, bounds.Bottom + 90, graphics.ClientSize.Width, 30);
                    graphics.DrawRectangle(solidBrush, bounds);
                    PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);
                    PdfTextElement element = new PdfTextElement("Order Report", subHeadingFont)
                    {
                        Brush = PdfBrushes.White
                    };

                    PdfLayoutResult result = element.Draw(page, new PointF(10, bounds.Top + 8));
                    string currentDate = "Export Date: " + DateTime.Now.ToString("MMMM dd yyyy, hh:mm: tt", CultureInfo.InvariantCulture);

                    SizeF textSize = subHeadingFont.MeasureString(currentDate);
                    PointF textPosition = new PointF(graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);
                    graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);
                    PdfFont timesRoman = new PdfStandardFont(PdfFontFamily.Helvetica, 10f);
                    element = new PdfTextElement($"Order ID: {orderIdTxt.Text}", timesRoman)
                    {
                        Brush = new PdfSolidBrush(new PdfColor(126, 155, 203))
                    };
                    result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 25));

                    PdfPen linePen = new PdfPen(new PdfColor(126, 151, 173), 0.70f);
                    PointF startPoint = new PointF(0, result.Bounds.Bottom + 3);
                    PointF endPoint = new PointF(graphics.ClientSize.Width, result.Bounds.Bottom + 3);
                    graphics.DrawLine(linePen, startPoint, endPoint);

                    DataTable productDetails = tb;
                    PdfGrid grid = new PdfGrid
                    {
                        DataSource = productDetails
                    };
                    PdfGridCellStyle cellStyle = new PdfGridCellStyle();
                    cellStyle.Borders.All = PdfPens.White;
                    PdfGridRow header = grid.Headers[0];
                    PdfGridCellStyle headerStyle = new PdfGridCellStyle();
                    headerStyle.Borders.All = new PdfPen(new PdfColor(126, 151, 173));
                    headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                    headerStyle.TextBrush = PdfBrushes.White;
                    headerStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f, PdfFontStyle.Regular);

                    for (int i = 0; i < header.Cells.Count; i++)
                    {
                        if (i == 0 || i == 1)
                            header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                        else
                            header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);
                    }

                    header.ApplyStyle(headerStyle);
                    cellStyle.Borders.Bottom = new PdfPen(new PdfColor(217, 217, 217), 0.70f);
                    cellStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 10f);
                    cellStyle.TextBrush = new PdfSolidBrush(new PdfColor(131, 130, 136));
                    PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat
                    {
                        Layout = PdfLayoutType.Paginate
                    };
                    PdfGridLayoutResult gridResult = grid.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 40), new SizeF(graphics.ClientSize.Width, graphics.ClientSize.Height - 100)), layoutFormat);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                    saveFileDialog.FileName = $"Order_Report_{orderIdTxt.Text}_{DateTime.Now.ToString("ddMMMMyyyyHHmmssfffff")}.pdf";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        document.Save(saveFileDialog.FileName);
                        document.Close(true);
                    }
                    MessageBox.Show("Data Exported Successfully !!!", "Info");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void orderGrd_Click(object sender, EventArgs e)
        {
            orderIdTxt.Text = orderGrd.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
