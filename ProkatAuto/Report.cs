using System;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Data.SQLite;
using System.Data;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProkatAuto
{
    class Report
    {
        private static SQLiteConnection sql = new SQLiteConnection("DataSource = autodb.sqlite;Version=3");
        private static string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
        private static BaseFont baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        private static Font font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
        private static DataTable[] arr;
        private static bool isOpened = false;

        private static void openCon()
        {
            if (!isOpened)
            {
                sql.Open();
                isOpened = true;
            }
        }

        public static void closeCon()
        {
            if (isOpened)
            {
                sql.Close();
                isOpened = false;
            }
        }

        public static void makePdfReport()
        {
            openCon();
            SQLiteCommand command = new SQLiteCommand("SELECT MARKA, FIO FROM PROKAT P JOIN AUTO A ON A.ID = P.IDAUTO JOIN CLIENT C ON C.ID = P.IDCLIENT WHERE DATAVOZVRATA IS NULL", sql);
            SQLiteDataReader reader = command.ExecuteReader();
            command = new SQLiteCommand("SELECT COUNT(DISTINCT IDCLIENT) FROM PROKAT P JOIN AUTO A ON A.ID = P.IDAUTO WHERE DATAVOZVRATA IS NULL", sql);
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("autoReport.pdf", FileMode.Create));
            doc.Open();
            DataTable dt = new DataTable();
            dt.Load(reader);
            Phrase phrase = new Phrase("На " + DateTime.Now.ToString() + " в распоряжении находится автомобилей: " + dt.Rows.Count + " у клиентов: " + Convert.ToInt32(command.ExecuteScalar()), font);
            doc.Add(phrase);
            PdfPTable table = new PdfPTable(dt.Columns.Count);
            string[] header = new string[] { "Машина", "Клиент" };
            for (int i = 0; i < header.Length; i++)
            {
                phrase = new Phrase(header[i], font);
                table.AddCell(phrase);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    phrase = new Phrase(dt.Rows[i][j].ToString(), font);
                    table.AddCell(phrase);
                }
            }
            doc.Add(table);
            try
            {
                makeExcelChart();
                Image chart = Image.GetInstance(Environment.CurrentDirectory + "\\chart0.bmp");
                doc.Add(chart);
                chart = Image.GetInstance(Environment.CurrentDirectory + "\\chart1.bmp");
                doc.Add(chart);
            }
            catch (Exception ex)
            {

            }
            doc.Close();
        }

        public static void saveXmlBackup()
        {
            arr[0].WriteXml("auto.xml");
            arr[1].WriteXml("client.xml");
            arr[2].WriteXml("prokat.xml");
        }

        public static DataTable[] makeXMLBackup()
        {
            openCon();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM AUTO", sql);
            DataTable dtAuto = new DataTable();
            dtAuto.Load(command.ExecuteReader());
            command = new SQLiteCommand("SELECT * FROM CLIENT", sql);
            DataTable dtClient = new DataTable();
            dtClient.Load(command.ExecuteReader());
            command = new SQLiteCommand("SELECT * FROM PROKAT", sql);
            DataTable dtProkat = new DataTable();
            dtProkat.Load(command.ExecuteReader());
            arr = new DataTable[] { dtAuto, dtClient, dtProkat };
            sql.Close();
            return arr;
        }

        private static void makeExcelChart()
        {
            openCon();
            Excel.Application excelapp = new Excel.Application();
            excelapp.SheetsInNewWorkbook = 3;
            excelapp.Workbooks.Add(Type.Missing);
            Excel.Sheets excelsheets = excelapp.Workbooks[1].Worksheets;
            string[] selects = new string[] { "SELECT COUNT(GOD), GOD FROM AUTO GROUP BY GOD;", "SELECT TYPE, COUNT(TYPE) FROM AUTO GROUP BY TYPE;" };
            string[] chartName = new string[] { "Количество автомобилей по году выпуска", "Количество автомобилей по типу КПП" };
            Image[] charts = new Image[2];
            for (int f = 0; f < 2; f++)
            {
                SQLiteCommand command = new SQLiteCommand(selects[f], sql);
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(f + 1);
                excelworksheet.Activate();
                Excel.Range excelcells;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        excelcells = excelworksheet.Cells[j + 1][i + 1];
                        excelcells.Value2 = dt.Rows[i][j];
                    }
                }
                excelcells = excelworksheet.get_Range("A1", "B" + dt.Rows.Count);
                excelcells.Select();
                Excel.Chart excelchart = (Excel.Chart)excelapp.Charts.Add(Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing);
                excelchart.Activate();
                excelchart.Select(Type.Missing);
                excelapp.ActiveChart.ChartType = Excel.XlChartType.xlPie;

                excelapp.ActiveChart.HasTitle = true;
                excelapp.ActiveChart.ChartTitle.Text = chartName[f];

                excelapp.ActiveChart.ChartTitle.Font.Size = 13;

                excelapp.ActiveChart.ChartTitle.Shadow = true;
                excelapp.ActiveChart.ChartTitle.Border.LineStyle = Excel.Constants.xlSolid;

                Excel.SeriesCollection seriesCollection = (Excel.SeriesCollection)excelapp.ActiveChart.SeriesCollection(Type.Missing);
                Excel.Series series = seriesCollection.Item(1);

                if (f == 0)
                    series.XValues = excelworksheet.get_Range("B1", "B" + dt.Rows.Count);
                else
                    series.XValues = excelworksheet.get_Range("A1", "A" + dt.Rows.Count);
                excelapp.ActiveChart.Export(Environment.CurrentDirectory + "\\chart" + f + ".bmp", "BMP", Type.Missing);
            }
            if (File.Exists("chart.xls"))
                File.Delete("chart.xls");
            excelapp.Workbooks[1].SaveAs(Environment.CurrentDirectory + "\\chart.xls");
            //excelapp.Visible = true;
            excelapp.Quit();
        }
    }
}
