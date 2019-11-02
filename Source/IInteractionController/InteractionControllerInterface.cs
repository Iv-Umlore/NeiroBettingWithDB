using DataBaseConnect;
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

        bool SaveMatchResult(string[] matchParameters, DateTime date, bool isReadyForLearning);

        List<TeamInfo> GetTeamList();

        List<TournamentShort> GetTournamentList();

        List<LastMatch> GetlastFiveTeamMatch(string teamName);

        bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0);

        bool AddNewTournament(string TournamentName, int size);

        bool AddNewWaitResultMatch(string[] parameters, TournamentShort tournament, DateTime date);

        bool ChangeDiscipline(Discipline type);
    }
}
