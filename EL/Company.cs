/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/14/2020
 * Time: 2:47 PM
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the entity Company with correspondient properties.
	/// </summary>
	public class Company
	{
		
		public String NIT {get; set;}
		public String Name {get; set;}
		public String City {get; set;}
		public String Department {get; set;}
		public String Address {get; set;}
		public String Phone {get; set;}
		public String E_mail {get; set;}
		public String Website {get; set;}
		public String Image {get; set;}
		
		
		
		public Company(){}
		
		
		public Company(String pNIT, String pName, String pCity, String pDepartment, String pAddress, String pPhone, String pE_mail, String pWebsite, String pImage)
		{
			this.NIT = pNIT;
			this.Name = pName;
			this.City = pCity;
			this.Department = pDepartment;
			this.Address = pAddress;
			this.Phone = pPhone;
			this.E_mail = pE_mail;
			this.Website = pWebsite;
			this.Image = pImage;
		}
	}
}
