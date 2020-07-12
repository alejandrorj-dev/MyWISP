/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/5/2020
 * Time: 5:44 PM
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
	/// This class perform bussiness between User Interface and Data Access Layer about Instalation.
	/// </summary>
	public static class InstalationBL
	{
		public static int AddInstalation(Instalation pInstalation)
		{
			int result;
			
			result = InstalationDAL.AddInstalation(pInstalation);
			
			return result;		
			
		}
		
		
		public static List<Instalation> GetInstalation(String idCustomer)
		{
			List<Instalation> InstalationList = new List<Instalation>();
			
			InstalationList = InstalationDAL.GetInstalations(idCustomer);
			
			return InstalationList;
		}
		
		
		public static int EditInstalation(Instalation EdInstalation)
		{
			int result;
			
			result = InstalationDAL.EditInstalation(EdInstalation);
			
			return result;
		}
		
		public static int DeleteInstalation(int Id)
		{
			int result;
			
			result = InstalationDAL.DeleteInstalation(Id);
			
			return result;
		}
		
	}
	
}
