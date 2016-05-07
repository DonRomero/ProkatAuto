using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ProkatAuto
{
    static class DBworker
    {
        private static SQLiteConnection sql = new SQLiteConnection("DataSource = autoDB.sqlite;Version=3");
        public static void createDB()
        {
            sql.Open();
            SQLiteCommand sc = new SQLiteCommand("CREATE TABLE IF NOT EXISTS AUTO(id INTEGER PRIMARY KEY AUTOINCREMENT, Marka TEXT, God INTEGER, Cvet TEXT, Type TEXT);"
                + "CREATE TABLE IF NOT EXISTS CLIENT(id INTEGER PRIMARY KEY AUTOINCREMENT, FIO TEXT, Data TEXT);"
                + "CREATE TABLE IF NOT EXISTS PROKAT(id INTEGER PRIMARY KEY AUTOINCREMENT, DataVidachi INTEGER, DataVozvrata INTEGER, idClient INTEGER, idAuto INTEGER, CONSTRAINT client_fk FOREIGN KEY (idClient) REFERENCES CLIENT(id), CONSTRAINT auto_fk FOREIGN KEY (idAuto) REFERENCES AUTO(id));", sql);
            sc.ExecuteNonQuery();
        }

        public static void addAuto(string mark, int year, string color, string type)
        {
            SQLiteCommand sc = new SQLiteCommand("INSERT INTO AUTO VALUES(NULL, '" + mark + "', " + year + ", '" + color + "', '" + type + "');", sql);
            sc.ExecuteNonQuery();
        }

        public static void addClient(string fio, int year)
        {
            SQLiteCommand sc = new SQLiteCommand("INSERT INTO CLIENT VALUES(NULL, '" + fio + "', " + year + ");", sql);
            sc.ExecuteNonQuery();
        }

        public static void addProkat(int idAuto, int idClient, long time)
        {
            SQLiteCommand sc = new SQLiteCommand("INSERT INTO PROKAT VALUES(NULL, " + time + ", NULL, " + idClient + ", " + idAuto + ");", sql);
            sc.ExecuteNonQuery();
        }

        public static void updateProkat(int idAuto, long time)
        {
            SQLiteCommand sc = new SQLiteCommand("UPDATE PROKAT SET DATAVOZVRATA = " + time + " WHERE ID = " + idAuto + ";", sql);
            sc.ExecuteNonQuery();
        }

        public static string[] getProkatInfo(int prokatId)
        {
            SQLiteCommand sc = new SQLiteCommand("SELECT DATAVIDACHI, FIO, MARKA FROM PROKAT P JOIN AUTO A ON P.IDAUTO = A.ID JOIN CLIENT C ON C.ID = P.IDCLIENT WHERE P.ID = " + prokatId + ";", sql);
            SQLiteDataReader reader = sc.ExecuteReader();
            string[] mass = new string[3];
            while(reader.Read())
            {
                mass[0] = reader[0].ToString();
                mass[1] = reader[1].ToString();
                mass[2] = reader[2].ToString();
            }
            return mass;
        }

        public static Dictionary<int, string> getData(string from)
        {
            SQLiteCommand sc = new SQLiteCommand();
            switch (from)
            {
                case "AUTO":
                    sc = new SQLiteCommand("SELECT A.ID, MARKA FROM AUTO A WHERE ID NOT IN (SELECT A.ID FROM PROKAT P JOIN AUTO A ON A.ID = P.IDAUTO WHERE DATAVOZVRATA IS NULL);", sql);
                    break;
                case "CLIENT":
                    sc = new SQLiteCommand("SELECT ID, FIO FROM CLIENT;", sql);
                    break;
                case "PROKAT":
                    sc = new SQLiteCommand("SELECT P.ID, A.MARKA FROM PROKAT P JOIN AUTO A ON P.IDAUTO = A.ID WHERE DATAVOZVRATA IS NULL;", sql);
                    break;
            }
            SQLiteDataReader reader = sc.ExecuteReader();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            while (reader.Read())
            {
                dic.Add(Convert.ToInt32(reader[0]), reader[0].ToString() + "_" + reader[1].ToString());
            }
            return dic;
        }

        static public void close()
        {
            sql.Close();
        }
    }
}
