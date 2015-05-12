using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Rennovation.REntities
{
    public class EntOrder
    {
        static List<EntOrder> list = new List<EntOrder>();

        bool saved = false;
        public long porder = -1;

        public long pcustomer;

        /// <summary>
        /// Дата окончания 
        /// </summary>
        public DateTime edate;
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime bdate;
        /// <summary>
        /// Дата составления
        /// </summary>
        public DateTime cdate;

        public String name;
        public String objectS;

        public bool fmark;
        public long ecost;
        public long fcost;

        EntOrder(long id, long pcustomer, long edate, long bdate, long cdate, 
            String name, String objectS, long fmark, long ecost, long fcost)
        {
            this.pcustomer = pcustomer;
            this.porder = id;
            this.name = name;
            this.objectS = objectS;
            this.edate = DateTime.FromBinary(edate);
            this.bdate = DateTime.FromBinary(bdate);
            this.cdate = DateTime.FromBinary(cdate);
            this.ecost = ecost;
            this.fcost = fcost;
            this.fmark = fmark != 0L;
            saved = true;
        }

        public EntOrder(long pcustomer, DateTime edate, DateTime bdate, DateTime cdate,
            String name, String objectS, bool fmark, long ecost, long fcost)
        {
            this.pcustomer = pcustomer;
            this.name = name;
            this.objectS = objectS;
            this.edate = edate;
            this.bdate = bdate;
            this.cdate = cdate;
            this.ecost = ecost;
            this.fcost = fcost;
            this.fmark = fmark;
            saved = false;
        }

        public override string ToString()
        {
            return name + (fmark ? " (завершен)" : "");
        }

        public string info()
        {
            return name;
        }

        public string[] infoLines()
        {
            return RData.stringToLines((fmark ? "(завершен)\n" : "") + "Название:\n" + name + "\nОписание объекта:\n" + objectS + "");
        }

        public void delete()
        {
            if (saved)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from orders where porder = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.porder));
                com.ExecuteNonQuery();
            }
        }

        public void deleteCascade()
        {
            if (saved)
            {
                foreach (EntPoint point in EntPoint.getWithOrder(porder))
                {
                    point.deleteCascade();
                }
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from orders where porder = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.porder));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update orders set edate = @edate, " +
                    "bdate = @bdate, cdate = @cdate, name = @name, object = @object, " +
                    "pcustomer = @pcustomer, fmark = @fmark, ecost = @ecost, " +
                    "fcost = @fcost where porder = @id";
                com.Parameters.Add(new SQLiteParameter("@id", porder));
                com.Parameters.Add(new SQLiteParameter("@edate", edate.ToBinary()));
                com.Parameters.Add(new SQLiteParameter("@bdate", bdate.ToBinary()));
                com.Parameters.Add(new SQLiteParameter("@cdate", cdate.ToBinary()));
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@object", objectS));
                com.Parameters.Add(new SQLiteParameter("@pcustomer", pcustomer));
                com.Parameters.Add(new SQLiteParameter("@fmark", (fmark ? 1L : 0L)));
                com.Parameters.Add(new SQLiteParameter("@ecost", ecost));
                com.Parameters.Add(new SQLiteParameter("@fcost", fcost));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into orders (edate, bdate, cdate, name, object, " +
                    "pcustomer, fmark, ecost, fcost) " +
                    "values (@edate, @bdate, @cdate, @name, @object, " +
                    "@pcustomer, @fmark, @ecost, @fcost)";
                com.Parameters.Add(new SQLiteParameter("@edate", edate.ToBinary()));
                com.Parameters.Add(new SQLiteParameter("@bdate", bdate.ToBinary()));
                com.Parameters.Add(new SQLiteParameter("@cdate", cdate.ToBinary()));
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@object", objectS));
                com.Parameters.Add(new SQLiteParameter("@pcustomer", pcustomer));
                com.Parameters.Add(new SQLiteParameter("@fmark", (fmark ? 1L : 0L)));
                com.Parameters.Add(new SQLiteParameter("@ecost", ecost));
                com.Parameters.Add(new SQLiteParameter("@fcost", fcost));
                com.ExecuteNonQuery();
                porder = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(long pcustomer, DateTime edate, DateTime bdate, DateTime cdate,
            String name, String objectS, bool fmark, long ecost, long fcost)
        {
            if (name.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show(@"Поле ""Название"" не может быть пустым.");
                return false;
            }
            if ((!edate.Equals(DateTime.MinValue) && !bdate.Equals(DateTime.MinValue)) && 
                    edate.CompareTo(bdate) < 0)
            {
                System.Windows.Forms.MessageBox.Show(@"Дата окончания не может быть раньше даты начала.");
                return false;
            }

            return true;
        }

        public static List<EntOrder> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from orders";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["porder"];
                long pcustomer = (long)reader["pcustomer"];
                long edate = (long)reader["edate"];
                long bdate = (long)reader["bdate"];
                long cdate = (long)reader["cdate"];
                String name = (String)reader["name"];
                String objectS = (String)reader["object"];
                long fmark = (long)reader["fmark"];
                long ecost = (long)reader["ecost"];
                long fcost = (long)reader["fcost"];

                list.Add(new EntOrder(id, pcustomer, edate, bdate, cdate, 
                    name, objectS, fmark, ecost, fcost));
            }
            return list;
        }

        public void update(long pcustomer, DateTime edate, DateTime bdate, DateTime cdate,
            String name, String objectS, bool fmark, long ecost, long fcost)
        {
            this.pcustomer = pcustomer;
            this.name = name;
            this.objectS = objectS;
            this.edate = edate;
            this.bdate = bdate;
            this.cdate = cdate;
            this.fmark = fmark;
            this.ecost = ecost;
            this.fcost = fcost;
        }
    }
}
