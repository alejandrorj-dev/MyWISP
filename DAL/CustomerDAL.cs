/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 27/01/2020
 * Time: 15:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using EL;

namespace DAL
{
	/// <summary>
	/// This class it allows to manage the data in the table Customer on database MyWISPSI.
	/// </summary>
	public static class CustomerDAL
	{
		
		
		public static int AddCustomer(Customer pCustomer)
		{
			int result = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Customer(idCustomer, Full_Name, Municipality, Department, Address, Phone, E_mail, Status_customer, Remark) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
			 pCustomer.idCustomer, pCustomer.Full_Name, pCustomer.Municipality, pCustomer.Department, pCustomer.Address, pCustomer.Phone, pCustomer.E_mail, pCustomer.Status, pCustomer.Remark), MyConnection);
			
				try
				{
					result = MyCommand.ExecuteNonQuery();
				}
				catch(MySqlException)
				{
					result = 0;
				}
			
			
			
			return result;			
			
		}
		
		public static int EditCustomer(Customer pCustomer, String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("update Customer set idCustomer = '{0}', Full_Name = '{1}', Municipality = '{2}', Department = '{3}', Address = '{4}', Phone = '{5}', E_mail = '{6}', Status_customer = '{7}', Remark = '{8}' where idCustomer = '{9}'",
			 pCustomer.idCustomer, pCustomer.Full_Name, pCustomer.Municipality, pCustomer.Department, pCustomer.Address, pCustomer.Phone, pCustomer.E_mail, pCustomer.Status, pCustomer.Remark, Id), MyConnection);
			
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
		
		
		public static List<Customer> GetAllCustomers()
		{
		
			List<Customer> MyList = new List<Customer>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand("select * from Customer", MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Customer pCustomer = new Customer();
				pCustomer.idCustomer = reader.GetString(0);
				pCustomer.Full_Name = reader.GetString(1);
				pCustomer.Municipality = reader.GetString(2);
				pCustomer.Department = reader.GetString(3);
				pCustomer.Address = reader.GetString(4);
				pCustomer.Phone = reader.GetString(5);
				pCustomer.E_mail = reader.GetString(6);
				pCustomer.Status = reader.GetString(7);
				pCustomer.Remark = reader.GetString(8);
				
				MyList.Add(pCustomer);
			}
			
			return MyList;
		}
		
		public static Customer GetCustomer(String Id)
		{
			Customer customer = new Customer();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Customer where idCustomer = '{0}'", Id), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				customer.idCustomer = reader.GetString(0);
				customer.Full_Name = reader.GetString(1);
				customer.Municipality = reader.GetString(2);
				customer.Department = reader.GetString(3);
				customer.Address = reader.GetString(4);
				customer.Phone = reader.GetString(5);
				customer.E_mail = reader.GetString(6);
				customer.Status = reader.GetString(7);
				customer.Remark = reader.GetString(8);
			}
			
			return customer;
		}
		
		public static int verifyCustomerExistence(String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Customer where idCustomer = '{0}'", Id), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				resultQuery = 50;
			}
			
			return resultQuery;
			
		}
		
		public static List<Customer> SearchCustomer(String ParamToSearch)
		{
			List<Customer> MyList = new List<Customer>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Customer where idCustomer like '%{0}%' or Full_Name like '%{0}%' or Municipality like '%{0}%' or Department like '%{0}%' or Address like '%{0}%' or Phone like '%{0}%' or E_mail like '%{0}%' or Status_customer like '%{0}%' or Remark like '%{0}%'", ParamToSearch), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Customer pCustomer = new Customer();
				pCustomer.idCustomer = reader.GetString(0);
				pCustomer.Full_Name = reader.GetString(1);
				pCustomer.Municipality = reader.GetString(2);
				pCustomer.Department = reader.GetString(3);
				pCustomer.Address = reader.GetString(4);
				pCustomer.Phone = reader.GetString(5);
				pCustomer.E_mail = reader.GetString(6);
				pCustomer.Status = reader.GetString(7);
				pCustomer.Remark = reader.GetString(8);
				
				MyList.Add(pCustomer);
			}
			
			return MyList;
		}
		
	}
}
