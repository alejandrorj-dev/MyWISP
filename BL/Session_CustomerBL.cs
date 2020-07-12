/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/24/2020
 * Time: 4:41 PM
 * 
 * 
 */
using System;
using System.Collections.Generic;
using EL;
using DAL;


namespace BL
{
	/// <summary>
	/// This class perform bussiness between User Interface and Data Access Layer about Session_Customer.
	/// </summary>
	public static class Session_CustomerBL
	{
		public static int AddSessionCustomer(Session_Customer NewSessionCustomer)
		{
			int  result = 0;
			
			result = Session_CustomerDAL.AddSessionCustomer(NewSessionCustomer);
			
			return result;
		}
		
		public static int EditSessionCustomer(Session_Customer SessionCustomerModified, String Id)
		{
			int result;
			
			result = Session_CustomerDAL.EditSessionCustomer(SessionCustomerModified, Id);
			
			return result;
		}
		
		public static List<Session_Customer> GetAllSessionCustomers()
		{
			List<Session_Customer> AllSessionCustomers = new List<Session_Customer>();
			
			AllSessionCustomers = Session_CustomerDAL.GetAllSessionCustomers();
			
			return AllSessionCustomers;
		}
		
		public static Session_Customer GetSessionCustomerById(String Id)
		{
			Session_Customer SessionCustomerRecd = new Session_Customer();
			
			SessionCustomerRecd = Session_CustomerDAL.GetSessionCustomerById(Id);
			
			return SessionCustomerRecd;
		}
		
		public static List<Session_Customer> SearchSessionCustomer(String Criteria)
		{
			List<Session_Customer> ListSessionCustomersFound = new List<Session_Customer>();
			
			ListSessionCustomersFound = Session_CustomerDAL.SearchSessionCustomer(Criteria);
			
			return ListSessionCustomersFound;
		}
		
		public static int DeleteSessionCustomer(String Id)
		{
			int result;
			
			result = Session_CustomerDAL.DeleteSessionCustomer(Id);
			
			return result;
		}
	}
}
