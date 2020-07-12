/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 06/03/2020
 * Time: 4:36 p. m.
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using EL;
using BL;

namespace UI
{
	/// <summary>
	/// This form it allows to update information about Equipment.
	/// </summary>
	public partial class FrmEditEquipment : Form
	{
		public FrmEditEquipment()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Equipment EquipmentChosen {get; set;}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtEditMAC.Text)) || (string.IsNullOrEmpty(txtEditName.Text)) || (string.IsNullOrEmpty(txtEditBrand.Text)) || (string.IsNullOrEmpty(txtEditIP.Text)) || (string.IsNullOrEmpty(txtEditFrecuency.Text)) || (string.IsNullOrEmpty(txtEditUbication.Text)))
			{
				MessageBox.Show("Algun campo requerido se encuentra vacio. Por favor, verifique que los campos marcados con (*) se encuentren llenos.", "Error de Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Equipment EditEquipment = new Equipment();
				EditEquipment.MAC = txtEditMAC.Text;
				EditEquipment.Name = txtEditName.Text;
				EditEquipment.Brand = txtEditBrand.Text;
				EditEquipment.Type = txtEditType.Text;
				EditEquipment.IP = txtEditIP.Text;
				EditEquipment.Frecuency = txtEditFrecuency.Text;
				EditEquipment.Firmware_version = txtEditFirmwareVersion.Text;
				EditEquipment.Ubication = txtEditUbication.Text;
				EditEquipment.Date_instalation = dtpEditDateInstalation.Value.Year + "/" + dtpEditDateInstalation.Value.Month + "/" + dtpEditDateInstalation.Value.Day;
				EditEquipment.Remarks = rtbEditRemarks.Text;
				
				String idEquipment = Convert.ToString(EquipmentChosen.MAC);
				if(EquipmentBL.EditEquipment(EditEquipment, idEquipment) > 0)
				{
					MessageBox.Show("La informacion del equipo ha sido actualizada correctamente.", "Actualizacion de Equipo Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("La informacion del equipo aun no ha sido actualizada, ha ocurrido un error", "Informacion del Equipo no Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void FrmEditEquipmentLoad(object sender, EventArgs e)
		{
			if(EquipmentChosen != null)
			{
				txtEditMAC.Text = EquipmentChosen.MAC;
				txtEditName.Text = EquipmentChosen.Name;
				txtEditBrand.Text = EquipmentChosen.Brand;
				txtEditType.Text = EquipmentChosen.Type;
				txtEditIP.Text = EquipmentChosen.IP;
				txtEditFrecuency.Text = EquipmentChosen.Frecuency;
				txtEditFirmwareVersion.Text = EquipmentChosen.Firmware_version;
				txtEditUbication.Text = EquipmentChosen.Ubication;
				dtpEditDateInstalation.Text = EquipmentChosen.Date_instalation;
				rtbEditRemarks.Text = EquipmentChosen.Remarks;
			}
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
