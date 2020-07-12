/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/25/2020
 * Time: 3:59 PM
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
	/// This form it allows to add information about Session Customer.
	/// </summary>
	public partial class FrmAddSessionCustomer : Form
	{
		public FrmAddSessionCustomer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSaveSessionCustomerClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtIdSessionCustomer.Text)) || (string.IsNullOrEmpty(txtFullNameSessionCustomer.Text)) || (string.IsNullOrEmpty(txtUserSessionCustomer.Text)) || (string.IsNullOrEmpty(txtPasswordSessionCustomer.Text)) || (string.IsNullOrEmpty(cboStatusSessionCustomer.Text)))
			{
				MessageBox.Show("Algun campo requerido se encuentra vacio. Por favor, verifique que los campos marcados con (*) se encuentren llenos.", "Error al Agregar Cliente de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Session_Customer NewSessionCustomer = new Session_Customer();
				NewSessionCustomer.idSessionCustomer = txtIdSessionCustomer.Text;
				NewSessionCustomer.Full_Name = txtFullNameSessionCustomer.Text;
				NewSessionCustomer.Phone = txtPhoneSessionCustomer.Text;
				NewSessionCustomer.E_mail = txtEmailSessionCustomer.Text;
				NewSessionCustomer.User_Session = txtUserSessionCustomer.Text;
				NewSessionCustomer.Password_session = txtPasswordSessionCustomer.Text;
				NewSessionCustomer.Date_aquisition = dtpDateAquisition.Value.Year + "/" + dtpDateAquisition.Value.Month + "/" + dtpDateAquisition.Value.Day;
				NewSessionCustomer.Status_session = cboStatusSessionCustomer.Text;
				NewSessionCustomer.Remarks = rtbRemarksSessionCustomer.Text;
				
				if(Session_CustomerBL.AddSessionCustomer(NewSessionCustomer) > 0)
				{
					MessageBox.Show("El cliente de sesion ha sido agregado exitosamente", "Cliente de Sesion Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Cleaner();
				}
				else
				{
					MessageBox.Show("El cliente de sesion aun no ha sido agregado, ha ocurrido un error.", "Error al Agregar Cliente de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}

		void FrmAddSessionCustomerLoad(object sender, EventArgs e)
		{
			cboStatusSessionCustomer.Items.Add("Activo");
			cboStatusSessionCustomer.Items.Add("Suspendido");
			cboStatusSessionCustomer.Items.Add("Retirado");
			cboStatusSessionCustomer.Items.Add("En mora");
		}
		
		void Cleaner()
		{
			txtIdSessionCustomer.Clear();
			txtFullNameSessionCustomer.Clear();
			txtPhoneSessionCustomer.Clear();
			txtEmailSessionCustomer.Clear();
			txtUserSessionCustomer.Clear();
			txtPasswordSessionCustomer.Clear();
			dtpDateAquisition.ResetText();
			cboStatusSessionCustomer.ResetText();
			rtbRemarksSessionCustomer.Clear();
		}

	}
}
