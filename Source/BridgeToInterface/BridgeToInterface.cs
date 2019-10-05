using IInteractionController;
using INetwork;
using System.Collections.Generic;

namespace BridgeToInterface
{
	public class BridgeToInterface
    {
		private InteractionControllerInterface _interactionController;
		private NetworkInterface _network;

		public BridgeToInterface()
		{
			//_interactionController = new InteractionControllerInterface()
			//_network = new INetwork()
		}

		public List<MatchWaitResult> GetWaitResultMatches()
		{
			var result = new List<MatchWaitResult>();
			// Changes
			return result;
		}

		public bool SaveMatchResult (MatchWaitResult lastMatch, int scoreA, int scoreB,
			int ViolationsA, int ViolationsB, int shotOnTargetA, int shotOnTargetB, int SaveA, int SaveB, bool IsReadyForLerning)
		{
			return true;
		}

		public List<TeamInfo> GetTeamList(int withoutTeam_id)
		{
			var result = new List<TeamInfo>();
			// Changes
			return result;
		}

		public bool AddNewTeam(string abbreviature, string TeamName, int tier_team, int teamPoint)
		{
			return true;
		}

		public List<Prediction> GetPrediction(int teamA_id, int teamB_id)
		{
			var result = new List<Prediction>();
			// Changes
			return result;
		}

		public double TestNetwork()
		{
			return 0.0;
		}

		public double LearningNetwork()
		{
			return 0.0;
		}

		public bool SaveCurrentWeights()
		{
			return true;
		}

		public bool ReloadWeights()
		{
			return true;
		}
    }
}
