/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/24/2020
 * Time: 4:22 PM
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the entity Session_customer with correspondient properties.
	/// </summary>
	public class Session_Customer
	{
		
		public String idSessionCustomer {get; set;}
		public String Full_Name {get; set;}
		public String Phone {get; set;}
		public String E_mail {get; set;}
		public String User_Session {get; set;}
		public String Password_session {get; set;}
		public String Date_aquisition {get; set;}
		public String Status_session {get; set;}
		public String Remarks {get; set;}
		
		
		
		public Session_Customer()
		{
		}
		
		
		public Session_Customer(String pIdSessionCustomer, String pFull_Name, String pPhone, String pE_mail, String pUser_session , String pPassword_session, String pDate_acquisition, String pStatus_session, String pRemarks)
		{
			this.idSessionCustomer = pIdSessionCustomer;
			this.Full_Name = pFull_Name;
			this.Phone = pPhone;
			this.E_mail = pE_mail;
			this.User_Session = pUser_session;
			this.Password_session = pPassword_session;
			this.Date_aquisition = pDate_acquisition;
			this.Status_session = pStatus_session;
			this.Remarks = pRemarks;
		}
	}
}
