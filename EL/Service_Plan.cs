/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 29/01/2020
 * Time: 14:44
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the entity Service_Plan with correspondient properties.
	/// </summary>
	public class Service_Plan
	{
		
		
		public String Id {get; set;}
		public String Name_Plan {get; set;}
		public Double Price_Plan {get; set;}
		public String Description {get; set;}
		
		
		
		public Service_Plan()
		{
		}
		
		
		public Service_Plan(String pId, String pName_Plan, float pPrice_Plan, String pDescription)
		{
			this.Id = pId;
			this.Name_Plan = pName_Plan;
			this.Price_Plan = pPrice_Plan;
			this.Description = pDescription;
		}
		
	}
}
