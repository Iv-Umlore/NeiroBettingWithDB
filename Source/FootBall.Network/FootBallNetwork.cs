using INetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall.Network
{
    public class FootBallNetwork : NetworkInterface
    {
		private string pathToWeights;
		private string pathToWeightHistory;

		public FootBallNetwork()
		{
			pathToWeights = "../Weights/Current/FootBall/";     // Вынести в конфиг, или в константы хелпера
			pathToWeightHistory = "../Weights/History/FootBall/";     // Вынести в конфиг, или в константы хелпера
		}

		public string GetPrediction()
		{
			return "aa";
		}

		public double TestNetwork()
		{
			return 0.0;
		}

		public double Learning()
		{
			return 0.0;
		}

		public void SaveCurrentWeights() { }

		public void ReloadWeights() { }
	}
}
