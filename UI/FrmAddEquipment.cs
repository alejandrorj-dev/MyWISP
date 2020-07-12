/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 06/03/2020
 * Time: 2:38 p. m.
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
	/// This form it allows to add information about Equipment.
	/// </summary>
	public partial class FrmAddEquipment : Form
	{
		public FrmAddEquipment()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtMAC.Text)) || (string.IsNullOrEmpty(txtName.Text)) || (string.IsNullOrEmpty(txtBrand.Text)) || (string.IsNullOrEmpty(txtType.Text)) || (string.IsNullOrEmpty(txtFrecuency.Text)) || (string.IsNullOrEmpty(txtUbication.Text)))
			{
				MessageBox.Show("Algunos campos requeridos se encuentran vacios. Por favor, verifique que los campos marcados con (*) se encuentren llenos.", "Error de Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Equipment MyNewEquipment = new Equipment();
				MyNewEquipment.MAC = txtMAC.Text;
				MyNewEquipment.Name = txtName.Text;
				MyNewEquipment.Brand = txtBrand.Text;
				MyNewEquipment.Type = txtType.Text;
				MyNewEquipment.IP = txtIP.Text;
				MyNewEquipment.Frecuency = txtFrecuency.Text;
				MyNewEquipment.Firmware_version = txtFirmwareVersion.Text;
				MyNewEquipment.Ubication = txtUbication.Text;
				MyNewEquipment.Date_instalation = dtpDateInstalation.Value.Year + "/" + dtpDateInstalation.Value.Month + "/" + dtpDateInstalation.Value.Day;
				MyNewEquipment.Remarks = rtbRemarks.Text;
				
				if(EquipmentBL.AddEqupment(MyNewEquipment) > 0)
				{
					MessageBox.Show("El equipo ha sido registrado correctamente.", "Equipo Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Cleaner();
				}
				else
				{
					MessageBox.Show("El equipo aun no ha sido registrado, ha ocurrido un error.", "Equipo no Registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		void Cleaner()
		{
			txtMAC.Clear();
			txtName.Clear();
			txtBrand.Clear();
			txtType.Clear();
			txtIP.Clear();
			txtFrecuency.Clear();
			txtFirmwareVersion.Clear();
			txtUbication.Clear();
			dtpDateInstalation.ResetText();
			rtbRemarks.Clear();
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
