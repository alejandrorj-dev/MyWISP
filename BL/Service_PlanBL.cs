/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 29/01/2020
 * Time: 15:13
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
	/// This class perform bussiness between User Interface and Data Access Layer about Service_Plan.
	/// </summary>
	public static class Service_PlanBL
	{
		
		public static int AddService_Plan(Service_Plan pService)
		{
			int result = 0;
			
			result = Service_PlanDAL.AddService_Plan(pService);
			
			return result;
		}
		
		public static List<Service_Plan> GetAllServices()
		{
			List<Service_Plan> ListAllServices = new List<Service_Plan>();
			
			ListAllServices = Service_PlanDAL.GetAllServices();
			
			return ListAllServices;
			
		}
		
		public static List<Service_Plan> SearchServicePlan(String DataForSearch)
		{
			List<Service_Plan> ServicesFound = new List<Service_Plan>();
			
			ServicesFound = Service_PlanDAL.SearchServicePlan(DataForSearch);
			
			return ServicesFound;
		}
		
		public static int EditServicePlan(Service_Plan pServicePlan, String id)
		{
			int result;
			
			result = Service_PlanDAL.EditServicePlan(pServicePlan, id);
			
			return result;
		}
		
		public static int DeleteServicePlan(String Id)
		{
			int result;
			
			result = Service_PlanDAL.DeleteServicePlan(Id);
			
			return result;
		}
		
		public static Service_Plan GetServiceById(String pId)
		{
			Service_Plan pService_Plan = new Service_Plan();
			
			pService_Plan = Service_PlanDAL.GetServiceById(pId);
			
			return pService_Plan;
		}
		
		public static int validateReferenceServiceExistence(String pId)
		{
			int result = 0;
			
			result = Service_PlanDAL.validateReferenceServiceExistence(pId);
			
			return result;
		}
	}
}
