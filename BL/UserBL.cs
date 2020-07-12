/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 22/01/2020
 * Time: 17:45
 * 
 * 
 */
using System;
using System.Collections.Generic;
using DAL;
using EL;

namespace BL
{
	/// <summary>
	/// This class perform bussiness between User Interface and Data Access Layer about Users.
	/// </summary>
	public static class UserBL
	{
		
		
		public static int AddUser(User pUser)
		{
			int result;
			
			result = UserDAL.AddUser(pUser);
			
			return result;			
		}
		
		public static int ValidateUser(String pNameuser, String pPassword)
		{
		
			int result = -1;
			
			result = UserDAL.ValidateUser(pNameuser, pPassword);
			
			return result;
		}
		
		public static User GetCurrentUser(String Username, String Password)
		{
		
			User pUser = new User();
			
			pUser = UserDAL.GetCurrentUser(Username, Password);
			
			return pUser;
		}
		
		public static int validateUserExistence(String pUsername, String pPassword)
		{
			int result = -1;
			
			result = UserDAL.validateUserExistence(pUsername, pPassword);
			
			return result;
		}
		
		public static List<User> GetAllUsers()
		{
		
			List<User> MyListUsers = new List<User>();
			
			MyListUsers = UserDAL.GetAllUsers();
			
			return MyListUsers;
		}
		
		public static List<User> SearchUser(String DataToSearch)
		{
		
			List<User> MyList = new List<User>();
			
			MyList = UserDAL.SearchUser(DataToSearch);
			
			return MyList;
			
		}
		
		
	}
}
