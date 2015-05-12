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
            SQLiteCommand com;
            if (saved)
            {
                com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "select qls.lvalue qval " +
                    "from levels lvs, points pts, assignments ass, " +
                    "specials sps, quals qls where sps.pspec = @id and " +
                    "lvs.plevel = pts.plevel and pts.ppoint = ass.ppoint and " +
                    "ass.pworker = sps.pworker and sps.pqual = qls.pqual and " +
                    "qls.pworktype = lvs.pworktype";
                com.Parameters.Add(new SQLiteParameter("@id", pspecial));
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    throw new Exception(
                        "Данная запись о квалификации используется в назначении работника.");
                }

                com = new SQLiteCommand(RData.getConnection());
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
            EntQual nqual = EntQual.getQual(pqual);
            if (pworker != -1)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "select count(pspec) from specials sps, quals qls " +
                    "where sps.pworker = @pworker and qls.pworktype = @pworktype and " + 
                    "pspec <> @pspec and qls.pqual = sps.pqual";
                com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
                com.Parameters.Add(new SQLiteParameter("@pworktype", nqual.pworktype));
                com.Parameters.Add(new SQLiteParameter("@pspec", pspecial));
                long count = (long)(com.ExecuteScalar());
                if (count > 0)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "У работника уже есть квалификация в этой работе.");
                    return false;
                }
            }

            if (pspecial != -1)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "select qls.lvalue qval, lvs.value lval, qls.pqual oqual " +
                    "from levels lvs, points pts, assignments ass, " +
                    "specials sps, quals qls where sps.pspec = @id and " +
                    "lvs.plevel = pts.plevel and pts.ppoint = ass.ppoint and " +
                    "ass.pworker = sps.pworker and sps.pqual = qls.pqual and " + 
                    "qls.pworktype = lvs.pworktype";

                com.Parameters.Add(new SQLiteParameter("@id", pspecial));
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    long lval = (long)reader["lval"];
                    long qval = (long)reader["qval"];
                    long opqual = (long)reader["oqual"];
                    EntQual oqual = EntQual.getQual(opqual);
                    if (oqual.pworktype != nqual.pworktype || (qval >= lval && lval > nqual.lvalue))
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Заданные значения конфликтуют с существующим назначением.");
                        return false;
                    }
                }
            }
            return true;
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
