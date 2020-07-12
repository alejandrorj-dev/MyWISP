/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/21/2020
 * Time: 5:14 PM
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BL;
using EL;


namespace UI
{
	/// <summary>
	/// This form it allows to update information about Customer Device.
	/// </summary>
	public partial class FrmEditCustomerDevice : Form
	{
		public FrmEditCustomerDevice()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Customer_device DeviceSelectedForEdit {get; set;}
		
		void FrmEditCustomerDeviceLoad(object sender, EventArgs e)
		{
			if(DeviceSelectedForEdit != null)
			{
				txtEditMAC.Text = DeviceSelectedForEdit.MAC;
				txtEditNameDevice.Text = DeviceSelectedForEdit.Name_Device;
				txtEditIPAddress.Text = DeviceSelectedForEdit.IP_Device;
				txtEditBrand.Text = DeviceSelectedForEdit.Brand_Device;
				txtEditType.Text = DeviceSelectedForEdit.Type_Device;
				txtEditFirmwareVersion.Text = DeviceSelectedForEdit.Firmware_Device;
			}
		}
		void BtnEditCustomerDeviceInfoClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtEditMAC.Text)) || (string.IsNullOrEmpty(txtEditNameDevice.Text)) || (string.IsNullOrEmpty(txtEditIPAddress.Text)) || (string.IsNullOrEmpty(txtEditBrand.Text)) || (string.IsNullOrEmpty(txtEditType.Text)))
			{
				MessageBox.Show("Algun campo requerido se encuentra vacio. Por favor, verifique que los campos marcados con (*) se encuentren llenos.", "Error Al Actualizar Informacion de Dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Customer_device CustomerDeviceEdit = new Customer_device();
				CustomerDeviceEdit.MAC = txtEditMAC.Text;
				CustomerDeviceEdit.Name_Device = txtEditNameDevice.Text;
				CustomerDeviceEdit.IP_Device = txtEditIPAddress.Text;
				CustomerDeviceEdit.Brand_Device = txtEditBrand.Text;
				CustomerDeviceEdit.Type_Device = txtEditType.Text;
				CustomerDeviceEdit.Firmware_Device = txtEditFirmwareVersion.Text;
				
				String MAC = Convert.ToString(DeviceSelectedForEdit.MAC);
				if(Customer_DeviceBL.EditCustomerDevice(CustomerDeviceEdit, MAC) > 0)
				{
					MessageBox.Show("La informacion del dispositivo ha sido actualizada correctamente.", "Informacion Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("La informacion del dispositivo no ha sido actualizada, ha ocurrido un error.", "Error al Actualizar Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
