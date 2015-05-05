using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Rennovation.REntities
{
    public class EntLevel
    {
        static List<EntLevel> list = new List<EntLevel>();

        bool saved = false;
        public long plevel = -1;

        public String name = "";
        public long value = 0;
        public long pworktype = 0;

        EntLevel(long id, String name, long value, long pworktype)
        {
            this.name = name;
            this.value = value;
            this.plevel = id;
            this.pworktype = pworktype;
            saved = true;
        }

        public EntLevel(String name, long value, long pworktype)
        {
            this.name = name;
            this.value = value;
            this.pworktype = pworktype;
            saved = false;
        }

        public override string ToString()
        {
            return name;
        }

        public string info()
        {
            return name;
        }

        public string[] infoLines()
        {
            return RData.stringToLines(name);
        }

        public void delete()
        {
            if (saved)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from levels where plevel = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.plevel));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update levels set name = @name, pworktype = @pworktype, " +
                    "value = @value where plevel = @id";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@pworktype", pworktype));
                com.Parameters.Add(new SQLiteParameter("@value", value));
                com.Parameters.Add(new SQLiteParameter("@id", plevel));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into levels (name, pworktype, value) " +
                    "values (@name, @pworktype, @value)";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@pworktype", pworktype));
                com.Parameters.Add(new SQLiteParameter("@value", value)); ;
                com.ExecuteNonQuery();
                plevel = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(String name, long value)
        {
            if (name.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show(@"Поле ""ФИО"" не может быть пустым.");
                return false;
            }
            return true;
        }

        public static List<EntLevel> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from levels";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EntLevel((long)reader["plevel"], (String)reader["name"],
                    (long)reader["value"], (long)reader["pworktype"]));
            }
            return list;
        }

        public static List<EntLevel> getWithWorktype(long pworktype)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from levels where pworktype = @pworktype";
            com.Parameters.Add(new SQLiteParameter("@pworktype", pworktype));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EntLevel((long)reader["plevel"], (String)reader["name"],
                    (long)reader["value"], (long)reader["pworktype"]));
            }
            return list;
        }

        public static EntLevel getWithId(long plevel)
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from levels where plevel = @plevel";
            com.Parameters.Add(new SQLiteParameter("@plevel", plevel));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                return (new EntLevel((long)reader["plevel"], (String)reader["name"],
                    (long)reader["value"], (long)reader["pworktype"]));
            }
            return null;
        }

        public EntWorktype getWorktype()
        {
            return EntWorktype.getWorktype(pworktype);
        }
    }
}
