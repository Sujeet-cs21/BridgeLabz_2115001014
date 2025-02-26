using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper.Configuration;
using CsvHelper;
using Newtonsoft.Json;

namespace PP_26_02_25_json
{
    public class Match
    {
        public int match_id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public Dictionary<string, int> score { get; set; }
        public string winner { get; set; }
        public string player_of_match { get; set; }
    }

    class IPLCensorshipAnalyzer
    {
        public static void Main14()
        {
            string jsonFilePath = "..\\..\\ipl_data.json";
            string csvFilePath = "..\\..\\ipl_data.csv";

            try
            {
                // Process JSON data
                string jsonData = File.ReadAllText(jsonFilePath);
                var jsonMatches = JsonConvert.DeserializeObject<List<Match>>(jsonData);
                ApplyCensorshipToJson(jsonMatches);
                string censoredJson = JsonConvert.SerializeObject(jsonMatches, Formatting.Indented);
                File.WriteAllText("..\\..\\censored_ipl_data.json", censoredJson);

                // Process CSV data
                using (var reader = new StreamReader(csvFilePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    var csvMatches = csv.GetRecords<Match>();
                    ApplyCensorshipToCsv(csvMatches);
                    using (var writer = new StreamWriter("..\\..\\censored_ipl_data.csv"))
                    using (var csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        csvWriter.WriteRecords(csvMatches);
                    }
                }

                Console.WriteLine("Censorship applied and files saved.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ApplyCensorshipToJson(List<Match> matches)
        {
            foreach (var match in matches)
            {
                //censorship to team names
                match.team1 = MaskTeamName(match.team1);
                match.team2 = MaskTeamName(match.team2);

                //censorship to player of the match
                match.player_of_match = "REDACTED";
            }
        }

        static void ApplyCensorshipToCsv(IEnumerable<Match> matches)
        {
            foreach (var match in matches)
            {
                //censorship to team names
                match.team1 = MaskTeamName(match.team1);
                match.team2 = MaskTeamName(match.team2);

                //censorship to player of the match
                match.player_of_match = "REDACTED";
            }
        }

        static string MaskTeamName(string teamName)
        {
            if (teamName.Contains("Mumbai"))
                return "Mumbai ***";
            if (teamName.Contains("Chennai"))
                return "Chennai ***";
            if (teamName.Contains("Royal"))
                return "Royal *** Bangalore";
            if (teamName.Contains("Delhi"))
                return "Delhi ***";

            return teamName;
        }
    }

}
