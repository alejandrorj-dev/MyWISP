/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 05/03/2020
 * Time: 4:56 p. m.
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the entity Equipment with correspondient properties.
	/// </summary>
	public class Equipment
	{
		
		public String MAC {get; set;}
		public String Name {get;set;}
		public String Brand {get;set;}
		public String Type {get;set;}
		public String IP {get;set;}
		public String Frecuency {get;set;}
		public String Firmware_version {get;set;}
		public String Ubication {get;set;}
		public String Date_instalation {get;set;}
		public String Remarks {get;set;}
		
		public Equipment()
		{
		}
		
		public Equipment(String pMAC, String pName, String pBrand, String pType, String pIP, String pFrecuency, String pFirmware_version, String pUbication, String pDate_instalation, String pRemarks)
		{
			this.MAC = pMAC;
			this.Name = pName;
			this.Brand = pBrand;
			this.Type = pType;
			this.IP = pIP;
			this.Frecuency = pFrecuency;
			this.Firmware_version = pFirmware_version;
			this.Ubication = pUbication;
			this.Date_instalation = pDate_instalation;
			this.Remarks = pRemarks;
		}
	}
}
