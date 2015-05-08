using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Rennovation.REntities
{
    public class EntWorker
    {
        static List<EntWorker> list = new List<EntWorker>();

        bool saved = false;
        public long pworker = -1;

        public String name = "";
        public String contacts = "";

        EntWorker(long id, String name, String contacts)
        {
            this.name = name;
            this.contacts = contacts;
            this.pworker = id;
            saved = true;
        }

        public EntWorker(String name, String contacts)
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
            return RData.stringToLines(contacts);
        }

        public void delete()
        {
            if (saved)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from workers where pworker = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.pworker));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update workers set name = @name, contacts = @cont " +
                    "where pworker = @id";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@cont", contacts));
                com.Parameters.Add(new SQLiteParameter("@id", pworker));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into workers (name, contacts) values (@name, @cont)";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@cont", contacts));
                com.ExecuteNonQuery();
                pworker = RData.getConnection().LastInsertRowId;
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

        public static List<EntWorker> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from workers";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read()) {
                list.Add(new EntWorker((long)reader["pworker"], (String)reader["name"], 
                    (String)reader["contacts"]));
            }
            return list;
        }

        public static EntWorker getWithId(long id)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from workers where pworker = @id";
            com.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                return (new EntWorker((long)reader["pworker"], (String)reader["name"],
                    (String)reader["contacts"]));
            }
            return null;
        }
    }
}
