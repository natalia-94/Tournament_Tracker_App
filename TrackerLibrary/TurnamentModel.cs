using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TurnamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> Teams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>
    }
}
