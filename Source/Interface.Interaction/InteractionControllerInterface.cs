using ProjectHelper;
using System;
using System.Collections.Generic;

namespace InteractionInterface
{
    public interface IInteractionControllerInterface
    {
        List<MatchWaitResult> GetWaitResultMatches();

        bool SaveMatchResult(string[] matchParameters, DateTime date, bool isReadyForLearning);

        List<TeamInfo> GetTeamList();

        List<TournamentShort> GetTournamentList();

        List<LastMatch> GetlastFiveTeamMatch(string teamName);

        bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0);

        bool AddNewTournament(string TournamentName, int size);

        bool AddNewWaitResultMatch(string[] parameters, TournamentShort tournament, DateTime date, string prediction);

        bool ChangeDiscipline(Discipline type);

        Dictionary<LastMatch, List<LastMatch>> GetMatchForLearning();

        void DeleteWaitResultMatch(int teamA, int teamB, DateTime date);
    }
}
