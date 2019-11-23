using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHelper
{    

    public class MatchWaitResult
    {
        public TeamInfo TeamA { get; set; }

        public TeamInfo TeamB { get; set; }

        public TournamentShort Tournament { get; set; }

        public short ReplasmentA { get; set; }

        public short ReplasmentB { get; set; }

        public short ImportantA { get; set; }

        public short ImportantB { get; set; }

        public string Prediction { get; set; }

        public DateTime date { get; set; }
    }

    public class TeamInfo
    {
        public int Team_id { get; set; }

        public string Team_name { get; set; }
    }

    public class TournamentShort
    {
        public int Tournament_id { get; set; }

        public string Tournament_name { get; set; }
    }
    
    public class LastMatch
    {
        public decimal Team_A { get; set; }
        public string Name_A { get; set; }
        public int tier_A { get; set; }
        public decimal Team_B { get; set; }
        public string Name_B { get; set; }
        public int tier_B { get; set; }
        public short Score_A { get; set; }
        public short Score_B { get; set; }
        public short Important_A { get; set; }
        public short Important_B { get; set; }
        public short Violations_A { get; set; }
        public short Violations_B { get; set; }
        public short shot_on_target_A { get; set; }
        public short shot_on_target_B { get; set; }
        public short save_A { get; set; }
        public short save_B { get; set; }
        public decimal tournament { get; set; }
        public int tier_tournament { get; set; }
        public bool is_ready_for_learning { get; set; }
        public short replacements_A { get; set; }
        public short replacements_B { get; set; }
        public DateTime match_date { get; set; }
        public bool IsA { get; set; }

        /// <summary>
        /// Score, Violations, ShotOnT,Save, TierCommand,important,replcement,tier_tournament
        /// </summary> 
        public List<double> ToListDouble()
        {
            var result = new List<double>();
            if (IsA)
                result.AddRange(new List<double>()
                {
                    Score_A, Score_B,
                    Violations_A, Violations_B,
                    shot_on_target_A, shot_on_target_B,
                    save_A, save_B,
                    tier_A, tier_B,
                    Important_A, Important_B,
                    replacements_A, replacements_B,
                    tier_tournament });
            else
                result.AddRange(new List<double>()
                {
                    Score_B, Score_A,
                    Violations_B, Violations_A,
                    shot_on_target_B, shot_on_target_A,
                    save_B, save_A,
                    tier_B, tier_A,
                    Important_B, Important_A,
                    replacements_B, replacements_A,
                    tier_tournament
                });


            return result;
        }

    }

}
