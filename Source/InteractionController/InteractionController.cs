using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseConnect;
using IInteractionController;
using InteractionController.Football;
using ProjectHelper;

namespace InteractionController
{
    public class InteractionController : InteractionControllerInterface
    {
        private InteractionControllerInterface _disciplineController;

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

        public bool SaveMatchResult(string matchParameters)
        {

            return _disciplineController.SaveMatchResult(matchParameters);
        }

        public List<TeamInfo> GetTeamList()
        {
            return _disciplineController.GetTeamList();
        }

        public List<LastMatch> GetlastFiveTeamMatch(string teamName)
        {
            return _disciplineController.GetlastFiveTeamMatch(teamName);
        }

        public bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0)
        {
            return _disciplineController.AddNewTeam(abbrevitions, teamName, tier_team, teamPoint);
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

        private LastMatch ConvertToLastMatch(PastMatch pastMatch)
        {
            return new LastMatch();
        }

    }
}
