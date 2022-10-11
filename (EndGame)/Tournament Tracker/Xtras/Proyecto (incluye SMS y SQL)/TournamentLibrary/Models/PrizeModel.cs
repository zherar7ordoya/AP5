using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary.Models
{
    /// <summary>
    /// Represents what the prize is for the given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The numeric identifier for the place (1 for first place for example)
        /// </summary>
        public int PlaceNumber { get; set; }
        
        /// <summary>
        /// Textual name for the place ("first place" for example)
        /// </summary>
        public string PlaceName { get; set; }
        
        /// <summary>
        /// The fixed amount this place earns, or zero if it is not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        
        /// <summary>
        /// The number that represents the percentage of the overall take,
        /// or zero if it is not used. 
        /// The percentage is a fraction of 1 (so 0.5 for 50%).
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, int placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            PlaceNumber = placeNumber;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
