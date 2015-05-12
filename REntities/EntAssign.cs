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

        public long ppoint;
        public long pworker;

        public long amount;

        EntAssign(long id, long ppoint, long pworker, long amount)
        {
            this.passign = id;
            this.ppoint = ppoint;
            this.pworker = pworker;
            this.amount = amount;
            saved = true;
        }

        public EntAssign(long ppoint, long pworker, long amount)
        {
            this.ppoint = ppoint;
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
                com.CommandText = "delete from assignments where passign = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.passign));
                com.ExecuteNonQuery();
            }
        }

        public void deleteCascade()
        {
            if (saved)
            {
                foreach (EntInterval inter in EntInterval.getWithAssign(passign))
                {
                    inter.delete();
                }
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from assignments where passign = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.passign));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update assignments set " +
                    "ppoint = @ppoint, pworker = @pworker, " +
                    "amount = @amount where passign = @id";
                com.Parameters.Add(new SQLiteParameter("@id", passign));
                com.Parameters.Add(new SQLiteParameter("@ppoint", ppoint));
                com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
                com.Parameters.Add(new SQLiteParameter("@amount", amount));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into assignments (ppoint, pworker, amount) " +
                    "values (@ppoint, @pworker, @amount)";
                com.Parameters.Add(new SQLiteParameter("@ppoint", ppoint));
                com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
                com.Parameters.Add(new SQLiteParameter("@amount", amount));
                com.ExecuteNonQuery();
                passign = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(long id, long ppoint, long pworker, long amount)
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


            if (amount <= 0)
            {
                System.Windows.Forms.MessageBox.Show(
                    @"Объем работы должен быть положительным целым числом часов.");
                return false;
            }

            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select count(passign) from assignments where pworker = @pworker " +
                "and ppoint = @ppoint and passign <> @id";
            com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
            com.Parameters.Add(new SQLiteParameter("@ppoint", ppoint));
            com.Parameters.Add(new SQLiteParameter("@id", id));
            long count = (long)(com.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Нельзя назрачить работника на один пункт заказа два раза.");
                return false;
            }

            return true;
        }

        public static List<EntAssign> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from assignments";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["passign"];
                long ppoint = (long)reader["ppoint"];
                long pworker = (long)reader["pworker"];
                long amount = (long)reader["amount"];

                list.Add(new EntAssign(id, ppoint, pworker, amount));
            }
            return list;
        }

        public static List<EntAssign> getWithPoint(long ppoint)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from assignments where ppoint = @ppoint";
            com.Parameters.Add(new SQLiteParameter("@ppoint", ppoint));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["passign"];
                long pworker = (long)reader["pworker"];
                long amount = (long)reader["amount"];

                list.Add(new EntAssign(id, ppoint, pworker, amount));
            }
            return list;
        }

        public static List<EntAssign> getWithWorker(long pworker)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from assignments where pworker = @pworker";
            com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["passign"];
                long ppoint = (long)reader["ppoint"];
                long amount = (long)reader["amount"];

                list.Add(new EntAssign(id, ppoint, pworker, amount));
            }
            return list;
        }

        public static EntAssign getWithId(long id)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from assignments where passign = @id";
            com.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long ppoint = (long)reader["ppoint"];
                long amount = (long)reader["amount"];
                long pworker = (long)reader["pworker"];

                return (new EntAssign(id, ppoint, pworker, amount));
            }
            return null;
        }

        public void update(long ppoint, long pworker, long amount)
        {
            this.ppoint = ppoint;
            this.pworker = pworker;
            this.amount = amount;
        }

        public EntWorker getWorker()
        {
            return EntWorker.getWithId(pworker);
        }
    }
}
