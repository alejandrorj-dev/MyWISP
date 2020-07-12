/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 27/01/2020
 * Time: 16:01
 * 
 * 
 */
using System;
using System.Collections.Generic;
using DAL;
using EL;

namespace BL
{
	/// <summary>
	/// This class perform bussiness between User Interface and Data Access Layer about Customer.
	/// </summary>
	public static class CustomerBL
	{
		
		public static int AddCustomer(Customer pCustomer)
		{
			int result = 0;
			
			result = CustomerDAL.AddCustomer(pCustomer);
			
			return result;
		}
		
		public static int EditCustomer(Customer pCustomer, String Id)
		{
			int result;
			
			result = CustomerDAL.EditCustomer(pCustomer, Id);
			
			return result;
		}
		
		public static List<Customer> GetAllCustomers()
		{
			List<Customer> pCustomer = new List<Customer>();
			
			pCustomer = CustomerDAL.GetAllCustomers();
			
			return pCustomer;
		}
		
		public static Customer GetCustomer(String IdCustomer)
		{
			Customer customer = new Customer();
			
			customer = CustomerDAL.GetCustomer(IdCustomer);
			
			return customer;
		}
		
		public static int verifyCustomerExistence(String id)
		{
			int result;
			
			result = CustomerDAL.verifyCustomerExistence(id);
			
			return result;
		}
		
		public static List<Customer> SearchCustomer(String Param)
		{
			List<Customer> MyResultList = new List<Customer>();
			
			MyResultList = CustomerDAL.SearchCustomer(Param);
			
			return MyResultList;
		}
		
		
		
	}
}
