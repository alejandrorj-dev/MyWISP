/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 05/03/2020
 * Time: 5:03 p. m.
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
	/// This class it allows to manage the data in the table Equipment on database MyWISPSI.
	/// </summary>
	public static class EquipmentDAL
	{
		public static int AddEquipment(Equipment NewEquipment)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("insert into Equipment(MAC_Equipment, Name_Equipment, Brand_Equipment, Type_equipment, IP_Equipment, Frecuency_Equipment, Firmware_Version, Ubication_Node, Date_instalation, Remarks) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", 
			NewEquipment.MAC, NewEquipment.Name, NewEquipment.Brand, NewEquipment.Type, NewEquipment.IP, NewEquipment.Frecuency, NewEquipment.Firmware_version, NewEquipment.Ubication, NewEquipment.Date_instalation, NewEquipment.Remarks), MyConnection);
			
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
		
		public static int EditEquipment(Equipment EquipmentForEdit, String Id)
		{
			int resultQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("update Equipment set MAC_equipment = '{0}', Name_Equipment = '{1}', Brand_Equipment = '{2}', Type_equipment = '{3}', IP_Equipment = '{4}', Frecuency_Equipment = '{5}', Firmware_version = '{6}', Ubication_Node = '{7}', Date_instalation = '{8}', Remarks = '{9}' where MAC_equipment = '{10}'",
			  EquipmentForEdit.MAC, EquipmentForEdit.Name, EquipmentForEdit.Brand, EquipmentForEdit.Type, EquipmentForEdit.IP, EquipmentForEdit.Frecuency, EquipmentForEdit.Firmware_version, EquipmentForEdit.Ubication, EquipmentForEdit.Date_instalation, EquipmentForEdit.Remarks, Id), MyConnection);
			
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
		
		public static Equipment GetEquipment(String Id)
		{
			Equipment EquipmentReceived = new Equipment();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("select * from Equipment where MAC_equipment = '{0}'", Id), MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				EquipmentReceived.MAC = reader.GetString(0);
				EquipmentReceived.Name = reader.GetString(1);
				EquipmentReceived.Brand = reader.GetString(2);
				EquipmentReceived.Type = reader.GetString(3);
				EquipmentReceived.IP = reader.GetString(4);
				EquipmentReceived.Frecuency = reader.GetString(5);
				EquipmentReceived.Firmware_version = reader.GetString(6);
				EquipmentReceived.Ubication = reader.GetString(7);
				EquipmentReceived.Date_instalation = Convert.ToString(reader.GetDateTime(8));
				EquipmentReceived.Remarks = reader.GetString(9);
			}
			
			return EquipmentReceived;
		}
		
		public static List<Equipment> GetAllEquipments()
		{
			List<Equipment> AllEquipments = new List<Equipment>();
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand("select * from Equipment", MyConnection);
			
			MySqlDataReader reader = MyCommand.ExecuteReader();
			
			while(reader.Read())
			{
				Equipment MyEquipment = new Equipment();
				MyEquipment.MAC = reader.GetString(0);
				MyEquipment.Name = reader.GetString(1);
				MyEquipment.Brand = reader.GetString(2);
				MyEquipment.Type = reader.GetString(3);
				MyEquipment.IP = reader.GetString(4);
				MyEquipment.Frecuency = reader.GetString(5);
				MyEquipment.Firmware_version = reader.GetString(6);
				MyEquipment.Ubication = reader.GetString(7);
				MyEquipment.Date_instalation = Convert.ToString(reader.GetDateTime(8));
				MyEquipment.Remarks = reader.GetString(9);
				
				AllEquipments.Add(MyEquipment);
			}
			
			return AllEquipments;
		}
		
		public static int DeleteEquipment(String Id)
		{
			int resulQuery = 0;
			
			MySqlConnection MyConnection = Connection.GetMyConnection();
			
			MySqlCommand MyCommand = new MySqlCommand(string.Format("delete from Equipment where Mac_equipment = '{0}'", Id), MyConnection);
			
				try
				{
					resulQuery = MyCommand.ExecuteNonQuery();
				}
				catch(MySqlException)
				{
					resulQuery = 0;
				}
			
			return resulQuery;
		}
	}
}
