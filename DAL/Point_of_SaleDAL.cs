/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/26/2020
 * Time: 4:31 PM
 * 
 * 
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using EL;

namespace DAL
{
	/// <summary>
	/// This class it allows to manage the data in the table Point_of_Sale on database MyWISPSI.
	/// </summary>
	public static class Point_of_SaleDAL
	{
		public static int AddPointOfSale(Point_of_Sale NewPointOfSale)
		{			
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Point_of_Sale(Name_Point, Department, Municipality, Address, Name_Owner, Phone, E_mail, Amount_codes, Prefix_code) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", 
			 NewPointOfSale.NamePoint, NewPointOfSale.Department, NewPointOfSale.Municipality, NewPointOfSale.Address, NewPointOfSale.NameOwner, NewPointOfSale.Phone, NewPointOfSale.E_mail, NewPointOfSale.AmountCodes, NewPointOfSale.PrefixCode), MyConnection);
			
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
		
		public static int EditPointOfSale(Point_of_Sale PointOfSaleForEdit, int Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("update Point_of_Sale set Name_Point = '{0}', Department = '{1}', Municipality = '{2}', Address = '{3}', Name_Owner = '{4}', Phone = '{5}', E_mail = '{6}', Amount_codes = '{7}', Prefix_code = '{8}' where idPoint_of_Sale = {9}", 
			 PointOfSaleForEdit.NamePoint, PointOfSaleForEdit.Department, PointOfSaleForEdit.Municipality, PointOfSaleForEdit.Address, PointOfSaleForEdit.NameOwner, PointOfSaleForEdit.Phone, PointOfSaleForEdit.E_mail, PointOfSaleForEdit.AmountCodes, PointOfSaleForEdit.PrefixCode, Id), MyConnection);
			
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
		
		
		public static List<Point_of_Sale> GetAllPointsOfSale()
		{
			List<Point_of_Sale> ListPointsOfSale = new List<Point_of_Sale>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand("select * from Point_of_Sale", MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Point_of_Sale PointOfSale = new Point_of_Sale();
				PointOfSale.IdPointOfSale = Convert.ToInt32(reader.GetString(0));
				PointOfSale.NamePoint = reader.GetString(1);
				PointOfSale.Department = reader.GetString(2);
				PointOfSale.Municipality = reader.GetString(3);
				PointOfSale.Address = reader.GetString(4);
				PointOfSale.NameOwner = reader.GetString(5);
				PointOfSale.Phone = reader.GetString(6);
				PointOfSale.E_mail = reader.GetString(7);
				PointOfSale.AmountCodes = reader.GetString(8);
				PointOfSale.PrefixCode = reader.GetString(9);
				
				ListPointsOfSale.Add(PointOfSale);
			}
			
			return ListPointsOfSale;
		}
		
		public static Point_of_Sale GetPointOfSale(int Id)
		{
			Point_of_Sale PointOfSaleReceived = new Point_of_Sale();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Point_of_Sale where idPoint_of_Sale = {0}", Id), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				PointOfSaleReceived.IdPointOfSale = reader.GetInt32(0);
				PointOfSaleReceived.NamePoint = reader.GetString(1);
				PointOfSaleReceived.Department = reader.GetString(2);
				PointOfSaleReceived.Municipality = reader.GetString(3);
				PointOfSaleReceived.Address = reader.GetString(4);
				PointOfSaleReceived.NameOwner = reader.GetString(5);
				PointOfSaleReceived.Phone = reader.GetString(6);
				PointOfSaleReceived.E_mail = reader.GetString(7);
				PointOfSaleReceived.AmountCodes = reader.GetString(8);
				PointOfSaleReceived.PrefixCode = reader.GetString(9);
			}
			
			return PointOfSaleReceived;
		}
		
		public static List<Point_of_Sale> SearchPointOfSale(String Data)
		{
			List<Point_of_Sale> ListPointOfSaleFound = new List<Point_of_Sale>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Point_of_Sale where Name_Point like '%{0}%' or Department like '%{0}%' or Municipality like '%{0}%' or Address like '%{0}%' or Name_Owner like '%{0}%' or Phone like '%{0}%' or E_mail like '%{0}%' or Amount_codes like '%{0}%' or Prefix_code like '%{0}%'", Data), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Point_of_Sale PointOfSaleFound = new Point_of_Sale();
				PointOfSaleFound.IdPointOfSale = reader.GetInt32(0);
				PointOfSaleFound.NamePoint = reader.GetString(1);
				PointOfSaleFound.Department = reader.GetString(2);
				PointOfSaleFound.Municipality = reader.GetString(3);
				PointOfSaleFound.Address = reader.GetString(4);
				PointOfSaleFound.NameOwner = reader.GetString(5);
				PointOfSaleFound.Phone = reader.GetString(6);
				PointOfSaleFound.E_mail = reader.GetString(7);
				PointOfSaleFound.AmountCodes = reader.GetString(8);
				PointOfSaleFound.PrefixCode = reader.GetString(9);
				
				ListPointOfSaleFound.Add(PointOfSaleFound);
			}
			
			return ListPointOfSaleFound;
		}
		
		public static int DeletePointOfSale(int Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("delete from Point_of_Sale where idPoint_of_Sale = {0}", Id), MyConnection);
			
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
