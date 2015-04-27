﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Rennovation.REntities
{
    class EntSpecial
    {
        static List<EntSpecial> list = new List<EntSpecial>();

        bool saved = false;
        long pcustomer = -1;

        String name = "";
        String contacts = "";

        EntSpecial(long id, String name, String contacts)
        {
            this.name = name;
            this.contacts = contacts;
            this.pcustomer = id;
            saved = true;
        }

        EntSpecial(String name, String contacts)
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

        public static List<EntSpecial> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from customers";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read()) {
                list.Add(new EntSpecial((long)reader["pcustomer"], (String)reader["name"], 
                    (String)reader["contacts"]));
            }
            return list;
        }

    }
}
