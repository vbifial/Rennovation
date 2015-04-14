using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Rennovation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            /*
            String dbName = @"data.db";
            //SQLiteConnection.CreateFile(dbName);
            SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + dbName + "; Version=3;");
            conn.Open();

            SQLiteCommand com = new SQLiteCommand();
            com.Connection = conn;

            String text = "";

            System.IO.StreamReader sr = new System.IO.StreamReader(@"..\..\script.sql");
            while (!sr.EndOfStream)
            {
                text = text + sr.ReadLine();
            }

            com.CommandText = text;

            com.ExecuteNonQuery();

            conn.Dispose();
             * */
        }
    }
}
