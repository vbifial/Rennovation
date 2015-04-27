using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Rennovation.REntities
{
    class EntQual
    {
        static List<EntQual> list = new List<EntQual>();

        bool saved = false;
        long pcustomer = -1;

        String name = "";
        String contacts = "";

        EntQual(long id, String name, String contacts)
        {
            this.name = name;
            this.contacts = contacts;
            this.pcustomer = id;
            saved = true;
        }

        EntQual(String name, String contacts)
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

        public static List<EntQual> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from customers";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read()) {
                list.Add(new EntQual((long)reader["pcustomer"], (String)reader["name"], 
                    (String)reader["contacts"]));
            }
            return list;
        }

    }
}
