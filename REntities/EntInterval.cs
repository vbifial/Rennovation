﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Rennovation.REntities
{
    public class EntInterval
    {
        static List<EntInterval> list = new List<EntInterval>();

        bool saved = false;
        public long pinterval = -1;

        public long passign;

        /// <summary>
        /// Дата планируемая 
        /// </summary>
        public DateTime edate;
        /// <summary>
        /// Дата фактическая
        /// </summary>
        public DateTime fdate;

        public long estime;
        public long eetime;

        public long fstime;
        public long fetime;


        public bool emark;

        EntInterval(long id, long passign, long edate, long fdate, 
                long estime, long eetime, long fstime, long fetime, long emark)
        {
            this.passign = passign;
            this.pinterval = id;
            this.edate = DateTime.FromBinary(edate);
            this.fdate = DateTime.FromBinary(fdate);
            this.estime = estime;
            this.eetime = eetime;
            this.fstime = fstime;
            this.fetime = fetime;
            this.emark = emark != 0L;
            saved = true;
        }

        public EntInterval(long passign, DateTime edate, DateTime fdate,
            long estime, long eetime, long fstime, long fetime, bool emark)
        {
            this.passign = passign;
            this.edate = edate;
            this.fdate = fdate;
            this.estime = estime;
            this.eetime = eetime;
            this.fstime = fstime;
            this.fetime = fetime;
            this.emark = emark;
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
                com.CommandText = "delete from intervals where pinterval = @id";
                com.Parameters.Add(new SQLiteParameter("@id", this.pinterval));
                com.ExecuteNonQuery();
            }
        }

        public void save()
        {
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            if (saved)
            {
                com.CommandText = "update intervals set edate = @edate, " +
                    "fdate = @fdate, passign = @passign, emark = @emark, estime = @estime, " +
                    "eetime = @eetime, fstime = @fstime, fetime = @fetime where pinterval = @id";
                com.Parameters.Add(new SQLiteParameter("@id", pinterval));
                com.Parameters.Add(new SQLiteParameter("@edate", edate.Ticks));
                com.Parameters.Add(new SQLiteParameter("@fdate", fdate.Ticks));
                com.Parameters.Add(new SQLiteParameter("@passign", passign));
                com.Parameters.Add(new SQLiteParameter("@emark", (emark ? 1L : 0L)));
                com.Parameters.Add(new SQLiteParameter("@estime", estime));
                com.Parameters.Add(new SQLiteParameter("@eetime", eetime));
                com.Parameters.Add(new SQLiteParameter("@fstime", fstime));
                com.Parameters.Add(new SQLiteParameter("@fetime", fetime));
                com.ExecuteNonQuery();
            }
            else
            {
                com.CommandText = "insert into intervals (edate, fdate, " +
                    "passign, emark, estime, eetime, fstime, fetime) " +
                    "values (@edate, @fdate, @passign, @emark, @estime, @eetime, @fstime, @fetime)";
                com.Parameters.Add(new SQLiteParameter("@edate", edate.Ticks));
                com.Parameters.Add(new SQLiteParameter("@fdate", fdate.Ticks));
                com.Parameters.Add(new SQLiteParameter("@passign", passign));
                com.Parameters.Add(new SQLiteParameter("@emark", (emark ? 1L : 0L)));
                com.Parameters.Add(new SQLiteParameter("@estime", estime));
                com.Parameters.Add(new SQLiteParameter("@eetime", eetime));
                com.Parameters.Add(new SQLiteParameter("@fstime", fstime));
                com.Parameters.Add(new SQLiteParameter("@fetime", fetime));
                com.ExecuteNonQuery();
                pinterval = RData.getConnection().LastInsertRowId;
                saved = true;
            }
        }

        public static bool check(long passign, DateTime edate, DateTime fdate,
            bool emark, long estime, long eetime, long fstime, long fetime)
        {
            //if (name.Equals(""))
            //{
            //    System.Windows.Forms.MessageBox.Show(@"Поле ""Название"" не может быть пустым.");
            //    return false;
            //}
            //if ((!edate.Equals(DateTime.MinValue) && !fdate.Equals(DateTime.MinValue)) && 
            //        edate.CompareTo(fdate) < 0)
            //{
            //    System.Windows.Forms.MessageBox.Show(@"Дата окончания не может быть раньше даты начала.");
            //    return false;
            //}
            
            //SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            //com.CommandText = "select count(pinterval) from intervals where pworker = @pworker " +
            //    "and pqual = @pqual and pinterval <> @pinterval";
            //com.Parameters.Add(new SQLiteParameter("@pworker", pworker));
            //com.Parameters.Add(new SQLiteParameter("@pqual", pqual));
            //com.Parameters.Add(new SQLiteParameter("@pinterval", pinterval));
            //long count = (long)(com.ExecuteScalar());
            //return count == 0;

            return true;
        }

        public static List<EntInterval> getAll()
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from intervals";
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["pinterval"];
                long passign = (long)reader["passign"];
                long edate = (long)reader["edate"];
                long fdate = (long)reader["fdate"];
                long emark = (long)reader["emark"];
                long estime = (long)reader["estime"];
                long eetime = (long)reader["eetime"];
                long fstime = (long)reader["fstime"];
                long fetime = (long)reader["fetime"];

                list.Add(new EntInterval(id, passign, edate, fdate, estime, eetime, 
                    fstime, fetime, emark));
            }
            return list;
        }

        public static List<EntInterval> getWithAssign(long passign)
        {
            list.Clear();
            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "select * from intervals where passign = @passign";
            com.Parameters.Add(new SQLiteParameter("@passign", passign));
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                long id = (long)reader["pinterval"];
                long edate = (long)reader["edate"];
                long fdate = (long)reader["fdate"];
                long emark = (long)reader["emark"];
                long estime = (long)reader["estime"];
                long eetime = (long)reader["eetime"];
                long fstime = (long)reader["fstime"];
                long fetime = (long)reader["fetime"];

                list.Add(new EntInterval(id, passign, edate, fdate, estime, eetime,
                    fstime, fetime, emark));
            }
            return list;
        }

        public void update(long passign, DateTime edate, DateTime fdate,
            bool emark, long estime, long eetime, long fstime, long fetime)
        {
            this.passign = passign;
            this.edate = edate;
            this.fdate = fdate;
            this.emark = emark;
            this.estime = estime;
            this.eetime = eetime;
            this.fstime = fstime;
            this.fetime = fetime;
        }

        public EntAssign getAssign()
        {
            return EntAssign.getWithId(passign);
        }
    }
}
