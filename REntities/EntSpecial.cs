using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Rennovation.REntities
{
    public class EntSpecial
    {
        static List<EntSpecial> list = new List<EntSpecial>();

        bool saved = false;
        public long pspecial = -1;

        public long pworker = 0;
        public long pqual = 0;

        EntSpecial(long id, long pworker, long pqual)
        {
            this.pspecial = id;
            this.pworker = pworker;
            this.pqual = pqual;
            saved = true;
        }

        public EntSpecial(long pworker, long pqual)
        {
            this.pworker = pworker;
            this.pqual = pqual;
            saved = false;
        }

        public override string ToString()
        {
            return "speciality";
        }

        public string info()
        {
            return "sp";
        }

        public string[] infoLines()
        {
            return RData.stringToLines("sp");
        }

        public void delete()
        {
            if (saved)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from specials where pspec = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.pspecial));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update specials set pworker = @pworker, " +
                    "pqual = @pqual where pspec = @id";
                com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
                com.Parameters.Add(new SQLiteParameter("@pqual", pqual));
                com.Parameters.Add(new SQLiteParameter("@id", pspecial));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into specials (pworker, pqual) " +
                    "values (@pworker, @pqual)";
                com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
                com.Parameters.Add(new SQLiteParameter("@pqual", pqual));
                com.ExecuteNonQuery();
                pspecial = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(long pspecial, long pworker, long pqual)
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select count(pspec) from specials where pworker = @pworker " +
                "and pqual = @pqual and pspec <> @pspec";
            com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
            com.Parameters.Add(new SQLiteParameter("@pqual", pqual));
            com.Parameters.Add(new SQLiteParameter("@pspec", pspecial));
            long count = (long)(com.ExecuteScalar());
            return count == 0;
            //if (pworker != pworker)
            //{
            //    System.Windows.Forms.MessageBox.Show(@"Поле ""ФИО"" не может быть пустым.");
            //    return false;
            //}
            //return true;
        }

        public static List<EntSpecial> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from specials";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EntSpecial((long)reader["pspec"], (long)reader["pworker"],
                    (long)reader["pqual"]));
            }
            return list;
        }

        public static List<EntSpecial> getWithWorker(long pworker)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from specials where pworker = @pworker";
            com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EntSpecial((long)reader["pspec"], 
                    (long)reader["pworker"], (long)reader["pqual"]));
            }
            return list;
        }

        public static List<EntSpecial> getWithQual(long pqual)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from specials where pqual = @pqual";
            com.Parameters.Add(new SQLiteParameter("@pqual", pqual));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EntSpecial((long)reader["pspec"],
                    (long)reader["pworker"], (long)reader["pqual"]));
            }
            return list;
        }

        public EntQual getQual()
        {
            return EntQual.getQual(pqual);
        }
    }
}
