/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/26/2020
 * Time: 4:52 PM
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
	/// This class perform bussiness between User Inteface and Data Access Layer about Point_of_Sale.
	/// </summary>
	public static class Point_of_SaleBL
	{
		public static int AddPointOfSale(Point_of_Sale NewPointOfSale)
		{
			int result;
			
			result = Point_of_SaleDAL.AddPointOfSale(NewPointOfSale);
			
			return result;
		}
		
		public static int EditPointOfSale(Point_of_Sale PointOfSaleForEdit, int Id)
		{
			int result;
			
			result = Point_of_SaleDAL.EditPointOfSale(PointOfSaleForEdit, Id);
			
			return result;
		}
		
		public static List<Point_of_Sale> GetAllPointsOfSale()
		{
			List<Point_of_Sale> ListPointsOfSale = new List<Point_of_Sale>();
			
			ListPointsOfSale = Point_of_SaleDAL.GetAllPointsOfSale();
			
			return ListPointsOfSale;
		}
		
		public static Point_of_Sale GetPointOfSale(int Id)
		{
			Point_of_Sale POSSelected = new Point_of_Sale();
			
			POSSelected = Point_of_SaleDAL.GetPointOfSale(Id);
			
			return POSSelected;
		}
		
		public static List<Point_of_Sale> SearchPointOfSale(String data)
		{
			List<Point_of_Sale> ListPointOfSale = new List<Point_of_Sale>();
			
			ListPointOfSale = Point_of_SaleDAL.SearchPointOfSale(data);
			
			return ListPointOfSale;
		}
		
		public static int DeletePointOfSale(int Id)
		{
			int result = 0;
			
			result = Point_of_SaleDAL.DeletePointOfSale(Id);
			
			return result;
		}
	}
}
