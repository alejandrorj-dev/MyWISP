/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 27/01/2020
 * Time: 15:20
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the Customer entity with correspondient properties.
	/// </summary>
	public class Customer
	{
				
		public String idCustomer {get; set;}
		public String Full_Name {get; set;}
		public String Municipality {get; set;}
		public String Department {get; set;}
		public String Address {get; set;}
		public String Phone {get; set;}
		public String E_mail {get; set;}
		public String Status {get; set;}
		public String Remark {get; set;}
		
		public Customer(){}
		
		public Customer(String pidCustomer, String pFull_Name, String pMunicipality, String pDepartment, String pAddress, String pPhone, String pE_mail, String pStatus, String pRemark)
		{
			this.idCustomer = pidCustomer;
			this.Full_Name = pFull_Name;
			this.Municipality = pMunicipality;
			this.Department = pDepartment;
			this.Address = pAddress;
			this.Phone = pPhone;
			this.E_mail = pE_mail;
			this.Status = pStatus;
			this.Remark = pRemark;
		}
	}
}
