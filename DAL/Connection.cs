/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 22/01/2020
 * Time: 17:13
 * 
 * 
 */
using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
	/// <summary>
	/// This class it allows to establish connection with database MyWISPSI.
	/// </summary>
	public class Connection
	{
		public Connection(){}
		
		
		public static MySqlConnection GetMyConnection()
		{
			
			String MyServer = "127.0.0.1";
			String MyDatabase = "MyWISPSI";
			String MyUser = "root";
			String MyPassword = "";
			
			MySqlConnection Connection = new MySqlConnection("Server="+MyServer+";Database="+MyDatabase+";Uid="+MyUser+";Pwd="+MyPassword+";");
			
				try
				{
					Connection.Open();
				}
				catch(MySqlException e)
				{
					Console.Write("No connected to database, error here: " + e.Message);
				}
			
			return Connection;
		}
			
	}
}
