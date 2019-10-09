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

        public Tournament Tournament { get; set; }

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

    public class Tournament
    {
        public int Tournament_id { get; set; }

        public string Tournament_name { get; set; }
    }

    public class Prediction
    {
        public string Predict { get; set; }
        public string Risk { get; set; }
    }

}
