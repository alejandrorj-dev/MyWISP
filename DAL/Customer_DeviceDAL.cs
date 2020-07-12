/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/10/2020
 * Time: 3:58 PM
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
	/// This class it allows to manage the data in the table Customer_device on database MyWISPSI 
	/// </summary>
	public static class Customer_DeviceDAL
	{
		public static int AddCustomerDevice(Customer_device pCustomer_device)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Customer_device (MAC_device, Name_device, IP_device, Brand_device, Type_device, Firmware_version, Instalation_idInstalation) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})",
			 pCustomer_device.MAC, pCustomer_device.Name_Device, pCustomer_device.IP_Device, pCustomer_device.Brand_Device, pCustomer_device.Type_Device, pCustomer_device.Firmware_Device, pCustomer_device.idInstalation_Device), MyConnection);
			
			
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
		
		public static int EditCustomerDevice(Customer_device CustomerDevice, String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("update Customer_device set MAC_device = '{0}', Name_device = '{1}', IP_device = '{2}', Brand_device = '{3}', Type_device = '{4}', Firmware_version = '{5}' where MAC_device = '{6}'", 
			 CustomerDevice.MAC, CustomerDevice.Name_Device, CustomerDevice.IP_Device, CustomerDevice.Brand_Device, CustomerDevice.Type_Device, CustomerDevice.Firmware_Device, Id), MyConnection);
			
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
		
		public static List<Customer_device> GetCustomerDevices(int Id)
		{
			
			List<Customer_device> MyList = new List<Customer_device>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Customer_device where Instalation_idInstalation = {0}", Id), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Customer_device CustomerDevice = new Customer_device();
				CustomerDevice.MAC = reader.GetString(0);
				CustomerDevice.Name_Device = reader.GetString(1);
				CustomerDevice.IP_Device = reader.GetString(2);
				CustomerDevice.Brand_Device = reader.GetString(3);
				CustomerDevice.Type_Device = reader.GetString(4);
				CustomerDevice.Firmware_Device = reader.GetString(5);
				CustomerDevice.idInstalation_Device = reader.GetInt32(6);
				
				MyList.Add(CustomerDevice);
			}
			
			return MyList;
		}
		
		public static Customer_device GetCustomerDeviceByMAC(String MAC)
		{
			Customer_device CustomerDevice = new Customer_device();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select MAC_device, Name_device, IP_device, Brand_device, Type_device, Firmware_version from Customer_device where MAC_device = '{0}'", MAC), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				CustomerDevice.MAC = reader.GetString(0);
				CustomerDevice.Name_Device = reader.GetString(1);
				CustomerDevice.IP_Device = reader.GetString(2);
				CustomerDevice.Brand_Device = reader.GetString(3);
				CustomerDevice.Type_Device = reader.GetString(4);
				CustomerDevice.Firmware_Device = reader.GetString(5);			
			}
			
			return CustomerDevice;
		}
		
		public static List<Customer_device> GetCustomerDeviceWithCustomer()
		{
			List<Customer_device> CustomerDevices = new List<Customer_device>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand("select MAC_device, Name_device, IP_device, Brand_device, Type_device, Firmware_version, idInstalation, Full_Name from Customer_device, Instalation inner join Customer where Customer_device.Instalation_idInstalation = Instalation.idInstalation and Instalation.Customer_idCustomer = Customer.idCustomer;", MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Customer_device CustomerDevice = new Customer_device();
				
				CustomerDevice.MAC = reader.GetString(0);
				CustomerDevice.Name_Device = reader.GetString(1);
				CustomerDevice.IP_Device = reader.GetString(2);
				CustomerDevice.Brand_Device = reader.GetString(3);
				CustomerDevice.Type_Device = reader.GetString(4);
				CustomerDevice.Firmware_Device = reader.GetString(5);
				CustomerDevice.idInstalation_Device = Convert.ToInt32(reader.GetString(6));
				CustomerDevice.CustomerOwner = reader.GetString(7);	
							
				
				CustomerDevices.Add(CustomerDevice);
			}
			
			return CustomerDevices;
		}
		
		public static int verifyCustomerDeviceExistence(String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Customer_device where MAC_device = '{0}'", Id), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while (reader.Read())
			{
				resultQuery = 50;
			}
			
			return resultQuery;
		}
		
		public static int DeleteCustomerDevice(String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("delete from Customer_device where MAC_device = '{0}'", Id), MyConnection);
			
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
