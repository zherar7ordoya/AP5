using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TournamentLibrary.Logic;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private readonly string connectionString = GlobalConfig.CnnString("TournamentsDB");

        public void CreatePerson(PersonModel model)      
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", model.FirstName);
                parameters.Add("@LastName", model.LastName);
                parameters.Add("@EmailAddress", model.EmailAddress);
                parameters.Add("@CellphoneNumber", model.CellphoneNumber);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);   

                connection.Execute("dbo.spPeople_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@id");
            }
        }

        public void CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))     
            {                                                                           
                var p = new DynamicParameters();                
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);    

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");   
            }
        }

        public void CreateTeam(TeamModel model)             
        {
            using (IDbConnection connection = new SqlConnection(connectionString))                     
            {
                var p = new DynamicParameters();                                                        
                p.Add("@TeamName", model.TeamName);                                                     
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);            
                
                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);  

                model.Id = p.Get<int>("@id");                                                           

                foreach (PersonModel person in model.TeamMembers)   
                {
                    p = new DynamicParameters();                    
                    p.Add("@TeamId", model.Id);                     
                    p.Add("@PersonId", person.Id);                  
                                                                                                            
                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);    
                }
            }
        }

        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                SaveTournament(connection, model);          
                SaveTournamentPrizes(connection, model);    
                SaveTournamentEntries(connection, model);
                SaveTournamentRounds(connection, model);
                TournamentLogic.UpdateTournamentResults(model);     
            }
        }

        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");   
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel prize in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", prize.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel team in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", team.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.Id = p.Get<int>("@id");   
                                                      
                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);
                        
                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
                        }
                        
                        if (entry.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingId", null);
                        }
                        else
                        {
                            p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        }
                        
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);

                        entry.Id = p.Get<int>("@id");
                    }
                }
            }
        }

    public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;                                                   
            
            using (IDbConnection connection = new SqlConnection(connectionString))     
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList(); 
            }

            return output;                                                              
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;                                                     

            using (IDbConnection connection = new SqlConnection(connectionString))     
            {
                output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();    

                foreach (TeamModel team in output)      
                {                                       
                    var p = new DynamicParameters();    
                    p.Add("@TeamId", team.Id);          

                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();   
                }
            }

            return output;                                                              
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();
                var p = new DynamicParameters();

                foreach (TournamentModel tournament in output)
                {
                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournament.Id);
                    tournament.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournament.Id);
                    tournament.EnteredTeams = connection.Query<TeamModel>("dbo.spTeams_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (TeamModel team in tournament.EnteredTeams)
                    {
                        p = new DynamicParameters();
                        p.Add("@TeamId", team.Id);

                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                    }

                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournament.Id);
                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchupModel matchup in matchups)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);
                        matchup.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();

                        List<TeamModel> allTeams = GetTeam_All();

                        if (matchup.WinnerId > 0)                                                   
                        {
                            matchup.Winner = allTeams.Where(x => x.Id == matchup.WinnerId).First();
                        }

                        foreach (MatchupEntryModel matchupEntry in matchup.Entries)
                        {
                            if (matchupEntry.TeamCompetingId > 0)   
                            {
                                matchupEntry.TeamCompeting = allTeams.Where(x => x.Id == matchupEntry.TeamCompetingId).First();
                            }

                            if (matchupEntry.ParentMatchupId > 0)
                            {
                                matchupEntry.ParentMatchup = matchups.Where(x => x.Id == matchupEntry.ParentMatchupId).First();
                            }
                        }
                    }

                    List<MatchupModel> currentRow = new List<MatchupModel>();
                    int currentRound = 1;                                       
                    
                    foreach (MatchupModel matchup in matchups)
                    {
                        if (matchup.MatchupRound > currentRound)    
                        {
                            tournament.Rounds.Add(currentRow);      
                                                                    
                            currentRow = new List<MatchupModel>();  
                            currentRound += 1;                      
                        }

                        currentRow.Add(matchup);                    
                    }

                    tournament.Rounds.Add(currentRow);              
                }
            }

            return output;
        }

        public void UpdateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var p = new DynamicParameters();
                if (model.Winner != null)
                {
                    p.Add("@id", model.Id);
                    p.Add("@WinnerId", model.Winner.Id);

                    connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure); 
                }

                foreach (MatchupEntryModel me in model.Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        p = new DynamicParameters();
                        p.Add("@id", me.Id);
                        p.Add("@TeamCompetingId", me.TeamCompeting.Id);
                        p.Add("@Score", me.Score);

                        connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure); 
                    }
                }
            }
        }

        public void CompleteTournament(TournamentModel model)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                
                connection.Execute("dbo.spTournaments_Complete", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
