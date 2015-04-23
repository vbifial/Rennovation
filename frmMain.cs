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
            RData.mainForm = this;
            InitializeComponent();
            RData.referenceForm = new frmReference();

            RData.checkTables();

            SQLiteCommand com = new SQLiteCommand(RData.getConnection());
            com.CommandText = "insert into customers (name, contacts) values ('FIO1', 'cont1');" +
                "insert into customers (name, contacts) values ('FIO2', 'cont2');" +
                "insert into customers (name, contacts) values ('FIO3', 'cont3');" +
                "insert into customers (name, contacts) values ('FIO4', 'cont4');";
            //com.ExecuteNonQuery();
            this.Text = "" + RData.getConnection().LastInsertRowId;

            RData.referenceForm.ShowDialog();

            
            //RData.getConnection().LastInsertRowId;


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

        public void mstReferenceClick(object sender, EventArgs e)
        {
            RData.referenceForm.ShowDialog();
        }
    }
}
