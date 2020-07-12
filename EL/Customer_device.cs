/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/10/2020
 * Time: 3:51 PM
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the entity Customer_device with correspondient properties.
	/// </summary>
	public class Customer_device
	{
		
		public String MAC {get; set;}
		public String Name_Device {get; set;}
		public String IP_Device {get; set;}
		public String Brand_Device {get; set;}
		public String Type_Device {get; set;}
		public String Firmware_Device {get; set;}
		public int idInstalation_Device{get; set;}
		
		public String CustomerOwner {get; set;}
		
		
		public Customer_device()
		{
		}
		
		
		public Customer_device(String pMAC, String pName_Device, String pIP_Device, String pBrand_Device, String pType_Device, String pFirmware_Device, int pidInstalation_Device, String pCustomerOwner)
		{
			this.MAC = pMAC;
			this.Name_Device = pName_Device;
			this.IP_Device = pIP_Device;
			this.Brand_Device = pBrand_Device;
			this.Type_Device = pType_Device;
			this.Firmware_Device = pFirmware_Device;
			this.idInstalation_Device = pidInstalation_Device;
			
			this.CustomerOwner = pCustomerOwner;
		}
	}
}
