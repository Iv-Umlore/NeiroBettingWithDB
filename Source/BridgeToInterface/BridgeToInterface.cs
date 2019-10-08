using FootBall.InteractionController;
using FootBall.Network;
using IInteractionController;
using INetwork;
using ProjectHelper;
using System.Collections.Generic;
using System.Linq;

namespace BridgeToInterface
{
    public class BridgeToInterfaceController
    {
        private InteractionControllerInterface _interactionController;
        private NetworkInterface _network;
        private List<TeamInfo> teamList;
        public int MatchesCount;

        public BridgeToInterfaceController()
        {
            _interactionController = new FootBallIneractionController();
            _network = new FootBallNetwork();
            teamList = _interactionController.GetTeamList();
            MatchesCount = 1000;
        }

        public bool ChangeDiscipline(Discipline discipline)
        {
            return true;
        }

        public List<MatchWaitResult> GetWaitResultMatches()
        {
            var result = new List<MatchWaitResult>();
            // Changes
            return result;
        }

        public bool SaveMatchResult(MatchWaitResult lastMatch, int scoreA, int scoreB,
            int ViolationsA, int ViolationsB, int shotOnTargetA, int shotOnTargetB, int SaveA, int SaveB, bool IsReadyForLerning)
        {
            return true;
        }

        public bool SaveLastMatchresult(string[] parameters)
        {
            return true;
        }

        public List<string> GetTeamList(string withoutTeam_name = "")
        {
            if (teamList == null)
                teamList = _interactionController.GetTeamList();
            if (withoutTeam_name == "")
                return teamList.Select(it => it.Team_name).ToList();
            else return teamList.Where(it => it.Team_name != withoutTeam_name).Select(it => it.Team_name).ToList();
        }

        public bool AddNewTeam(string abbreviature, string TeamName, int tier_team, int teamPoint)
        {
            return true;
        }

        public List<Prediction> GetPrediction(int teamA_id, int teamB_id)
        {
            var result = new List<Prediction>();
            // Changes
            return result;
        }

        public double TestNetwork()
        {
            return 0.0;
        }

        public double LearningNetwork()
        {
            return 0.0;
        }

        public bool SaveCurrentWeights()
        {
            return true;
        }

        public bool ReloadWeights()
        {
            return true;
        }
    }
}
