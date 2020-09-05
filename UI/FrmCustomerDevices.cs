/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/19/2020
 * Time: 6:02 PM
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using BL;
using EL;

namespace UI
{
	/// <summary>
	/// This form it allows to show all Customer Devices registered.
	/// </summary>
	public partial class FrmCustomerDevices : Form
	{
		DataTable DataTableResults = new DataTable();
		
		public FrmCustomerDevices()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//			
			if(VerifytxtSearchEmpty() == true)
			{
				LoadCustomerDevicesInDataTable();
			}
		}
		
		public Customer_device DeviceSelected {get; set;}
		
		void ReloadCustomerDeviceInDataTable()
		{
			DataTableResults.Clear();
			
			List<Customer_device> CustomerDevicesForDataTable = Customer_DeviceBL.GetCustomerDeviceWithCustomer();
			
			foreach(var CustomerDevice in CustomerDevicesForDataTable)
			{
				DataTableResults.Rows.Add(CustomerDevice.MAC, CustomerDevice.Name_Device, CustomerDevice.IP_Device, CustomerDevice.Brand_Device, CustomerDevice.Type_Device, CustomerDevice.Firmware_Device, CustomerDevice.idInstalation_Device, CustomerDevice.CustomerOwner);
			}
			
			
			dgvCustomerDevices.DataSource = DataTableResults;			
		}
		
		void LoadCustomerDevicesInDataTable()
		{
			
			List<Customer_device> CustomerDevicesForDataTable = Customer_DeviceBL.GetCustomerDeviceWithCustomer();
			
			DataTableResults.Columns.Add("MAC");
			DataTableResults.Columns.Add("Name_Device");
			DataTableResults.Columns.Add("IP_Device");
			DataTableResults.Columns.Add("Brand_Device");
			DataTableResults.Columns.Add("Type_Device");
			DataTableResults.Columns.Add("Firmware_Device");
			DataTableResults.Columns.Add("idInstalation_Device");
			DataTableResults.Columns.Add("CustomerOwner");
			
			foreach(var CustomerDevice in CustomerDevicesForDataTable)
			{
				DataTableResults.Rows.Add(CustomerDevice.MAC, CustomerDevice.Name_Device, CustomerDevice.IP_Device, CustomerDevice.Brand_Device, CustomerDevice.Type_Device, CustomerDevice.Firmware_Device, CustomerDevice.idInstalation_Device, CustomerDevice.CustomerOwner);
			}
			
			
			dgvCustomerDevices.DataSource = DataTableResults;
			
		}
		
		Boolean VerifytxtSearchEmpty()
		{
			if(string.IsNullOrEmpty(txtSearchCustomerDevice.Text))
			{
				return true;
			}
			
			return false;
		}
		
		void FrmCustomerDevicesLoad(object sender, EventArgs e)
		{
			//dgvCustomerDevices.DataSource = Customer_DeviceBL.GetCustomerDeviceWithCustomer();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void BtnSearchCustomerDeviceClick(object sender, EventArgs e)
		{
			DataTableResults.DefaultView.RowFilter = string.Format("MAC like '{0}%' or Name_Device = '{0}%' or IP_Device like '{0}%' or Brand_Device like '{0}%' or Type_Device like '{0}%' or FirmWare_Device like '{0}%' or idInstalation_Device like '{0}%' or CustomerOwner like '{0}%'", txtSearchCustomerDevice.Text);			
		}
		void TxtSearchCustomerDeviceKeyPress(object sender, KeyPressEventArgs e)
		{
			DataTableResults.DefaultView.RowFilter = string.Format("MAC like '{0}%' or Name_Device = '{0}%' or IP_Device like '{0}%' or Brand_Device like '{0}%' or Type_Device like '{0}%' or FirmWare_Device like '{0}%' or idInstalation_Device like '{0}%' or CustomerOwner like '{0}%'", txtSearchCustomerDevice.Text);
		}
		void BtnEditCustomerDeviceClick(object sender, EventArgs e)
		{
			if(dgvCustomerDevices.SelectedRows.Count == 1)
			{
				String MAC = Convert.ToString(dgvCustomerDevices.CurrentRow.Cells[0].Value);
				this.DeviceSelected = Customer_DeviceBL.GetCustomerDeviceByMAC(MAC);
				FrmEditCustomerDevice frmeditcustomerdevice = new FrmEditCustomerDevice();
				frmeditcustomerdevice.DeviceSelectedForEdit = DeviceSelected;
				frmeditcustomerdevice.ShowDialog();				
			}
			else
			{
				MessageBox.Show("Debe seleccionar un dispositivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void BtnExportExcelClick(object sender, EventArgs e)
		{
			List<Customer_device> ListCustomersDevicesWithCustomer = new List<Customer_device>();
			ListCustomersDevicesWithCustomer = Customer_DeviceBL.GetCustomerDeviceWithCustomer();
			ExcelReport.ExportDevicesExcel(ListCustomersDevicesWithCustomer);
		}
		
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			ReloadCustomerDeviceInDataTable();
		}

	}
}
