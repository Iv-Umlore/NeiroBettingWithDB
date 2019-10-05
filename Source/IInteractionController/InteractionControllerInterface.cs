using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInteractionController
{
	public interface InteractionControllerInterface
	{
		List<string> GetWaitResultMatches();

		bool SaveMatchResult(string matchParameters);

		List<string> GetTeamList(string withoutTeam = null);

		int? GetlastFiveTeamMatch(string teamName);

		bool AddNewTeam(string abbrevitions, string teamName, int tier_team, int teamPoint = 0);
	}
}
