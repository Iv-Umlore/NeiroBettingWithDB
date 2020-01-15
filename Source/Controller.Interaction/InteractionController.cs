using System;
using System.Collections.Generic;
using Football.InteractionController;
using InteractionInterface;
using ProjectHelper;

namespace InteractionController
{
    public class InteractionController : IInteractionControllerInterface
    {
        private IInteractionControllerInterface _disciplineController;

        // Содержать в себе последние ответы
        // И выдавать их по требованию
        // Обнулять при смене типа сетки

        public InteractionController(Discipline type)
        {
            switch (type)
            {
                case Discipline.Football:
                    _disciplineController = new FootballIneractionController();
                    break;
                default: break;
            }
        }

        public List<MatchWaitResult> GetWaitResultMatches()
        {
            return _disciplineController.GetWaitResultMatches();
        }

        public bool SaveMatchResult(string[] matchParameters, DateTime date , bool isReadyForLearning)
        {
            return _disciplineController.SaveMatchResult(matchParameters, date, isReadyForLearning);
        }

        public List<TeamInfo> GetTeamList()
        {
            return _disciplineController.GetTeamList();
        }

        public List<TournamentShort> GetTournamentList()
        {
            return _disciplineController.GetTournamentList();
        }

        public List<LastMatch> GetlastFiveTeamMatch(string teamName)
        {
            return _disciplineController.GetlastFiveTeamMatch(teamName);
        }

        public bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0)
        {
            return _disciplineController.AddNewTeam(abbrevitions, teamName, tier_team, teamPoint);
        }

        public bool AddNewTournament(string TournamentName, int size)
        {
            return _disciplineController.AddNewTournament(TournamentName, size);
        }

        public bool AddNewWaitResultMatch(string[] parameters, TournamentShort tournament, DateTime date, string prediction)
        {
            return _disciplineController.AddNewWaitResultMatch(parameters, tournament, date, prediction);
        }

        public bool ChangeDiscipline(Discipline type)
        {
            switch (type)
            {
                case Discipline.Football:
                    _disciplineController = new FootballIneractionController();
                    break;
                default: break;
            }

            return true;
        }

        public Dictionary<LastMatch,List<LastMatch> > GetMatchForLearning()
        {
            return _disciplineController.GetMatchForLearning();
        }

        public void DeleteWaitResultMatch(int teamA, int teamB, DateTime date)
        {
            _disciplineController.DeleteWaitResultMatch(teamA, teamB, date);
        }
    }
}
