/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/5/2020
 * Time: 5:27 PM
 * 
 * 
 */
using System;

namespace EL
{
	/// <summary>
	/// This class it represents the entity Instalatios with correspondient properties.
	/// </summary>
	public class Instalation
	{
			
		
		public int Id {get; set;}
		public String Date {get; set;}
		public String Materials {get; set;}
		public String Place {get; set;}
		public String IdCustomer {get; set;}
		public String idService {get; set;}
		
		
		public Instalation(){}
		
		
		public Instalation(int pId, String pDate, String pMaterials, String pPlace, String pIdCustomer, String pIdService)
		{
			this.Id = pId;
			this.Date = pDate;
			this.Materials = pMaterials;
			this.Place = pPlace;
			this.IdCustomer = pIdCustomer;
			this.idService = pIdService;
		}
	}
}
