using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Rennovation.REntities
{
    public class EntAssign
    {
        static List<EntAssign> list = new List<EntAssign>();

        bool saved = false;
        public long passign = -1;

        public long porder;
        public long pworker;

        public long amount;

        EntAssign(long id, long porder, long pworker, long amount)
        {
            this.passign = id;
            this.porder = porder;
            this.pworker = pworker;
            this.amount = amount;
            saved = true;
        }

        public EntAssign(long porder, long pworker, long amount)
        {
            this.porder = porder;
            this.pworker = pworker;
            this.amount = amount;
            saved = false;
        }

        public override string ToString()
        {
            return null;
        }

        public string info()
        {
            return null;
        }

        public string[] infoLines()
        {
            return null;
        }

        public void delete()
        {
            if (saved)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from assigns where passign = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.passign));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update assigns set " +
                    "porder = @porder, pworker = @pworker, " +
                    "amount = @amount where passign = @id";
                com.Parameters.Add(new SQLiteParameter("@id", passign));
                com.Parameters.Add(new SQLiteParameter("@porder", porder));
                com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
                com.Parameters.Add(new SQLiteParameter("@amount", amount));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into assigns (porder, pworker, amount) " +
                    "values (@porder, @pworker, @amount)";
                com.Parameters.Add(new SQLiteParameter("@porder", porder));
                com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
                com.Parameters.Add(new SQLiteParameter("@amount", amount));
                com.ExecuteNonQuery();
                passign = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(long porder, long pworker, long amount)
        {
            //if (name.Equals(""))
            //{
            //    System.Windows.Forms.MessageBox.Show(@"Поле ""Название"" не может быть пустым.");
            //    return false;
            //}
            //if ((!edate.Equals(DateTime.MinValue) && !bdate.Equals(DateTime.MinValue)) && 
            //        edate.CompareTo(bdate) < 0)
            //{
            //    System.Windows.Forms.MessageBox.Show(@"Дата окончания не может быть раньше даты начала.");
            //    return false;
            //}
            
            //SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            //com.CommandText = "select count(passign) from assigns where pworker = @pworker " +
            //    "and pqual = @pqual and passign <> @passign";
            //com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
            //com.Parameters.Add(new SQLiteParameter("@pqual", pqual));
            //com.Parameters.Add(new SQLiteParameter("@passign", passign));
            //long count = (long)(com.ExecuteScalar());
            //return count == 0;

            return true;
        }

        public static List<EntAssign> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from assigns";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["passign"];
                long porder = (long)reader["porder"];
                long pworker = (long)reader["pworker"];
                long amount = (long)reader["amount"];

                list.Add(new EntAssign(id, porder, pworker, amount));
            }
            return list;
        }

        public static List<EntAssign> getWithOrder(int porder)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from assigns where porder = @porder";
            com.Parameters.Add(new SQLiteParameter("@porder", porder));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["passign"];
                long pworker = (long)reader["pworker"];
                long amount = (long)reader["amount"];

                list.Add(new EntAssign(id, porder, pworker, amount));
            }
            return list;
        }

        public static List<EntAssign> getWithWorker(int pworker)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from assigns where pworker = @pworker";
            com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["passign"];
                long porder = (long)reader["porder"];
                long amount = (long)reader["amount"];

                list.Add(new EntAssign(id, porder, pworker, amount));
            }
            return list;
        }

        public static EntAssign getWithId(long id)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from assigns where passign = @id";
            com.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long porder = (long)reader["porder"];
                long amount = (long)reader["amount"];
                long pworker = (long)reader["pworker"];

                return (new EntAssign(id, porder, pworker, amount));
            }
            return null;
        }

        public void update(long porder, long pworker, long amount)
        {
            this.porder = porder;
            this.pworker = pworker;
            this.amount = amount;
        }

        public EntWorker getWorker()
        {
            return EntWorker.getWithId(pworker);
        }
    }
}
