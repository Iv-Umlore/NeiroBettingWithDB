using FootBall.Network;
using IInteractionController;
using INetwork;
using ProjectHelper;
using System;
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
        private List<LastMatch> lastMatchesA;
        private List<LastMatch> lastMatchesB;
        public int MatchesCount;
        public double learningResult;

        public BridgeToInterfaceController()
        {
            _interactionController = new InteractionController.InteractionController(Discipline.Football);
            _network = new NetWorkController.NetworkController(Discipline.Football);
            teamList = _interactionController.GetTeamList();
            MatchesCount = 1000;
            learningResult = 1000.0;

            lastMatchesA = new List<LastMatch>();
            lastMatchesB = new List<LastMatch>();

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
        
        public bool SaveLastMatchResult(bool ReadyForLearning, DateTime dateTime, string[] parameters)
        {
            _interactionController.SaveMatchResult(parameters, dateTime, ReadyForLearning);
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

        public List<LastMatch> GetLastFiveMatch(bool isItA, string TeamName)
        {
            if (isItA)
                return lastMatchesA = _interactionController.GetlastFiveTeamMatch(TeamName);
            else
                return lastMatchesB = _interactionController.GetlastFiveTeamMatch(TeamName);
        }

        //public bool AddNewMatch(string )

        public List<Prediction> GetPrediction(string[] parameters, DateTime date)
        {
            var result = new List<Prediction>();
            var tournament = tournamentList.First(it => it.Tournament_name == parameters[0]);
            
            //result = _network.GetPrediction(lastMatchesA, lastMatchesB,tournament, parameters);

            _interactionController.AddNewWaitResultMatch(parameters, tournament, date); // + запись Prediction

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
