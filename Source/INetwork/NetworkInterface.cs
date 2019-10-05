using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INetwork
{
	public interface NetworkInterface
	{
		string GetPrediction();

		double TestNetwork();

		double Learning();

		void SaveCurrentWeights();

		void ReloadWeights();
	}
}
