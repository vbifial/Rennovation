using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Rennovation.REntities
{
    public class EntWorktype
    {
        static List<EntWorktype> list = new List<EntWorktype>();

        bool saved = false;
        long pcustomer = -1;

        String name = "";
        String contacts = "";

        EntWorktype(long id, String name, String contacts)
        {
            this.name = name;
            this.contacts = contacts;
            this.pcustomer = id;
            saved = true;
        }

        EntWorktype(String name, String contacts)
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

        public static List<EntWorktype> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from customers";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read()) {
                list.Add(new EntWorktype((long)reader["pcustomer"], (String)reader["name"], 
                    (String)reader["contacts"]));
            }
            return list;
        }

    }
}
