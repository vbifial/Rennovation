﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Rennovation.REntities
{
    public class EntQual
    {
        static List<EntQual> list = new List<EntQual>();

        bool saved = false;
        public long pqual = -1;

        public String name = "";
        public long lvalue = 0;
        public long value = 0;
        public long pworktype = 0;

        EntQual(long id, String name, long lvalue, long value, long pworktype)
        {
            this.name = name;
            this.lvalue = lvalue;
            this.value = value;
            this.pqual = id;
            this.pworktype = pworktype;
            saved = true;
        }

        public EntQual(String name, long lvalue, long value, long pworktype)
        {
            this.name = name;
            this.lvalue = lvalue;
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
                com.CommandText = "delete from quals where pqual = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.pqual));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update quals set name = @name, pworktype = @pworktype, " +
                    "lvalue = @lvalue, value = @value where pqual = @id";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@pworktype", pworktype));
                com.Parameters.Add(new SQLiteParameter("@lvalue", lvalue));
                com.Parameters.Add(new SQLiteParameter("@value", value));
                com.Parameters.Add(new SQLiteParameter("@id", pqual));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into quals (name, pworktype, lvalue, value) " +
                    "values (@name, @pworktype, @lvalue, @value)";
                com.Parameters.Add(new SQLiteParameter("@name", name));
                com.Parameters.Add(new SQLiteParameter("@pworktype", pworktype));
                com.Parameters.Add(new SQLiteParameter("@lvalue", lvalue));
                com.Parameters.Add(new SQLiteParameter("@value", value)); ;
                com.ExecuteNonQuery();
                pqual = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(long id, String name, long lvalue, long value)
        {
            if (name.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show(@"Поле ""ФИО"" не может быть пустым.");
                return false;
            }
            if (lvalue < 0 || value < 0)
            {
                System.Windows.Forms.MessageBox.Show(
                    @"Значения показателя и оплаты должы быть неотрицательными.");
                return false;
            }
            if (id != -1)
            {
                SQLiteCommand com = new SQLiteCommand(RData.getConnection());
                com.CommandText = "select qls.lvalue qval, lvs.value lval " +
                    "from levels lvs, points pts, assignments ass, " +
                    "specials sps, quals qls where qls.pqual = @id and " +
                    "lvs.plevel = pts.plevel and pts.ppoint = ass.ppoint and " +
                    "ass.pworker = sps.pworker and sps.pqual = qls.pqual and " +
                    "qls.pworktype = lvs.pworktype";

                com.Parameters.Add(new SQLiteParameter("@id", id));
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    long lval = (long)reader["lval"];
                    long qval = (long)reader["qval"];
                    if (qval >= lval && lval > lvalue)
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Заданные значения конфликтуют с существующим назначением.");
                        return false;
                    }
                }
            }
            return true;
        }

        public static List<EntQual> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from quals";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EntQual((long)reader["pqual"], (String)reader["name"],
                    (long)reader["lvalue"], (long)reader["value"], (long)reader["pworktype"]));
            }
            return list;
        }

        public static List<EntQual> getWithWorktype(long pworktype)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from quals where pworktype = @pworktype";
            com.Parameters.Add(new SQLiteParameter("@pworktype", pworktype));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EntQual((long)reader["pqual"], (String)reader["name"],
                    (long)reader["lvalue"], (long)reader["value"], (long)reader["pworktype"]));
            }
            return list;
        }

        public static EntQual getQual(long pqual)
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from quals where pqual = @pqual";
            com.Parameters.Add(new SQLiteParameter("@pqual", pqual));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                return new EntQual((long)reader["pqual"], (String)reader["name"],
                    (long)reader["lvalue"], (long)reader["value"], (long)reader["pworktype"]);
            }
            return null;
        }

        public EntWorktype getWorktype()
        {
            return EntWorktype.getWorktype(pworktype);
        }
    }
}
