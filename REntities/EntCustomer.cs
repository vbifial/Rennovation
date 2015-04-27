using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Rennovation.REntities
{
    public class EntCustomer
    {
        static List<EntCustomer> list = new List<EntCustomer>();

        bool saved = false;
        long pcustomer = -1;

        public String name = "";
        public String contacts = "";

        EntCustomer(long id, String name, String contacts)
        {
            this.name = name;
            this.contacts = contacts;
            this.pcustomer = id;
            saved = true;
        }

        public EntCustomer(String name, String contacts)
        {
            this.name = name;
            this.contacts = contacts;
            saved = false;
        }

        public override string ToString()
        {
            return name;
        }

        public string info()
        {
            return contacts;
        }

        public string[] infoLines()
        {
            string[] ret = new string[1];
            ret[0] = contacts;
            return ret;
        }

        public void delete()
        {
            if (saved)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from customers where pcustomer = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.pcustomer));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update customers set name = @name, contacts = @cont " +
                    "where pcustomer = @id";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@cont", contacts));
                com.Parameters.Add(new SQLiteParameter("@id", pcustomer));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into customers (name, contacts) values (@name, @cont)";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@cont", contacts));
                com.ExecuteNonQuery();
                pcustomer = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(String name, String contacts)
        {
            if (name.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show(@"Поле ""ФИО"" не может быть пустым.");
                return false;
            }
            return true;
        }

        public static List<EntCustomer> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from customers";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read()) {
                list.Add(new EntCustomer((long)reader["pcustomer"], (String)reader["name"], 
                    (String)reader["contacts"]));
            }
            return list;
        }

    }
}
