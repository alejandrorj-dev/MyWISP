/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 22/01/2020
 * Time: 17:25
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represent the entity User with correspondient properties.
	/// </summary>
	public class User
	{
		
		public int Id {get; set;}
		public string First_Name {get; set;}
		public string Last_Name {get; set;}
		public string First_Surname {get; set;}
		public string Last_Surname {get; set;}
		public string Name_User {get; set;}
		public string Password_User {get; set;}
		
		
		
		public User()
		{
		}
		
		public User(int pId, string pFirst_Name, string pLast_Name, string pFirst_Surname, string pLast_Surname, string pName_User, string pPassword_User)
		{
		
			this.Id = pId;
			this.First_Name = pFirst_Name;
			this.Last_Name = pLast_Name;
			this.First_Surname = pFirst_Surname;
			this.Last_Surname = pLast_Surname;
			this.Name_User = pName_User;
			this.Password_User = pPassword_User;
		}
		
		
	}
}
