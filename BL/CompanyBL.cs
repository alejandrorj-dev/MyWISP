/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/14/2020
 * Time: 3:06 PM
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
	/// This class perform bussiness between User Interface and Data Access Layer about Company.
	/// </summary>
	public static class CompanyBL
	{
		
		public static int AddCompany(Company NewCompany)
		{
			int result = 0;
			
			result = CompanyDAL.AddCompany(NewCompany);
			
			return result;
		}
		
		public static int EditCompanyInformation(Company MyCompany, String Id)
		{
			int result;
			
			result = CompanyDAL.EditCompanyInformation(MyCompany, Id);
			
			return result;
		}
		
		public static Company GetInformationCompany()
		{
			Company MyCompany = new Company();
			
			MyCompany = CompanyDAL.GetInformationCompany();
			
			return MyCompany;
		}
	}
}
