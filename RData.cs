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
        public static frmLevelAdding levelAddingForm;
        public static frmSpecialAdding specialAddingForm;
        public static frmOrderAdding orderAddingForm;
        public static frmPointAdding pointAddingForm;
        public static frmAssignAdding assignAddingForm;
        public static frmIntervalAdding intervalAddingForm;

        public static void initForms()
        {
            RData.referenceForm = new frmReference();
            RData.clientAddingForm = new frmCustomerAdding();
            RData.worktypeAddingForm = new frmWorktypeAdding();
            RData.workerAddingForm = new frmWorkerAdding();
            RData.qualAddingForm = new frmQualAdding();
            RData.levelAddingForm = new frmLevelAdding();
            RData.specialAddingForm = new frmSpecialAdding();
            RData.orderAddingForm = new frmOrderAdding();
            RData.pointAddingForm = new frmPointAdding();
            RData.assignAddingForm = new frmAssignAdding();
            RData.intervalAddingForm = new frmIntervalAdding();
        }

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

        public static int hoursCnt = 12;
        public static int startHour = 8;

        public static int foreignCode = -2147467259;

        #endregion
    }
}
