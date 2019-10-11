using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHelper
{

    public enum Discipline
    {
        Football,
        CS_GO,
        Rocket_League
    };

    public class MatchWaitResult
    {
        public TeamInfo TeamA { get; set; }

        public TeamInfo TeamB { get; set; }

        public TournamentShort Tournament { get; set; }

        public short ReplasmentA { get; set; }

        public short RepalsmentB { get; set; }

        public short ImportantA { get; set; }

        public short ImportantB { get; set; }

        public string Prediction { get; set; }
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

    public class Prediction
    {
        public string Predict { get; set; }
        public string Risk { get; set; }
    }

    public class LastMatch
    {
        public decimal Team_A { get; set; }
        public int tier_A { get; set; }
        public decimal Team_B { get; set; }
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
    }

}
