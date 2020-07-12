/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 09/03/2020
 * Time: 5:48 p. m.
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represent the entity LoginTicket with correspondient properties.
	/// </summary>
	public class LoginTicket
	{
		
		public int Amount {get; set;}
		public String Time {get; set;}
		public String TrafficLimit {get; set;}
		public String Prefix {get; set;}
		public String Profile {get; set;}
		public String User {get; set;}
		public String Password {get; set;}
		
		public LoginTicket(){}
		
		public LoginTicket(int pAmount, String pTime, String pTrafficLimit, String pPrefix, String pProfile, String pUser, String pPassword)
		{
			this.Amount = pAmount;
			this.Time = pTime;
			this.TrafficLimit = pTrafficLimit;
			this.Prefix = pPrefix;
			this.Profile = pProfile;
			this.User = pUser;
			this.Password = pPassword;
		}
	}
}
