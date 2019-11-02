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
        private List<TeamInfo> teams;
        private List<TournamentShort> tournaments;

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

        public bool SaveMatchResult(string[] matchParameters, DateTime date, bool isReadyForLearning)
        {
            var entities = _dalExecute.NewEntities;

            entities.PastMatches.Add(CreatepastMatchForParameters(matchParameters, date, isReadyForLearning));

            _dalExecute.CloseConnection(entities);
            return true;
        }

        public List<TeamInfo> GetTeamList()
        {
            var entities = _dalExecute.NewEntities;
            var res = new List<TeamInfo>();
            var team = entities.Comands.ToList();
            res = ToTeamInfoList(team);

            teams = res;

            _dalExecute.CloseConnection(entities);
            return res;
        }

        public List<LastMatch> GetlastFiveTeamMatch(string teamName)
        {
            var entities = _dalExecute.NewEntities;
            var res = new List<LastMatch>();
            var teamId = entities.Comands.Where(it => it.team_name == teamName).Select(it => it.id_team).FirstOrDefault();

            var pastMatchList = entities.PastMatches.Where(it => it.Team_A == teamId || it.Team_B == teamId)
                .OrderByDescending(it => it.match_date).Take(5).ToList();
            foreach (var match in pastMatchList)
                res.Add(ConvertToLastMatch(match));

            _dalExecute.CloseConnection(entities);
            return res;
        }

        private LastMatch ConvertToLastMatch(PastMatch match)
        {
            var entities = _dalExecute.NewEntities;
            var nameA = entities.Comands.First(it => it.id_team == match.Team_A).team_name;
            var nameB = entities.Comands.First(it => it.id_team == match.Team_B).team_name;

            return new LastMatch()
            {
                Team_A = match.Team_A,
                Team_B = match.Team_B,
                Name_A = nameA,
                Name_B = nameB,
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

            tournaments = TournamentInfoList;
            return TournamentInfoList;
        }

        public bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0)
        {
            var entities = _dalExecute.NewEntities;
            
            entities.Comands.Add(new Comand
            {
                abbrevitions = abbrevitions,
                team_name = teamName,
                tier_team = (short)tier_team,
                team_point = teamPoint
            });

            entities.DeleteSpace();

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

            entities.DeleteSpace();

            _dalExecute.CloseConnection(entities);
            return true;
        }

        public bool AddNewWaitResultMatch(string[] parameters, TournamentShort tournament, DateTime date)
        {
            var entities = _dalExecute.NewEntities;

            var idA = teams.First(it => it.Team_name == parameters[1]).Team_id;
            var idB = teams.First(it => it.Team_name == parameters[2]).Team_id;

            entities.WaitResults.Add(new WaitResult()
            {
                Team_A = idA,
                Team_B = idB,
                tournament = tournament.Tournament_id,
                replacements_A = int.Parse(parameters[5]),
                replacements_B = int.Parse(parameters[6]),
                important_A = int.Parse(parameters[3]),
                important_B = int.Parse(parameters[4]),
                date = date
            });

            entities.DeleteSpace();

            _dalExecute.CloseConnection(entities);
            return true;
        }

        public bool ChangeDiscipline(Discipline type)
        {
            // Заглушка
            return true;
        }

        private PastMatch CreatepastMatchForParameters(string[] parameters, DateTime date, bool isReadyForLerning)
        {
            var idA = teams.First(it => it.Team_name == parameters[1]).Team_id;
            var idB = teams.First(it => it.Team_name == parameters[2]).Team_id;
            var idTournament = tournaments.First(it => it.Tournament_name == parameters[0]).Tournament_id;

            return new PastMatch()
            {
                Team_A = idA,
                Team_B = idB,
                tournament = idTournament,
                replacements_A = short.Parse(parameters[3]),
                replacements_B = short.Parse(parameters[4]),
                Important_A = short.Parse(parameters[5]),
                Important_B = short.Parse(parameters[6]),
                Score_A = short.Parse(parameters[7]),
                Score_B = short.Parse(parameters[8]),
                shot_on_target_A = short.Parse(parameters[9]),
                shot_on_target_B = short.Parse(parameters[10]),
                save_A = short.Parse(parameters[11]),
                save_B = short.Parse(parameters[12]),
                Violations_A = short.Parse(parameters[13]),
                Violations_B = short.Parse(parameters[14]),
                match_date = date,
                is_ready_for_learning = isReadyForLerning
            };
        }
    }
}
