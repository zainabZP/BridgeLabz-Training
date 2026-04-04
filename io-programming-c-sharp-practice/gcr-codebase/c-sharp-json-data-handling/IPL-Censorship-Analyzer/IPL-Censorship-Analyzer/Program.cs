using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json; // Install Newtonsoft.Json
using IPLCensorship;

class Program
{
    static void Main()
    {
        Console.WriteLine("IPL Censorship Analyzer");

        string jsonData = File.ReadAllText("ipl_matches.json");
        List<IPLMatch> matches = JsonConvert.DeserializeObject<List<IPLMatch>>(jsonData);

        foreach (var match in matches)
        {
            // Mask team names
            string oldTeam1 = match.team1;
            string oldTeam2 = match.team2;

            match.team1 = Censor.MaskTeamName(match.team1);
            match.team2 = Censor.MaskTeamName(match.team2);

            // Update scores keys
            int score1 = match.score[oldTeam1];
            int score2 = match.score[oldTeam2];
            match.score.Clear();
            match.score[match.team1] = score1;
            match.score[match.team2] = score2;

            // Mask winner
            match.winner = Censor.MaskTeamName(match.winner);

            // Redact player of match
            match.player_of_match = Censor.RedactPlayer(match.player_of_match);
        }

        string censoredJson = JsonConvert.SerializeObject(matches, Formatting.Indented);
        File.WriteAllText("ipl_matches_censored.json", censoredJson);
        Console.WriteLine("Censored JSON saved: ipl_matches_censored.json");

        using (StreamWriter sw = new StreamWriter("ipl_matches_censored.csv"))
        {
            sw.WriteLine("match_id,team1,team2,score_team1,score_team2,winner,player_of_match");
            foreach (var match in matches)
            {
                int score1 = 0, score2 = 0;
                foreach (var kv in match.score)
                {
                    if (kv.Key == match.team1) score1 = kv.Value;
                    if (kv.Key == match.team2) score2 = kv.Value;
                }
                sw.WriteLine($"{match.match_id},{match.team1},{match.team2},{score1},{score2},{match.winner},{match.player_of_match}");
            }
        }
        Console.WriteLine("Censored CSV saved: ipl_matches_censored.csv");
    }
}
