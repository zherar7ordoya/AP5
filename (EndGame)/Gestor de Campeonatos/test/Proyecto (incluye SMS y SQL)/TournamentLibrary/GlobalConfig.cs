using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using TournamentLibrary.DataAccess;

namespace TournamentLibrary
{
    public static class GlobalConfig    
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";

        public static IDataConnection Connection { get; private set; }                                          

        public static void InitializeConnection(DatabaseType db)                    
        {                                                                           
            if (db == DatabaseType.Sql)                     
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;                           
            }
            else if (db == DatabaseType.TextFile)           
            {                                               
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string cnnStringName)
        {
            return ConfigurationManager.ConnectionStrings[cnnStringName].ConnectionString;
        }

        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
