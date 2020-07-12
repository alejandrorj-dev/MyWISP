/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/24/2020
 * Time: 4:30 PM
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
	/// This class it allows to manage the data in the table Session_Customer on database MyWISPSI.
	/// </summary>
	public static class Session_CustomerDAL
	{
		public static int AddSessionCustomer(Session_Customer NewSessionCustomer)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Session_Customer (idSession_Customer, Full_Name, Phone, E_mail, User_session, Password_session, Date_acquisition, Status_session, Remarks) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", 
			 NewSessionCustomer.idSessionCustomer, NewSessionCustomer.Full_Name, NewSessionCustomer.Phone, NewSessionCustomer.E_mail, NewSessionCustomer.User_Session, NewSessionCustomer.Password_session, NewSessionCustomer.Date_aquisition, NewSessionCustomer.Status_session, NewSessionCustomer.Remarks), MyConnection);
			
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
		
		public static int EditSessionCustomer(Session_Customer UpdatingSessionCustomer, String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("update Session_Customer set idSession_Customer = '{0}', Full_Name = '{1}', Phone = '{2}', E_mail = '{3}', User_session = '{4}', Password_session = '{5}', Date_acquisition = '{6}', Status_session = '{7}', Remarks = '{8}' where idSession_Customer = '{9}'",
			 UpdatingSessionCustomer.idSessionCustomer, UpdatingSessionCustomer.Full_Name, UpdatingSessionCustomer.Phone, UpdatingSessionCustomer.E_mail, UpdatingSessionCustomer.User_Session, UpdatingSessionCustomer.Password_session, UpdatingSessionCustomer.Date_aquisition, UpdatingSessionCustomer.Status_session, UpdatingSessionCustomer.Remarks, Id), MyConnection);
			
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
		
		public static List<Session_Customer> GetAllSessionCustomers()
		{
			List<Session_Customer> AllSessionCustomers = new List<Session_Customer>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand("select * from Session_Customer", MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Session_Customer SessionCustomer = new Session_Customer();
				SessionCustomer.idSessionCustomer = reader.GetString(0);
				SessionCustomer.Full_Name = reader.GetString(1);
				SessionCustomer.Phone = reader.GetString(2);
				SessionCustomer.E_mail = reader.GetString(3);
				SessionCustomer.User_Session = reader.GetString(4);
				SessionCustomer.Password_session = reader.GetString(5);
				SessionCustomer.Date_aquisition = reader.GetString(6);
				SessionCustomer.Status_session = reader.GetString(7);
				SessionCustomer.Remarks = reader.GetString(8);
				
				AllSessionCustomers.Add(SessionCustomer);
			}
			
			return AllSessionCustomers;
		}
		
		public static Session_Customer GetSessionCustomerById(String Id)
		{
			Session_Customer SessionCustomerTaken = new Session_Customer();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Session_Customer where idSession_Customer = '{0}'", Id), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				SessionCustomerTaken.idSessionCustomer = reader.GetString(0);
				SessionCustomerTaken.Full_Name = reader.GetString(1);
				SessionCustomerTaken.Phone = reader.GetString(2);
				SessionCustomerTaken.E_mail = reader.GetString(3);
				SessionCustomerTaken.User_Session = reader.GetString(4);
				SessionCustomerTaken.Password_session = reader.GetString(5);
				SessionCustomerTaken.Date_aquisition = reader.GetString(6);
				SessionCustomerTaken.Status_session = reader.GetString(7);
				SessionCustomerTaken.Remarks = reader.GetString(8);
			}
			
			return SessionCustomerTaken;
		}
		
		public static List<Session_Customer> SearchSessionCustomer(String Data)
		{
			List<Session_Customer> ListSessionCustomers = new List<Session_Customer>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Session_Customer where idSession_Customer like '%{0}%' or Full_Name like '%{0}%' or Phone like '%{0}%' or E_mail like '%{0}%' or User_session like '%{0}%' or Password_session like '%{0}%' or Date_acquisition like '%{0}%' or Status_session like '%{0}%' or Remarks like '%{0}%'", Data), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Session_Customer SessionCustomerFound = new Session_Customer();
				SessionCustomerFound.idSessionCustomer = reader.GetString(0);
				SessionCustomerFound.Full_Name = reader.GetString(1);
				SessionCustomerFound.Phone = reader.GetString(2);
				SessionCustomerFound.E_mail = reader.GetString(3);
				SessionCustomerFound.User_Session = reader.GetString(4);
				SessionCustomerFound.Password_session = reader.GetString(5);
				SessionCustomerFound.Date_aquisition = reader.GetString(6);
				SessionCustomerFound.Status_session = reader.GetString(7);
				SessionCustomerFound.Remarks = reader.GetString(8);
				
				ListSessionCustomers.Add(SessionCustomerFound);
			}
			
			return ListSessionCustomers;
		}
		
		public static int DeleteSessionCustomer(String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("delete from Session_Customer where idSession_Customer = '{0}'", Id), MyConnection);
			
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
