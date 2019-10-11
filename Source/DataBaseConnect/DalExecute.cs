using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnect
{
	public class DalExecute
	{
        
        public DalExecute()
        {
            var res = new MatchResult_Entities();
            res.Database.Connection.Open();
            res.Database.Connection.Close();
        }

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
