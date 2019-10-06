using DataBaseConnect;
using IInteractionController;
using ProjectHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall.InteractionController
{
    public class FootBallIneractionController : InteractionControllerInterface
    {
		public List<MatchWaitResult> GetWaitResultMatches()
		{
			var res = new List<MatchWaitResult>();
			return res;
		}

		public bool SaveMatchResult(string matchParameters)
		{
			return true;
		}

		public List<TeamInfo> GetTeamList(string withoutTeam = null)
		{
			var res = new List<TeamInfo>();
			return res;
		}

		public List<PastMatch> GetlastFiveTeamMatch(string teamName)
		{
			var res = new List<PastMatch>();
			return res;
		}

		public bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0)
		{
			return true;
		}
	}
}
