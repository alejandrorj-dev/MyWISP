/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/26/2020
 * Time: 4:18 PM
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the entity Point_of_Sale with correspondient properties.
	/// </summary>
	public class Point_of_Sale
	{
		
		public int IdPointOfSale {get; set;}
		public String NamePoint {get; set;}
		public String Department {get; set;}
		public String Municipality {get; set;}
		public String Address {get; set;}
		public String NameOwner {get; set;}
		public String Phone {get; set;}
		public String E_mail {get; set;}
		public String AmountCodes {get; set;}
		public String PrefixCode {get; set;}
		
		
		
		public Point_of_Sale()
		{
		}
		
		
		public Point_of_Sale(int pIdPointOfSale, String pNamePoint, String pDepartment, String pMunicipality, String pAddress, String pNameOwner, String pPhone, String pE_mail, String pAmountCodes, String pPrefixCode)
		{
			this.IdPointOfSale = pIdPointOfSale;
			this.NamePoint = pNamePoint;
			this.Department = pDepartment;
			this.Municipality = pMunicipality;
			this.Address = pAddress;
			this.NameOwner = pNameOwner;
			this.Phone = pPhone;
			this.E_mail = pE_mail;
			this.AmountCodes = pAmountCodes;
			this.PrefixCode = pPrefixCode;
		}
	}
}
