﻿using DataBaseConnect;
using ProjectHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInteractionController
{
    public interface InteractionControllerInterface
    {
        List<MatchWaitResult> GetWaitResultMatches();

        bool SaveMatchResult(string matchParameters);

        List<TeamInfo> GetTeamList();

        List<TournamentShort> GetTournamentList();

        List<LastMatch> GetlastFiveTeamMatch(string teamName);

        bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0);

        bool AddNewTournament(string TournamentName, int size);

        bool ChangeDiscipline(Discipline type);
    }
}
