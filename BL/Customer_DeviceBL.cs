/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/10/2020
 * Time: 4:06 PM
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
	/// This class perform bussiness between User Interface and Data Access Layer about Customer_Device.
	/// </summary>
	public static class Customer_DeviceBL
	{
		public static int AddCustomerDevice(Customer_device pCustomerDevice)
		{
			int result;
			
			result = Customer_DeviceDAL.AddCustomerDevice(pCustomerDevice);
			
			return result;
		}
		
		public static int EditCustomerDevice(Customer_device pCustomerDevice, String Id)
		{
			int result;
			
			result = Customer_DeviceDAL.EditCustomerDevice(pCustomerDevice, Id);
			
			return result;
		}
		
		public static List<Customer_device> GetCustomerDevices(int Id)
		{
			List<Customer_device> CustomerDevicesList = new List<Customer_device>();
			
			CustomerDevicesList = Customer_DeviceDAL.GetCustomerDevices(Id);
			
			return CustomerDevicesList;
		}
		
		public static List<Customer_device> GetCustomerDeviceWithCustomer()
		{
			List<Customer_device> CustomerDevicesWithCustomer = new List<Customer_device>();
			
			CustomerDevicesWithCustomer = Customer_DeviceDAL.GetCustomerDeviceWithCustomer();
			
			return CustomerDevicesWithCustomer;
		}
		
		public static Customer_device GetCustomerDeviceByMAC(String MAC)
		{
			Customer_device CustomerDevice = new Customer_device();
			
			CustomerDevice = Customer_DeviceDAL.GetCustomerDeviceByMAC(MAC);
			
			return CustomerDevice;
		}
		
		public static int verifyCustomerDeviceExistence(String Id)
		{
			int result;
			
			result = Customer_DeviceDAL.verifyCustomerDeviceExistence(Id);
			
			return result;
		}
		
		public static int DeleteCustomerDevice(String Id)
		{
			int result;
			
			result = Customer_DeviceDAL.DeleteCustomerDevice(Id);
			
			return result;
		}
	}
}
