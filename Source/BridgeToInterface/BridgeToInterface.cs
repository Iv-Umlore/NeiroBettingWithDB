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
        private INetworkInterface _network;
        private List<TeamInfo> teamList;
        private List<TournamentShort> tournamentList;
        public int MatchesCount;
        public double learningResult;

        public BridgeToInterfaceController()
        {
            _interactionController = new InteractionController.InteractionController(Discipline.Football);
            _network = new NetWorkController.NetworkController(Discipline.Football);
            teamList = _interactionController.GetTeamList();
            MatchesCount = 1000;
            learningResult = 1000.0;
        }

        public bool ChangeDiscipline(Discipline discipline)
        {
            _interactionController.ChangeDiscipline(discipline);
            _network.ChangeDiscipline(discipline);
            return true;
        }

        public List<MatchWaitResult> GetWaitResultMatches()
        {
            var result = _interactionController.GetWaitResultMatches();
            return result;
        }

        public bool SaveMatchResult(MatchWaitResult lastMatch, int scoreA, int scoreB,
            int ViolationsA, int ViolationsB, int shotOnTargetA, int shotOnTargetB, int SaveA, int SaveB, bool IsReadyForLerning)
        {
            return _interactionController.SaveMatchResult("parameters with 1");
        }

        public bool SaveLastMatchresult(string[] parameters)
        {
            _interactionController.SaveMatchResult("paremeters with 0");
            return true;
        }

        public List<string> GetTeamList(string withoutTeam_name = "")
        {
            teamList = _interactionController.GetTeamList();
            if (withoutTeam_name == "")
                return teamList.Select(it => it.Team_name).ToList();
            else return teamList.Where(it => it.Team_name != withoutTeam_name).Select(it => it.Team_name).ToList();
        }

        public List<string> GetTournamentList(string withoutTeam_name = "")
        {
            tournamentList = _interactionController.GetTournamentList();
            return tournamentList.Select(it => it.Tournament_name).ToList();
        }

        public bool AddNewTeam(string abbreviature, string TeamName, int tier_team, int teamPoint)
        {
            _interactionController.AddNewTeam(abbreviature, TeamName, tier_team);
            teamList = _interactionController.GetTeamList();
            return true;
        }

        public bool AddNewTournament(string TournamentName, int size)
        {
            _interactionController.AddNewTournament(TournamentName, size);
            return true;
        }

        public List<Prediction> GetPrediction(int teamA_id, int teamB_id)
        {
            var result = new List<Prediction>();
            //var teamAMatches = _interactionController.GetlastFiveTeamMatch(teamList.First(it => it.Team_id == teamA_id).Team_name);
            //var teamBMatches = _interactionController.GetlastFiveTeamMatch(teamList.First(it => it.Team_id == teamB_id).Team_name);

            //result = _network.GetPrediction(teamAMatches, teamBMatches);

            return result;
        }

        public double TestNetwork()
        {
            return _network.TestNetwork();
        }

        public double LearningNetwork()
        {
            for (int i = 0; i < 500; i++)
                learningResult = _network.Learning();
            return learningResult;
        }

        public bool SaveCurrentWeights()
        {
            _network.SaveCurrentWeights();
            return true;
        }

        public bool ReloadWeights()
        {
            _network.ReloadWeights();
            return true;
        }
    }
}
