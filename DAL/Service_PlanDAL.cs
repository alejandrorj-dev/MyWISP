/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 29/01/2020
 * Time: 14:49
 * 
 * 
 */
using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using EL;

namespace DAL
{
	/// <summary>
	/// This class it allows to manage the data in the table Service_Plan on database MyWISPSI.
	/// </summary>
	public static class Service_PlanDAL
	{
		
		
		public static int AddService_Plan(Service_Plan pService_Plan)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Service_Plan(idService_Plan, Name_Plan, Price_Plan_CO, Description_service) values('{0}', '{1}', {2}, '{3}')",
			pService_Plan.Id, pService_Plan.Name_Plan, pService_Plan.Price_Plan, pService_Plan.Description), MyConnection);
			
				try
				{
					resultQuery = MyCommand.ExecuteNonQuery();
				}
				catch(MySqlException)
				{
					resultQuery = 0;
				}			
			
			
			return resultQuery;			
			
		}
		
		public static List<Service_Plan> GetAllServices()
		{
			List<Service_Plan> MyList = new List<Service_Plan>();
						
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand("select * from Service_Plan", MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Service_Plan pService_Plan = new Service_Plan();
				pService_Plan.Id = reader.GetString(0);
				pService_Plan.Name_Plan = reader.GetString(1);
				pService_Plan.Price_Plan = reader.GetDouble(2);
				pService_Plan.Description = reader.GetString(3);
				
				MyList.Add(pService_Plan);
			}
			
			
			return MyList;				
			
		}
		
		public static int EditServicePlan(Service_Plan pService, String id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("update Service_Plan set idService_Plan = '{0}', Name_Plan = '{1}', Price_Plan_CO = {2}, Description_service = '{3}' where idService_Plan = '{4}'",
			pService.Id, pService.Name_Plan, pService.Price_Plan, pService.Description, id), MyConnection);
			
				try
				{
					resultQuery = MyCommand.ExecuteNonQuery();
				}
				catch(MySqlException)
				{
					resultQuery = 0;
				}		
			
			
			return resultQuery;
		}
		
		public static int DeleteServicePlan(String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("delete from Service_Plan where idService_Plan = '{0}'", Id), MyConnection);
			
				try
				{
					resultQuery = MyCommand.ExecuteNonQuery();
				}
				catch(MySqlException)
				{
					resultQuery = 0;
				}			
			
			
			return resultQuery;
		}
		
		public static List<Service_Plan> SearchServicePlan(String ParamForSearch)
		{
			
			List<Service_Plan> ListServicesFound = new List<Service_Plan>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Service_Plan where idService_Plan like '%{0}%' or Name_Plan like '%{0}%' or Description_service like '%{0}%'", ParamForSearch), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Service_Plan pService_Plan = new Service_Plan();
				pService_Plan.Id = reader.GetString(0);
				pService_Plan.Name_Plan = reader.GetString(1);
				pService_Plan.Price_Plan = reader.GetDouble(2);
				pService_Plan.Description = reader.GetString(3);
				
				ListServicesFound.Add(pService_Plan);
			}
			
			return ListServicesFound;
		}
		
		
		
		public static Service_Plan GetServiceById(String pId)
		{
			Service_Plan pService_Plan = new Service_Plan();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Service_Plan where idService_Plan = '{0}'", pId), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				pService_Plan.Id = reader.GetString(0);
				pService_Plan.Name_Plan = reader.GetString(1);
				pService_Plan.Price_Plan = reader.GetDouble(2);
				pService_Plan.Description = reader.GetString(3);
				
			}
			
			return pService_Plan;
		}
		
		public static int validateReferenceServiceExistence(String pId)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Service_Plan where idService_Plan = '{0}'", pId), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				resultQuery = 50;
			}
			
			return resultQuery;
			
		}
	}
}
