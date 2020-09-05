/*
 * Created by SharpDevelop.
 * User: Hewlett Packard
 * Date: 05/09/2020
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using EL;

namespace BL
{
	/// <summary>
	/// Description of ExcelReport.
	/// </summary>
	public class ExcelReport
	{
		public ExcelReport()
		{
		}
		
		public static void ExportServicesPlanExcel(List<Service_Plan> ListServicesPlan)
		{
			SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Planes de Servicio Registrados"};
			
			
			if(File.ShowDialog() == DialogResult.OK)
			{
				Excel.Application ExcelApp = new Excel.Application();
				Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
				Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
				Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
				DateTime DateNow = DateTime.Now;
				
				Company MyCompany = CompanyBL.GetInformationCompany();
				
				String Logo = Convert.ToString(MyCompany.Image);
				
				MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);								
				
				
				ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
				ExcelSheet.Range["A1", "D1"].Merge();
				ExcelSheet.Range["A1", "D1"].Font.Bold = true;
				ExcelSheet.Range["A1", "D1"].Font.Size = 12;
				
				ExcelSheet.Range["A2", "D1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				ExcelSheet.Range["A2", "D1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A1", "D1"].RowHeight = 110;
				
				
				ExcelSheet.Cells[2, "D"] = "Planes de Servicio Registrados - ["+DateNow+"]";
				ExcelSheet.Range["A2", "D2"].Merge();
				ExcelSheet.Range["A2", "D2"].Font.Bold = true;
				ExcelSheet.Range["A2", "D2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A3", "D3"].Font.Bold = true;
				ExcelSheet.Cells[3, "A"] = "Referencia";
				ExcelSheet.Cells[3, "B"] = "Nombre del Plan";
				ExcelSheet.Cells[3, "C"] = "Precio (CO)";
				ExcelSheet.Cells[3, "D"] = "Descripcion";
	
				
				int row = 3;
				foreach(var serviceplan in ListServicesPlan)
				{
					row++;
					ExcelSheet.Cells[row, "A"] = serviceplan.Id;
					ExcelSheet.Cells[row, "B"] = serviceplan.Name_Plan;
					ExcelSheet.Cells[row, "C"] = "$"+serviceplan.Price_Plan;
					ExcelSheet.Cells[row, "D"] = serviceplan.Description;
				}
				
				ExcelSheet.Columns.AutoFit();
				
				ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
				
				ExcelApp.Quit();
				
				GC.Collect();
				
			} 
		} 
		
		public static void ExportEquipmetsExcel(List<Equipment> ListEquipments)
			{
				SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Equipos Registrados"};
				
				
				if(File.ShowDialog() == DialogResult.OK)
				{
					Excel.Application ExcelApp = new Excel.Application();
					Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
					Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
					Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
					DateTime DateNow = DateTime.Now;
					
					Company MyCompany = CompanyBL.GetInformationCompany();
					
					String Logo = Convert.ToString(MyCompany.Image);
					
					MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);								
					
					
					ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
					ExcelSheet.Range["A1", "J1"].Merge();
					ExcelSheet.Range["A1", "J1"].Font.Bold = true;
					ExcelSheet.Range["A1", "J1"].Font.Size = 12;
					
					ExcelSheet.Range["A2", "J1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					ExcelSheet.Range["A2", "J1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A1", "J1"].RowHeight = 110;
					
					
					ExcelSheet.Cells[2, "D"] = "Listado de Equipos Registrados - ["+DateNow+"]";
					ExcelSheet.Range["A2", "J2"].Merge();
					ExcelSheet.Range["A2", "J2"].Font.Bold = true;
					ExcelSheet.Range["A2", "J2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A3", "J3"].Font.Bold = true;
					ExcelSheet.Cells[3, "A"] = "MAC";
					ExcelSheet.Cells[3, "B"] = "Nombre Asignado";
					ExcelSheet.Cells[3, "C"] = "Marca";
					ExcelSheet.Cells[3, "D"] = "Tipo de Dispositivo";
					ExcelSheet.Cells[3, "E"] = "Dirección IP";
					ExcelSheet.Cells[3, "F"] = "Frecuencia";
					ExcelSheet.Cells[3, "G"] = "Versión de Firmware";
					ExcelSheet.Cells[3, "H"] = "Ubicacion";
					ExcelSheet.Cells[3, "I"] = "Fecha de Instalación";
					ExcelSheet.Cells[3, "J"] = "Observaciones";
					
					int row = 3;
					foreach(var equipments in ListEquipments)
					{
						row++;
						ExcelSheet.Cells[row, "A"] = equipments.MAC;
						ExcelSheet.Cells[row, "B"] = equipments.Name;
						ExcelSheet.Cells[row, "C"] = equipments.Brand;
						ExcelSheet.Cells[row, "D"] = equipments.Type;
						ExcelSheet.Cells[row, "E"] = equipments.IP;
						ExcelSheet.Cells[row, "F"] = equipments.Frecuency;
						ExcelSheet.Cells[row, "G"] = equipments.Firmware_version;
						ExcelSheet.Cells[row, "H"] = equipments.Ubication;
						ExcelSheet.Cells[row, "I"] = equipments.Date_instalation;
						ExcelSheet.Cells[row, "J"] = equipments.Remarks;
						
					}
					
					ExcelSheet.Columns.AutoFit();
					
					ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
					
					ExcelApp.Quit();
				
					GC.Collect();
				} 
			}
		
		public static void GenerateCustomersExcel(List<Customer> ListCustomers)
		{
			SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Clientes Registrados"};
			
			
			if(File.ShowDialog() == DialogResult.OK)
			{
				Excel.Application ExcelApp = new Excel.Application();
				Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
				Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
				Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
				DateTime DateNow = DateTime.Now;
				
				Company MyCompany = CompanyBL.GetInformationCompany();
				
				String Logo = Convert.ToString(MyCompany.Image);
				
				
				
				MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);								
				
				
				ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
				ExcelSheet.Range["A1", "I1"].Merge();
				ExcelSheet.Range["A1", "I1"].Font.Bold = true;
				ExcelSheet.Range["A1", "I1"].Font.Size = 12;
				
				ExcelSheet.Range["A2", "I1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				ExcelSheet.Range["A2", "I1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A1", "I1"].RowHeight = 110;
				
				
				ExcelSheet.Cells[2, "D"] = "Listado de Clientes Registrados - ["+DateNow+"]";
				ExcelSheet.Range["A2", "I2"].Merge();
				ExcelSheet.Range["A2", "I2"].Font.Bold = true;
				ExcelSheet.Range["A2", "I2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A3", "I3"].Font.Bold = true;
				ExcelSheet.Cells[3, "A"] = "Identificacion";
				ExcelSheet.Cells[3, "B"] = "Nombre Completo";
				ExcelSheet.Cells[3, "C"] = "Municipio";
				ExcelSheet.Cells[3, "D"] = "Departamento";
				ExcelSheet.Cells[3, "E"] = "Direccion";
				ExcelSheet.Cells[3, "F"] = "Telefono";
				ExcelSheet.Cells[3, "G"] = "E-mail";
				ExcelSheet.Cells[3, "H"] = "Estado";
				ExcelSheet.Cells[3, "I"] = "Observaciones";
				
				
				
				int row = 3;
				foreach(var customer in ListCustomers)
				{
					row++;
					ExcelSheet.Cells[row, "A"] = customer.idCustomer;
					ExcelSheet.Cells[row, "B"] = customer.Full_Name;
					ExcelSheet.Cells[row, "C"] = customer.Municipality;
					ExcelSheet.Cells[row, "D"] = customer.Department;
					ExcelSheet.Cells[row, "E"] = customer.Address;
					ExcelSheet.Cells[row, "F"] = customer.Phone;
					ExcelSheet.Cells[row, "G"] = customer.E_mail;
					ExcelSheet.Cells[row, "H"] = customer.Status;
					ExcelSheet.Cells[row, "I"] = customer.Remark;
				}
				
				ExcelSheet.Columns.AutoFit();
				
				ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
				
				ExcelApp.Quit();
				
				GC.Collect();
				
			} 
		}
		
		public static void ExportDevicesExcel(List<Customer_device> ListCustomersDevices)
			{
				SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Dispositivos de Clientes Registrados"};
				
				
				if(File.ShowDialog() == DialogResult.OK)
				{
					Excel.Application ExcelApp = new Excel.Application();
					Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
					Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
					Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
					DateTime DateNow = DateTime.Now;
					
					Company MyCompany = CompanyBL.GetInformationCompany();
					
					String Logo = Convert.ToString(MyCompany.Image);
					
					MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);
					
					
					ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
					ExcelSheet.Range["A1", "H1"].Merge();
					ExcelSheet.Range["A1", "H1"].Font.Bold = true;
					ExcelSheet.Range["A1", "H1"].Font.Size = 12;
					
					ExcelSheet.Range["A2", "H1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					ExcelSheet.Range["A2", "H1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A1", "H1"].RowHeight = 110;
					
					
					ExcelSheet.Cells[2, "D"] = "Listado de Dispositivos de Clientes Registrados - ["+DateNow+"]";
					ExcelSheet.Range["A2", "H2"].Merge();
					ExcelSheet.Range["A2", "H2"].Font.Bold = true;
					ExcelSheet.Range["A2", "H2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A3", "H3"].Font.Bold = true;
					ExcelSheet.Cells[3, "A"] = "MAC";
					ExcelSheet.Cells[3, "B"] = "Nombre";
					ExcelSheet.Cells[3, "C"] = "IP";
					ExcelSheet.Cells[3, "D"] = "Marca";
					ExcelSheet.Cells[3, "E"] = "Tipo";
					ExcelSheet.Cells[3, "F"] = "Version de Firmware";
					ExcelSheet.Cells[3, "G"] = "Id de Instalacion";
					ExcelSheet.Cells[3, "H"] = "Nombre del Cliente";
					
					int row = 3;
					foreach(var device in ListCustomersDevices)
					{
						row++;
						ExcelSheet.Cells[row, "A"] = device.MAC;
						ExcelSheet.Cells[row, "B"] = device.Name_Device;
						ExcelSheet.Cells[row, "C"] = device.IP_Device;
						ExcelSheet.Cells[row, "D"] = device.Brand_Device;
						ExcelSheet.Cells[row, "E"] = device.Type_Device;
						ExcelSheet.Cells[row, "F"] = device.Firmware_Device;
						ExcelSheet.Cells[row, "G"] = device.idInstalation_Device;
						ExcelSheet.Cells[row, "H"] = device.CustomerOwner;
					}
					
					ExcelSheet.Columns.AutoFit();
					
					ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
					
					ExcelApp.Quit();
				
					GC.Collect();
				} 
			}
		
		public static void ExportPointOfSaleExcel(List<Point_of_Sale> ListPointsOfSale)
		{
			SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Puntos de Venta Registrados"};
			
			
			if(File.ShowDialog() == DialogResult.OK)
			{
				Excel.Application ExcelApp = new Excel.Application();
				Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
				Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
				Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
				DateTime DateNow = DateTime.Now;
				
				Company MyCompany = CompanyBL.GetInformationCompany();
				
				String Logo = Convert.ToString(MyCompany.Image);
				
				MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);								
				
				
				ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
				ExcelSheet.Range["A1", "J1"].Merge();
				ExcelSheet.Range["A1", "J1"].Font.Bold = true;
				ExcelSheet.Range["A1", "J1"].Font.Size = 12;
				
				ExcelSheet.Range["A2", "J1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				ExcelSheet.Range["A2", "J1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A1", "J1"].RowHeight = 110;
				
				
				ExcelSheet.Cells[2, "D"] = "Listado de Puntos de Venta Registrados - ["+DateNow+"]";
				ExcelSheet.Range["A2", "J2"].Merge();
				ExcelSheet.Range["A2", "J2"].Font.Bold = true;
				ExcelSheet.Range["A2", "J2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A3", "J3"].Font.Bold = true;
				ExcelSheet.Cells[3, "A"] = "Id Punto de Venta";
				ExcelSheet.Cells[3, "B"] = "Nombre";
				ExcelSheet.Cells[3, "C"] = "Departamento";
				ExcelSheet.Cells[3, "D"] = "Municipio";
				ExcelSheet.Cells[3, "E"] = "Direccion";
				ExcelSheet.Cells[3, "F"] = "Nombre del Encargado";
				ExcelSheet.Cells[3, "G"] = "Telefono";
				ExcelSheet.Cells[3, "H"] = "E-mail";
				ExcelSheet.Cells[3, "I"] = "Cantidad de Pines Actual";
				ExcelSheet.Cells[3, "J"] = "Prefijo Actual";
				
				int row = 3;
				foreach(var pointofsale in ListPointsOfSale)
				{
					row++;
					ExcelSheet.Cells[row, "A"] = pointofsale.IdPointOfSale;
					ExcelSheet.Cells[row, "B"] = pointofsale.NamePoint;
					ExcelSheet.Cells[row, "C"] = pointofsale.Department;
					ExcelSheet.Cells[row, "D"] = pointofsale.Municipality;
					ExcelSheet.Cells[row, "E"] = pointofsale.Address;
					ExcelSheet.Cells[row, "F"] = pointofsale.NameOwner;
					ExcelSheet.Cells[row, "G"] = pointofsale.Phone;
					ExcelSheet.Cells[row, "H"] = pointofsale.E_mail;
					ExcelSheet.Cells[row, "I"] = pointofsale.AmountCodes;
					ExcelSheet.Cells[row, "J"] = pointofsale.PrefixCode;
				}
				
				ExcelSheet.Columns.AutoFit();
				
				ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
				
				ExcelApp.Quit();
				
				GC.Collect();
			} 
		} 
		
		public static void ExportSessionCustomersExcel(List<Session_Customer> ListSessionCustomers)
			{
				SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Clientes de Sesion Registrados"};
				
				
				if(File.ShowDialog() == DialogResult.OK)
				{
					Excel.Application ExcelApp = new Excel.Application();
					Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
					Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
					Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
					DateTime DateNow = DateTime.Now;
					
					Company MyCompany = CompanyBL.GetInformationCompany();
					
					String Logo = Convert.ToString(MyCompany.Image);
					
					MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);								
					
					
					ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
					ExcelSheet.Range["A1", "I1"].Merge();
					ExcelSheet.Range["A1", "I1"].Font.Bold = true;
					ExcelSheet.Range["A1", "I1"].Font.Size = 12;
					
					ExcelSheet.Range["A2", "I1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					ExcelSheet.Range["A2", "I1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A1", "I1"].RowHeight = 110;
					
					
					ExcelSheet.Cells[2, "D"] = "Listado de Clientes de Sesion Registrados - ["+DateNow+"]";
					ExcelSheet.Range["A2", "I2"].Merge();
					ExcelSheet.Range["A2", "I2"].Font.Bold = true;
					ExcelSheet.Range["A2", "I2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A3", "H3"].Font.Bold = true;
					ExcelSheet.Cells[3, "A"] = "Identificacion";
					ExcelSheet.Cells[3, "B"] = "Nombre Completo";
					ExcelSheet.Cells[3, "C"] = "Telefono";
					ExcelSheet.Cells[3, "D"] = "E-mail";
					ExcelSheet.Cells[3, "E"] = "Usuario";
					ExcelSheet.Cells[3, "F"] = "Password";
					ExcelSheet.Cells[3, "G"] = "Fecha de Adquisicion";
					ExcelSheet.Cells[3, "H"] = "Estado";
					ExcelSheet.Cells[3, "I"] = "Observaciones";
					
					int row = 3;
					foreach(var sessioncustomer in ListSessionCustomers)
					{
						row++;
						ExcelSheet.Cells[row, "A"] = sessioncustomer.idSessionCustomer;
						ExcelSheet.Cells[row, "B"] = sessioncustomer.Full_Name;
						ExcelSheet.Cells[row, "C"] = sessioncustomer.Phone;
						ExcelSheet.Cells[row, "D"] = sessioncustomer.E_mail;
						ExcelSheet.Cells[row, "E"] = sessioncustomer.User_Session;
						ExcelSheet.Cells[row, "F"] = sessioncustomer.Password_session;
						ExcelSheet.Cells[row, "G"] = sessioncustomer.Date_aquisition;
						ExcelSheet.Cells[row, "H"] = sessioncustomer.Status_session;
						ExcelSheet.Cells[row, "I"] = sessioncustomer.Remarks;
						
					}
					
					ExcelSheet.Columns.AutoFit();
					
					ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
					
					ExcelApp.Quit();
				
					GC.Collect();
				} 
			}
		
		public static void GenerateVoucherCodesForExcel(List<VoucherCode> ListVoucherCodes, String ProfileName, String Prefix)
		{
			SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "pines_"+ProfileName+"__"+Prefix};
			
			
			if(File.ShowDialog() == DialogResult.OK)
			{
				Excel.Application ExcelApp = new Excel.Application();
				Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
				Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
				Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
				DateTime DateNow = DateTime.Now;
				
				Company MyCompany = CompanyBL.GetInformationCompany();
				
				String Logo = Convert.ToString(MyCompany.Image);
				
				MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);							
				
				
				ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
				ExcelSheet.Range["A1", "H1"].Merge();
				ExcelSheet.Range["A1", "H1"].Font.Bold = true;
				ExcelSheet.Range["A1", "H1"].Font.Size = 12;
				
				ExcelSheet.Range["A2", "H1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				ExcelSheet.Range["A2", "H1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A1", "H1"].RowHeight = 110;
				ExcelSheet.Cells[2, "D"] = "Pines Generados - ["+DateNow+"]";
				ExcelSheet.Range["A2", "H2"].Merge();
				ExcelSheet.Range["A2", "H2"].Font.Bold = true;
				ExcelSheet.Range["A2", "H2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A3", "D3"].Font.Bold = true;
				ExcelSheet.Cells[3, "A"] = "Código";
				ExcelSheet.Cells[3, "B"] = "Tiempo";
				ExcelSheet.Cells[3, "C"] = "Nombre de Perfil";
				ExcelSheet.Cells[3, "D"] = "Límite de Tráfico";

				
				int row = 3;
				foreach(var vouchercode in ListVoucherCodes)
				{
					row++;
					ExcelSheet.Cells[row, "A"] = vouchercode.Prefix+vouchercode.Code;
					ExcelSheet.Cells[row, "B"] = vouchercode.Time;
					ExcelSheet.Cells[row, "C"] = vouchercode.Profile;
					ExcelSheet.Cells[row, "D"] = vouchercode.TrafficLimit;
				}
				
				ExcelSheet.Columns.AutoFit();
				
				ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
				
				ExcelApp.Quit();
				
				GC.Collect();
				
			}
		}
		
		public static void GenerateLoginTicketForExcel(List<LoginTicket> ListLoginTicket, String ProfileName, String Prefix)
		{
			SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "pines_usuario_y_contrasena_"+ProfileName+"__"+Prefix};
			
			
			if(File.ShowDialog() == DialogResult.OK)
			{
				Excel.Application ExcelApp = new Excel.Application();
				Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
				Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
				Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
				DateTime DateNow = DateTime.Now;
				
				Company MyCompany = CompanyBL.GetInformationCompany();
				
				String Logo = Convert.ToString(MyCompany.Image);
				
				MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);						
				
				
				ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
				ExcelSheet.Range["A1", "H1"].Merge();
				ExcelSheet.Range["A1", "H1"].Font.Bold = true;
				ExcelSheet.Range["A1", "H1"].Font.Size = 12;
				
				ExcelSheet.Range["A2", "H1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				ExcelSheet.Range["A2", "H1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A1", "H1"].RowHeight = 110;
				ExcelSheet.Cells[2, "D"] = "Pines de Usuario & Contraseña Generados - ["+DateNow+"]";
				ExcelSheet.Range["A2", "H2"].Merge();
				ExcelSheet.Range["A2", "H2"].Font.Bold = true;
				ExcelSheet.Range["A2", "H2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A3", "E3"].Font.Bold = true;
				ExcelSheet.Cells[3, "A"] = "Usuario";
				ExcelSheet.Cells[3, "B"] = "Contraseña";
				ExcelSheet.Cells[3, "C"] = "Tiempo";
				ExcelSheet.Cells[3, "D"] = "Nombre de Perfil";
				ExcelSheet.Cells[3, "E"] = "Límite de Tráfico";

				
				int row = 3;
				foreach(var loginticket in ListLoginTicket)
				{
					row++;
					ExcelSheet.Cells[row, "A"] = loginticket.Prefix+loginticket.User;
					ExcelSheet.Cells[row, "B"] = loginticket.Password;
					ExcelSheet.Cells[row, "C"] = loginticket.Time;
					ExcelSheet.Cells[row, "D"] = loginticket.Profile;
					ExcelSheet.Cells[row, "E"] = loginticket.TrafficLimit;
				}
				
				ExcelSheet.Columns.AutoFit();
				
				ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
				
				ExcelApp.Quit();
				
				GC.Collect();
				
			}
		}
	}
}
