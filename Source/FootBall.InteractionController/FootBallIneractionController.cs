﻿using DataBaseConnect;
using IInteractionController;
using ProjectHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionController.Football
{
    public class FootballIneractionController : InteractionControllerInterface
    {
        private DalExecute _dalExecute;

        public FootballIneractionController()
        {
            _dalExecute = new DalExecute();
        }

        public List<MatchWaitResult> GetWaitResultMatches()
        {
            var res = new List<MatchWaitResult>();
            var entities = _dalExecute.NewEntities;
            // entities.WaitResults
            // Достать все матчи из таблицы WaitResult
            // Преобразовать их к MatchWaitResult
            // !!!! НЕ ЗАБЫТЬ ПРО ДОП. ПАРАМЕТР ПРЕДИКШН !!!!
            return res;
        }

        public bool SaveMatchResult(string matchParameters)
        {
            // Разработать систему сохранения. И колличество параметров.
            return true;
        }

        public List<TeamInfo> GetTeamList()
        {
            var res = new List<TeamInfo>();
            // Взять из Comands все команды
            // var result = entities.Comands.ToList();
            // Преобразовать и вернуть
            return res;
        }

        public List<LastMatch> GetlastFiveTeamMatch(string teamName)
        {
            var res = new List<LastMatch>();
            // Достать 5 последних матчей для команды.
            // Преобразовать и вернуть

            /*foreach (var match in pastMatchList)
                lastMatchesList.Add(ConvertToLastMatch(match));*/

            return res;
        }

        public bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0)
        {
            // добавить новую команду
            // entities.Comands.Add( new Comands{ } );
            // _dalExecute.CloseConnection(entities);
            return true;
        }

        public bool ChangeDiscipline(Discipline type)
        {
            // Заглушка
            return true;
        }
    }
}
