using DataBaseConnect;
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

            var matchResultList = entities.WaitResults.ToList();

            res = GetMatchWaitResults(matchResultList);
            
            _dalExecute.CloseConnection(entities);
            return res;
        }

        public bool SaveMatchResult(string matchParameters)
        {
            // Разработать систему сохранения. И колличество параметров.
            return true;
        }

        public List<TeamInfo> GetTeamList()
        {
            var entities = _dalExecute.NewEntities;
            var res = new List<TeamInfo>();
            var team = entities.Comands.ToList();
            res = ToTeamInfoList(team);

            _dalExecute.CloseConnection(entities);
            return res;
        }

        public List<LastMatch> GetlastFiveTeamMatch(string teamName)
        {
            var entities = _dalExecute.NewEntities;
            var res = new List<LastMatch>();
            var teamId = entities.Comands.Where(it => it.team_name == teamName).Select(it => it.id_team).FirstOrDefault();
            
            var pastMatchList = entities.PastMatches.Where(it=>it.Team_A == teamId || it.Team_B == teamId)
                .OrderByDescending(it => it.match_date).Take(5).ToList();
            foreach (var match in pastMatchList)
                res.Add(ConvertToLastMatch(match));

            _dalExecute.CloseConnection(entities);
            return res;
        }

        private LastMatch ConvertToLastMatch(PastMatch match)
        {
            return new LastMatch()
            {
                Team_A = match.Team_A,
                Team_B = match.Team_B,
                Score_A = match.Score_A,
                Score_B = match.Score_B,
                Important_A = match.Important_A,
                Important_B = match.Important_B,
                Violations_A = match.Violations_A,
                Violations_B = match.Violations_B,
                shot_on_target_A = match.shot_on_target_A,
                shot_on_target_B = match.shot_on_target_B,
                save_A = match.save_A,
                save_B = match.save_B,
                tournament = match.tournament,
                tier_tournament = match.Tournament1.Tournament_size,
                replacements_A = match.replacements_A,
                replacements_B = match.replacements_B,
                match_date = match.match_date
            };
        }

        private List<MatchWaitResult> GetMatchWaitResults(List<WaitResult> matchWaitResultList)
        {
            var entities = _dalExecute.NewEntities;
            var resList = new List<MatchWaitResult>();
            foreach (var matchWaitResult in matchWaitResultList)
            {
                var teamA = new TeamInfo()
                {
                    Team_id = decimal.ToInt32(matchWaitResult.Team_A),
                    Team_name = entities.Comands.Where(it => it.id_team == matchWaitResult.Team_A).Select(it => it.team_name).First()
                };

                var teamB = new TeamInfo()
                {
                    Team_id = decimal.ToInt32(matchWaitResult.Team_B),
                    Team_name = entities.Comands.Where(it => it.id_team == matchWaitResult.Team_B).Select(it => it.team_name).First()
                };

                var tournament = new TournamentShort()
                {
                    Tournament_id = decimal.ToInt32(matchWaitResult.tournament),
                    Tournament_name = matchWaitResult.Tournament1.Tournament_name
                };

                resList.Add(
                new MatchWaitResult()
                {
                    TeamA = teamA,
                    TeamB = teamB,
                    Tournament = tournament,
                    ReplasmentA = (short)matchWaitResult.replacements_A,
                    RepalsmentB = (short)matchWaitResult.replacements_B,
                    ImportantA = (short)matchWaitResult.important_A,
                    ImportantB = (short)matchWaitResult.important_B,
                    Prediction = matchWaitResult.prediction
                });
            }
            return resList;
        }

        private List<TeamInfo> ToTeamInfoList(List<Comand> comands)
        {
            var res = new List<TeamInfo>();
            foreach (var comand in comands)
                res.Add(new TeamInfo()
                {
                    Team_id = decimal.ToInt32(comand.id_team),
                    Team_name = comand.team_name
                });
            return res;
        }

        public List<TournamentShort> GetTournamentList()
        {
            var entities = _dalExecute.NewEntities;
            var tournamentList = entities.Tournaments.ToList();
            var TournamentInfoList = new List<TournamentShort>();
            foreach (var tournament in tournamentList)
                TournamentInfoList.Add(new TournamentShort()
                {
                    Tournament_name = tournament.Tournament_name,
                    Tournament_id = (int)tournament.id_Tournament
                });
            return TournamentInfoList;
        }

        public bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0)
        {
            var entities = _dalExecute.NewEntities;
            // добавить новую команду
            entities.Comands.Add( new Comand{
                abbrevitions = abbrevitions,
                team_name = teamName,
                tier_team = (short)tier_team,
                team_point = teamPoint
            });

            _dalExecute.CloseConnection(entities);
            return true;
        }

        public bool AddNewTournament(string TournamentName, int size)
        {
            var entities = _dalExecute.NewEntities;
            entities.Tournaments.Add(new Tournament()
            {
                Tournament_name = TournamentName,
                Tournament_size = (short)size
            });
            _dalExecute.CloseConnection(entities);
            return true;
        }

        public bool ChangeDiscipline(Discipline type)
        {
            // Заглушка
            return true;
        }
    }
}
