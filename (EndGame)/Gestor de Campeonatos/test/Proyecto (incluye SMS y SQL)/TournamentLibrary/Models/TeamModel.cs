using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The unique identifier for the team.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the team.
        /// </summary>
        public string TeamName { get; set; }
        
        /// <summary>
        /// The list of team members the team consists of.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();   
    }
}
