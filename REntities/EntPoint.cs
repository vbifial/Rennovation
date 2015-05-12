using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Rennovation.REntities
{
    public class EntPoint
    {
        static List<EntPoint> list = new List<EntPoint>();

        bool saved = false;
        public long ppoint = -1;

        public long plevel;
        public long porder;

        /// <summary>
        /// Дата окончания 
        /// </summary>
        public DateTime edate;

        public String descript;

        public long ecost;
        public long fcost;

        public long amount;

        EntPoint(long id, long plevel, long porder, long edate,
            String descript, long amount, long ecost, long fcost)
        {
            this.ppoint = id;
            this.plevel = plevel;
            this.porder = porder;
            this.descript = descript;
            this.edate = DateTime.FromBinary(edate);
            this.ecost = ecost;
            this.fcost = fcost;
            this.amount = amount;

            saved = true;
        }

        public EntPoint(long plevel, long porder, DateTime edate,
            String descript, long amount, long ecost, long fcost)
        {
            this.plevel = plevel;
            this.porder = porder;
            this.descript = descript;
            this.edate = edate;
            this.ecost = ecost;
            this.fcost = fcost;
            this.amount = amount;

            saved = false;
        }

        public override string ToString()
        {
            return descript;
        }

        public string info()
        {
            return descript;
        }

        public string[] infoLines()
        {
            return RData.stringToLines(descript + "\n");
        }

        public void delete()
        {
            if (saved)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from points where ppoint = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.ppoint));
                com.ExecuteNonQuery();
            }
        }

        public void deleteCascade()
        {
            if (saved)
            {
                foreach (EntAssign ass in EntAssign.getWithPoint(ppoint))
                {
                    ass.deleteCascade();
                }
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from points where ppoint = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.ppoint));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
            //    long plevel, long porder, DateTime edate,
            //String descript, long amount, long ecost, long fcost
                com.CommandText = "update points set edate = @edate, " +
                    "porder = @porder, amount = @amount, descript = @descript, " +
                    "plevel = @plevel, ecost = @ecost, " +
                    "fcost = @fcost where ppoint = @id";
                com.Parameters.Add(new SQLiteParameter("@id", ppoint));
                com.Parameters.Add(new SQLiteParameter("@edate", edate.ToBinary()));
                com.Parameters.Add(new SQLiteParameter("@descript", descript));
                com.Parameters.Add(new SQLiteParameter("@amount", amount));
                com.Parameters.Add(new SQLiteParameter("@plevel", plevel));
                com.Parameters.Add(new SQLiteParameter("@porder", porder));
                com.Parameters.Add(new SQLiteParameter("@ecost", ecost));
                com.Parameters.Add(new SQLiteParameter("@fcost", fcost));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into points (edate, descript, amount, " +
                    "plevel, porder, ecost, fcost) " +
                    "values (@edate, @descript, @amount, " +
                    "@plevel, @porder, @ecost, @fcost)";
                com.Parameters.Add(new SQLiteParameter("@edate", edate.ToBinary()));
                com.Parameters.Add(new SQLiteParameter("@descript", descript));
                com.Parameters.Add(new SQLiteParameter("@amount", amount));
                com.Parameters.Add(new SQLiteParameter("@plevel", plevel));
                com.Parameters.Add(new SQLiteParameter("@porder", porder));
                com.Parameters.Add(new SQLiteParameter("@ecost", ecost));
                com.Parameters.Add(new SQLiteParameter("@fcost", fcost));
                com.ExecuteNonQuery();
                ppoint = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(long plevel, long porder, DateTime edate,
            String descript, long amount, long ecost, long fcost)
        {
            if (descript.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show(@"Поле ""Описание"" не может быть пустым.");
                return false;
            }

            if (amount <= 0)
            {
                System.Windows.Forms.MessageBox.Show(
                    @"Объем работы должен быть положительным целым числом часов.");
                return false;
            }

            //if ((!edate.Equals(DateTime.MinValue) && !bdate.Equals(DateTime.MinValue)) &&
            //        edate.CompareTo(bdate) < 0)
            //{
            //    System.Windows.Forms.MessageBox.Show(@"Дата окончания не может быть раньше даты начала.");
            //    return false;
            //}

            //SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            //com.CommandText = "select count(ppoint) from points where pworker = @pworker " +
            //    "and pqual = @pqual and ppoint <> @ppoint";
            //com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
            //com.Parameters.Add(new SQLiteParameter("@pqual", pqual));
            //com.Parameters.Add(new SQLiteParameter("@ppoint", ppoint));
            //long count = (long)(com.ExecuteScalar());
            //return count == 0;

            return true;
        }

        public static List<EntPoint> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from points";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["ppoint"];
                long edate = (long)reader["edate"];
                String descript = (String)reader["descript"];
                long amount = (long)reader["amount"];
                long plevel = (long)reader["plevel"];
                long porder = (long)reader["porder"];
                long ecost = (long)reader["ecost"];
                long fcost = (long)reader["fcost"];

                list.Add(new EntPoint(id, plevel, porder, edate,
                    descript, amount, ecost, fcost));
            }
            return list;
        }

        public static List<EntPoint> getWithOrder(long porder)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from points where porder = @porder";
            com.Parameters.Add(new SQLiteParameter("@porder", porder));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["ppoint"];
                long edate = (long)reader["edate"];
                String descript = (String)reader["descript"];
                long amount = (long)reader["amount"];
                long plevel = (long)reader["plevel"];
                long ecost = (long)reader["ecost"];
                long fcost = (long)reader["fcost"];

                list.Add(new EntPoint(id, plevel, porder, edate,
                    descript, amount, ecost, fcost));
            }
            return list;
        }

        public void update(long plevel, long porder, DateTime edate,
            String descript, long amount, long ecost, long fcost)
        {
            this.plevel = plevel;
            this.porder = porder;
            this.descript = descript;
            this.edate = edate;
            this.ecost = ecost;
            this.fcost = fcost;
            this.amount = amount;
        }

        public EntLevel getLevel()
        {
            return EntLevel.getWithId(plevel);
        }
    }
}
