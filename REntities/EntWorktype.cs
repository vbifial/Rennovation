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
        public long pworktype = -1;

        public String name = "";

        EntWorktype(long id, String name)
        {
            this.name = name;
            this.pworktype = id;
            saved = true;
        }

        public EntWorktype(String name)
        {
            this.name = name;
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

        public void delete()
        {
            if (saved)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "delete from worktypes where pworktype = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.pworktype));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update worktypes set name = @name " +
                    "where pworktype = @id";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@id", pworktype));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into worktypes (name) values (@name)";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.ExecuteNonQuery();
                pworktype = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(String name)
        {
            if (name.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show(@"Поле ""Название"" не может быть пустым.");
                return false;
            }
            return true;
        }

        public static List<EntWorktype> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from worktypes";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read()) {
                list.Add(new EntWorktype((long)reader["pworktype"], (String)reader["name"]));
            }
            return list;
        }

        public static EntWorktype getWorktype(long pworktype)
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from worktypes where pworktype = @pworktype";
            com.Parameters.Add(new SQLiteParameter("@pworktype", pworktype));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                return new EntWorktype((long)reader["pworktype"], (String)reader["name"]);
            }
            return null;
        }
    }
}
