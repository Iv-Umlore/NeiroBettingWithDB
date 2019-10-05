using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnect
{
	public class DalExecute
	{
		public MatchResult_Entities NewEntities {
			get
			{
				var res = new MatchResult_Entities();
				res.Database.Connection.Open();
				return res;
			}
		}

		public void SaveChanges(MatchResult_Entities entities)
		{
			entities.SaveChanges();
		}

		public void CloseConnection(MatchResult_Entities entities)
		{
			entities.SaveChanges();
			entities.Database.Connection.Close();
		}

	}
}
