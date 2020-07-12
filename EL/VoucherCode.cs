/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 09/03/2020
 * Time: 5:37 p. m.
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the entity VoucherCode with correspondient properties.
	/// </summary>
	public class VoucherCode
	{
		
		public int Amount {get; set;}
		public String Time {get;set;}
		public String TrafficLimit {get; set;}
		public String Prefix {get; set;}
		public String Profile {get; set;}
		public String Code {get; set;}
		
		public VoucherCode()
		{
		}
		
		public VoucherCode(int pAmount, String pTime, String pTrafficLimit, String pPrefix, String pProfile, String pCode)
		{
			this.Amount = pAmount;
			this.Time = pTime;
			this.TrafficLimit = pTrafficLimit;
			this.Prefix = pPrefix;
			this.Profile = pProfile;
			this.Code = pCode;
		}
	}
}
