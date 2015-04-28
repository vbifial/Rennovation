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
        
        public static void enableForeignKeysSupport()
        {
            String commandText = "PRAGMA foreign_keys = ON;";
            SQLiteCommand com = new SQLiteCommand(commandText, getConnection());
            com.ExecuteNonQuery();
        }
        #endregion

        #region код, связанный с созданием и хранением форм
        
        public static frmMain mainForm;
        public static frmReference referenceForm;
        public static frmCustomerAdding clientAddingForm;
        public static frmWorktypeAdding worktypeAddingForm;
        public static frmWorkerAdding workerAddingForm;
        public static frmQualAdding qualAddingForm;

        #endregion

        #region global additional code

        public static String linesToString(String[] lines)
        {
            StringBuilder ret = new StringBuilder();
            if (lines.Length > 0)
                ret.Append(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                ret.Append('\n');
                ret.Append(lines[i]);
            }

            return ret.ToString();
        }

        public static String[] stringToLines(String s)
        {
            char[] sep = {'\n'};
            return s.Split(sep, 10000, StringSplitOptions.None);
        }

        #endregion
    }
}
