/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/5/2020
 * Time: 5:33 PM
 * 
 * 
 */
using System;
using System.Collections.Generic;
using EL;
using MySql.Data.MySqlClient;


namespace DAL
{
	/// <summary>
	/// This class it allows to manage the data in the table Instalation on database MyWISPSI.
	/// </summary>
	public static class InstalationDAL
	{
		public static int AddInstalation(Instalation pInstalation)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Instalation (Date_instalation, Materials, Place_instalation, Customer_idCustomer, Service_Plan_idService_Plan) values('{0}', '{1}', '{2}', '{3}', '{4}')",
			 pInstalation.Date, pInstalation.Materials, pInstalation.Place, pInstalation.IdCustomer, pInstalation.idService), MyConnection);
			
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
		
		public static List<Instalation> GetInstalations(String idCustomer)
		{
			List<Instalation> MyList = new List<Instalation>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Instalation where Customer_idCustomer = '{0}'", idCustomer), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Instalation pInstalation = new Instalation();
				pInstalation.Id = reader.GetInt32(0);
				pInstalation.Date = Convert.ToString(reader.GetDateTime(1));
				pInstalation.Materials = reader.GetString(2);
				pInstalation.Place = reader.GetString(3);
				pInstalation.IdCustomer = reader.GetString(4);
				pInstalation.idService = reader.GetString(5);
				
				MyList.Add(pInstalation);
			}
			
			return MyList;
		
		}
		
		
		public static int EditInstalation(Instalation eInstalation)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("update Instalation set Date_instalation = '{0}', Materials = '{1}', Place_instalation = '{2}', Service_Plan_idService_plan = '{3}' where IdInstalation = {4}",
			 eInstalation.Date, eInstalation.Materials, eInstalation.Place, eInstalation.idService, eInstalation.Id), MyConnection);
			
			
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
		
		public static int DeleteInstalation(int Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("delete from Customer_device where Instalation_idInstalation = {0}; delete from Instalation where idInstalation = {0};", Id), MyConnection);
			
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
		
		
	}
}
