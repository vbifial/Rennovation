using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using Rennovation.REntities;

namespace Rennovation
{
    static class RData
    {
        #region код, связанный с подключением к базе
        private static String dbName = @"data.db";
        private static String sqlCreateScriptName = @"script.sql";
        private static String sqlDataScriptName = @"script-data.sql";
        private static SQLiteConnection con;
        private static String constring = "Data Source=" + 
            dbName + "; Version=3;";

        public static SQLiteConnection getConnection()
        {
            if (con == null || con.State != System.Data.ConnectionState.Open)
            {
                con = new SQLiteConnection(constring);
                con.Open();
            }
            return con;
        }

        public static void checkTables() 
        {
            runExternalScript(sqlCreateScriptName);
        }

        public static void addSampleData()
        {
            runExternalScript(sqlDataScriptName);
        }

        private static void runExternalScript(String filename)
        {
            StreamReader reader = new StreamReader(filename);
            String commandText = "";
            while (!reader.EndOfStream)
            {
                commandText = commandText + reader.ReadLine();
            }
            SQLiteCommand com = new SQLiteCommand(commandText, getConnection());
            com.ExecuteNonQuery();
        }
        #endregion

        #region код, связанный с созданием и хранением форм
        public static frmMain mainForm;
        public static frmReference referenceForm;

        #endregion
    }
}
