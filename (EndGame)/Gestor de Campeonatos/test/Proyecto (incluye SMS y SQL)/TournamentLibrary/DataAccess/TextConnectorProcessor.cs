using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor  
    {                                           
        public static string FullFilePath(this string fileName) 
        {                                                       
            return $"{ GlobalConfig.AppKeyLookup("filePath") }\\{ fileName }";              
        }

        public static List<string> LoadFile(this string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<string>();      
            }

            return File.ReadAllLines(filePath).ToList();                                                               
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();   
            
            foreach (string line in lines)                      
            {
                string[] cols = line.Split(',');                

                PrizeModel prize = new PrizeModel();            
                prize.Id = int.Parse(cols[0]);                  
                prize.PlaceNumber = int.Parse(cols[1]);         
                prize.PlaceName = cols[2];
                prize.PrizeAmount = decimal.Parse(cols[3]);
                prize.PrizePercentage = double.Parse(cols[4]);

                output.Add(prize);                              
            }

            return output;                                      
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');            

                PersonModel person = new PersonModel();
                person.Id = int.Parse(cols[0]);
                person.FirstName = cols[1];
                person.LastName = cols[2];
                person.EmailAddress = cols[3];
                person.CellphoneNumber = cols[4];

                output.Add(person);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)       
        {
            List<TeamModel> output = new List<TeamModel>();     

            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();    
                                                                                                            
            foreach (string line in lines)          
            {
                string[] cols = line.Split(',');    

                TeamModel team = new TeamModel();   
                team.Id = int.Parse(cols[0]);
                team.TeamName = cols[1];
                
                string[] personIds = cols[2].Split('|');    
                foreach (string id in personIds)
                {
                    team.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(team);   
            }

            return output;          
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)  
        { 
            List<TournamentModel> output = new List<TournamentModel>();     
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');            

                TournamentModel tm = new TournamentModel(); 
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');      
                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');
                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());    
                    } 
                }

                string[] rounds = cols[5].Split('|');

                foreach (string round in rounds)
                {
                    string[] matchesText = round.Split('^');

                    List<MatchupModel> matches = new List<MatchupModel>();  
                                                                           
                    foreach (string matchupModelTextId in matchesText)
                    {
                        matches.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }

                    tm.Rounds.Add(matches); 
                }

                output.Add(tm);
            }

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();    

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);              
        }

        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellphoneNumber }");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);              
        }

        
        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();                

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{ t.TeamName },{ t.TeamMembers.ConvertPeopleListToString() }");    
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);                
        }

        public static void SaveRoundsToFile(this TournamentModel model)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile();
                }
            }
        }

        public static void SaveMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();      

            int currentId = 1;
            if (matchups.Count > 0)
            {
                int highestId = matchups.OrderByDescending(x => x.Id).First().Id;
                currentId = highestId + 1;
            }

            matchup.Id = currentId;
            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveMatchupEntryToFile();     
            }

            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{ m.Id },{ m.Entries.ConvertMatchupEntryListToString() },{ winner },{ m.MatchupRound }"); 
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void UpdateMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();  

            MatchupModel oldMatchup = new MatchupModel();   
            
            foreach (MatchupModel m in matchups)
            {
                if (m.Id == matchup.Id)
                {
                    oldMatchup = m;                                                 
                }
            }

            matchups.Remove(oldMatchup);            
            matchups.Add(matchup);                  

            foreach (MatchupEntryModel entry in matchup.Entries)    
            {
                entry.UpdateMatchupEntryToFile();               
            }

            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{ m.Id },{ m.Entries.ConvertMatchupEntryListToString() },{ winner },{ m.MatchupRound }");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel matchup = new MatchupModel();
                matchup.Id = int.Parse(cols[0]);
                matchup.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                
                if (cols[2].Length == 0)
                {
                    matchup.Winner = null;
                }
                else
                {
                    matchup.Winner = LookupTeamById(int.Parse(cols[2]));
                }

                matchup.MatchupRound = int.Parse(cols[3]);

                output.Add(matchup);
            }

            return output;
        }

        public static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();                              
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }

            output = matchingEntries.ConvertToMatchupEntryModels();     
            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupEntryModel entry = new MatchupEntryModel();
                entry.Id = int.Parse(cols[0]);

                if (cols[1].Length == 0)
                {
                    entry.TeamCompeting = null;
                }
                else
                {
                    entry.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }

                entry.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))                        
                {                                                               
                    entry.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {                                                               
                    entry.ParentMatchup = null;                                 
                }
                
                output.Add(entry);
            }

            return output;
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels().First();
                }
            }

            return null;
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }

            return null;
        }

        public static void SaveMatchupEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;
            if (entries.Count > 0)
            {
                int highestId = entries.OrderByDescending(x => x.Id).First().Id;
                currentId = highestId + 1;
            }

            entry.Id = currentId;
            entries.Add(entry);     

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel me in entries)
            {
                string parent = "";
                if (me.ParentMatchup != null)
                {
                    parent = me.ParentMatchup.Id.ToString();
                }

                string teamCompeting = "";
                if (me.TeamCompeting != null)
                {
                    teamCompeting = me.TeamCompeting.Id.ToString();
                }
                
                lines.Add($"{ me.Id },{ teamCompeting },{ me.Score },{ parent }");          
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static void UpdateMatchupEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();    

            MatchupEntryModel oldEntry = new MatchupEntryModel();   

            foreach (MatchupEntryModel e in entries)
            {
                if (e.Id == entry.Id)
                {
                    oldEntry = e;                 
                }
            }

            entries.Remove(oldEntry);            
            entries.Add(entry);                  

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel me in entries)
            {
                string parent = "";
                if (me.ParentMatchup != null)
                {
                    parent = me.ParentMatchup.Id.ToString();
                }

                string teamCompeting = "";
                if (me.TeamCompeting != null)
                {
                    teamCompeting = me.TeamCompeting.Id.ToString();
                }

                lines.Add($"{ me.Id },{ teamCompeting },{ me.Score },{ parent }");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();    

            foreach (TournamentModel tm in models)
            {
                lines.Add($"{ tm.Id },{ tm.TournamentName },{ tm.EntryFee },{ tm.EnteredTeams.ConvertTeamListToString() },{ tm.Prizes.ConvertPrizeListToString() },{ tm.Rounds.ConvertRoundListToString() }");
            }

            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);          
        }

        private static string ConvertTeamListToString(this List<TeamModel> teams)
        {
            string output = "";                 

            if (teams.Count == 0)               
            {
                return "";
            }

            foreach (TeamModel t in teams)      
            {
                output += $"{ t.Id }|";         
            }

            output = output.Substring(0, output.Length - 1);                                                   
            return output;
        }

        private static string ConvertPrizeListToString(this List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertRoundListToString(this List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> r in rounds)                
            {
                output += $"{ r.ConvertMatchupListToString() }|";   
            }

            output = output.Substring(0, output.Length - 1);                                                              
            return output;
        }

        private static string ConvertMatchupListToString(this List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel m in matchups)
            {
                output += $"{ m.Id }^";                         
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertMatchupEntryListToString(this List<MatchupEntryModel> entries)
        {
            string output = "";

            if (entries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel me in entries)
            {
                output += $"{ me.Id }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertPeopleListToString(this List<PersonModel> people)
        {
            string output = "";                                 

            if (people.Count == 0)
            {
                return "";
            }
            
            foreach (PersonModel p in people)                   
            {
                output += $"{ p.Id }|";                         
            }

            output = output.Substring(0, output.Length - 1);    
            return output;                                      
        }
    }
}
