/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/14/2020
 * Time: 2:54 PM
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
	/// This class it allows to manage the data in the table Company on database MyWISPSI.
	/// </summary>
	public static class CompanyDAL
	{
		public static int AddCompany(Company NewCompany)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Company (NIT, Name_Company, City, Department, Address, Phone, E_mail, Website_Address, Image) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
			  NewCompany.NIT, NewCompany.Name, NewCompany.City, NewCompany.Department, NewCompany.Address, NewCompany.Phone, NewCompany.E_mail, NewCompany.Website, NewCompany.Image), MyConnection);
			
			
				try
				{
					resultQuery = MyCommand.ExecuteNonQuery();
				}
				catch(MySqlException)
				{
					resultQuery = 0;
				}			
			
			
			return resultQuery;
		}
		
		public static int EditCompanyInformation(Company pCompany, String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("update Company set NIT = '{0}', Name_Company = '{1}', City = '{2}', Department = '{3}', Address = '{4}', Phone = '{5}', E_mail = '{6}', Website_Address = '{7}', Image = '{8}' where NIT = '{9}'", 
			  pCompany.NIT, pCompany.Name, pCompany.City, pCompany.Department, pCompany.Address, pCompany.Phone, pCompany.E_mail, pCompany.Website, pCompany.Image, Id), MyConnection);
			
				try
				{
					resultQuery = MyCommand.ExecuteNonQuery();
				}
				catch(MySqlException)
				{
					resultQuery = 0;
				}
			
			return resultQuery;
			
		}
		
		public static Company GetInformationCompany()
		{
			Company MyCompany = new Company();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand("select * from Company", MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				MyCompany.NIT = reader.GetString(0);
				MyCompany.Name = reader.GetString(1);
				MyCompany.City = reader.GetString(2);
				MyCompany.Department = reader.GetString(3);
				MyCompany.Address = reader.GetString(4);
				MyCompany.Phone = reader.GetString(5);
				MyCompany.E_mail = reader.GetString(6);
				MyCompany.Website = reader.GetString(7);
				MyCompany.Image = reader.GetString(8);				
			}
			
			return MyCompany;
		}
	}
}
