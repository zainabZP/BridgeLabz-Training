using System;
using System.Collections.Generic;

namespace IPLCensorship
{
    // Model for IPL match score
    public class Score
    {
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
    }

    // Model for IPL match
    public class IPLMatch
    {
        public int match_id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public Dictionary<string, int> score { get; set; }
        public string winner { get; set; }
        public string player_of_match { get; set; }
    }
}
