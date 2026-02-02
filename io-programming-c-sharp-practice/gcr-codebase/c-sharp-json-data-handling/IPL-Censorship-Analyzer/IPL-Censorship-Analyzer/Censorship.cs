using System;

namespace IPLCensorship
{
    public static class Censor
    {
        // Mask part of the team name
        public static string MaskTeamName(string teamName)
        {
            string[] words = teamName.Split(' ');

            // Mask middle words if more than 1 word
            if (words.Length > 2)
            {
                words[1] = "***"; // mask the second word
            }
            else if (words.Length == 2)
            {
                words[1] = "***";
            }
            return string.Join(" ", words);
        }

        // Redact player name
        public static string RedactPlayer(string player)
        {
            return "REDACTED";
        }
    }
}
