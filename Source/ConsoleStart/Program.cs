using DataBaseConnect;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleStart
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> array = new List<int>();
			
			try
			{
				var _dalExecute = new DalExecute();
				var db_entities = _dalExecute.NewEntities;

				var node = new Comand()
				{
					abbrevitions = "EVT",
					team_name = "Эвертон",
					tier_team = 5
				};
								
				_dalExecute.CloseConnection(db_entities);
			}

			catch (Exception e)
			{				
				Console.WriteLine("Ошибка:\n" + e.Message);
			}
		}
	}
}
