using System;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Data.SQLite;
using System.Data;
using System.Diagnostics;

namespace ProkatAuto
{
    class Report
    {
        private static SQLiteConnection sql = new SQLiteConnection("DataSource = autodb.sqlite;Version=3");
        private static string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
        private static BaseFont baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        private static Font font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

        public static void report()
        {
            sql.Open();
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
            string[] header = new string[] { "Машина", "Клиент"};
            for(int i = 0; i < header.Length; i++)
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
            sql.Close();
            doc.Close();
            Process.Start("autoReport.pdf");
        }
    }
}
