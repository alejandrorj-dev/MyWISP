/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 05/03/2020
 * Time: 5:04 p. m.
 * 
 * 
 */
using System;
using System.Collections.Generic;
using EL;
using DAL;

namespace BL
{
	/// <summary>
	/// This class perform bussiness between User Interface and Data Access Layer about Equipment.
	/// </summary>
	public static class EquipmentBL
	{
		public static int AddEqupment(Equipment NewEquipment)
		{
			int result;
			
			result = EquipmentDAL.AddEquipment(NewEquipment);
			
			return result;
		}
		
		public static int EditEquipment(Equipment EquipmentForEdit, String Id)
		{
			int result;
			
			result = EquipmentDAL.EditEquipment(EquipmentForEdit, Id);
			
			return result;
		}
		
		public static Equipment GetEquipment(String Id)
		{
			Equipment MyEquipmentChosen = new Equipment();
			
			MyEquipmentChosen = EquipmentDAL.GetEquipment(Id);
			
			return MyEquipmentChosen;
		}
		
		public static List<Equipment> GetAllEquipments()
		{
			List<Equipment> AllEquipments = new List<Equipment>();
			
			AllEquipments = EquipmentDAL.GetAllEquipments();
			
			return AllEquipments;
		}
		
		public static int DeleteEquipment(String Id)
		{
			int result;
			
			result = EquipmentDAL.DeleteEquipment(Id);
			
			return result;
		}
	}
}
