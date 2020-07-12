/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 22/01/2020
 * Time: 17:34
 * 
 * 
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using EL;

namespace DAL
{
	/// <summary>
	/// This class it allows the data in the table Users on database MyWISPSI.
	/// </summary>
	public static class UserDAL
	{
		
		
		public static int AddUser(User pUser)
		{
			
			int resultQuery = 0;
		
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Users(First_Name, Last_Name, First_Surname, Last_Surname, Name_User, Password_User) values('{0}', '{1}', '{2}', '{3}', '{4}', MD5('{5}'))", 
			pUser.First_Name, pUser.Last_Name, pUser.First_Surname, pUser.Last_Surname, pUser.Name_User, pUser.Password_User), MyConnection);
			
			
				try
				{
					resultQuery = MyCommand.ExecuteNonQuery();
				}
				catch(MySqlException)
				{
					resultQuery = 0;
				}
			
			
			MyConnection.Close();
			
			return resultQuery;
		}
		
		public static int ValidateUser(String pUsername, String pPassword)
		{
		
			int resultQuery = 0;
			
			User pUser = new User();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select First_Name, First_Surname from Users where Name_User = '{0}' and Password_User = MD5('{1}')", pUsername, pPassword), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
			
				resultQuery = 50;
			}
			
			MyConnection.Close();
			
			return resultQuery;
			
		}
		
		public static User GetCurrentUser(String Username, String Password)
		{
		
			User pUser = new User();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select First_Name, First_Surname from Users where Name_User = '{0}' and Password_User = MD5('{1}')", Username, Password), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
			
				pUser.Name_User = reader.GetString(0);
				pUser.First_Surname = reader.GetString(1);
			}
			
			MyConnection.Close();
			return pUser;
		}
		
		public static int validateUserExistence(String pUsername, String pPassword)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Users where Name_User = '{0}' or Password_User = MD5('{1}')", pUsername, pPassword), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				resultQuery = 50;
			}
			
			MyConnection.Close();
			
			return resultQuery;
		}
		
		public static List<User> GetAllUsers()
		{
			List<User> MyList = new List<User>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand("select idUser, First_Name, Last_Name, First_Surname, Last_Surname, Name_User from Users", MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
			
				User pUser = new User();
				pUser.Id = reader.GetInt32(0);
				pUser.First_Name = reader.GetString(1);
				pUser.Last_Name = reader.GetString(2);
				pUser.First_Surname = reader.GetString(3);
				pUser.Last_Surname = reader.GetString(4);
				pUser.Name_User = reader.GetString(5);
				
				MyList.Add(pUser);
			}
			
			return MyList;
		}
		
		public static List<User> SearchUser(String DataToSearch)
		{
		
			List<User> MyList = new List<User>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select idUser, First_Name, Last_Name, First_Surname, Last_Surname, Name_User from Users where First_Name like '%{0}%' or Last_Surname like '%{0}%' or First_Surname like '%{0}%' or Last_Surname like '%{0}%' or Name_User like '%{0}%'", DataToSearch), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
			
				User pUser = new User();
				pUser.Id = reader.GetInt32(0);
				pUser.First_Name = reader.GetString(1);
				pUser.Last_Name = reader.GetString(2);
				pUser.First_Surname = reader.GetString(3);
				pUser.Last_Surname = reader.GetString(4);
				pUser.Name_User = reader.GetString(5);
				
				MyList.Add(pUser);
			}
			
			return MyList;
		}
	}
}
