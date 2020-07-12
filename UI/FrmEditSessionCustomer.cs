/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/25/2020
 * Time: 6:04 PM
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
	/// This form it allows to update information about Session Customer.
	/// </summary>
	public partial class FrmEditSessionCustomer : Form
	{
		public FrmEditSessionCustomer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Session_Customer SessionCustomerChosen {get; set;}
		
		void FrmEditSessionCustomerLoad(object sender, EventArgs e)
		{
			if(SessionCustomerChosen != null)
			{
				txtIdSessionCustomer.Text = SessionCustomerChosen.idSessionCustomer;
				txtFullNameSC.Text = SessionCustomerChosen.Full_Name;
				txtPhoneSC.Text = SessionCustomerChosen.Phone;
				txtEmailSC.Text = SessionCustomerChosen.E_mail;
				txtUserSC.Text = SessionCustomerChosen.User_Session;
				txtPasswordSC.Text = SessionCustomerChosen.Password_session;
				dtpDateAquisitionSC.Text = SessionCustomerChosen.Date_aquisition;
				cboStatusSC.Text = SessionCustomerChosen.Status_session;
				rtbRemarksSC.Text = SessionCustomerChosen.Remarks;				
			}
			
			cboStatusSC.Items.Add("Activo");
			cboStatusSC.Items.Add("Suspendido");
			cboStatusSC.Items.Add("Retirado");
			cboStatusSC.Items.Add("En mora");
		}
		void BtnEditSessionCustomerClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtIdSessionCustomer.Text)) || (string.IsNullOrEmpty(txtFullNameSC.Text)) || (string.IsNullOrEmpty(txtUserSC.Text)) || (string.IsNullOrEmpty(txtPasswordSC.Text)) || (string.IsNullOrEmpty(cboStatusSC.Text)))
			{
				MessageBox.Show("Algun campo requerido se encuentra vacio. Por favor, verifique que todos los campos marcados con (*) se encuentren llenos.", "Error al Actualizar Cliente de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Session_Customer SessionCustomerUpdated = new Session_Customer();
				SessionCustomerUpdated.idSessionCustomer = txtIdSessionCustomer.Text;
				SessionCustomerUpdated.Full_Name = txtFullNameSC.Text;
				SessionCustomerUpdated.Phone = txtPhoneSC.Text;
				SessionCustomerUpdated.E_mail = txtEmailSC.Text;
				SessionCustomerUpdated.User_Session = txtUserSC.Text;
				SessionCustomerUpdated.Password_session = txtPasswordSC.Text;
				SessionCustomerUpdated.Date_aquisition = dtpDateAquisitionSC.Value.Year + "/" + dtpDateAquisitionSC.Value.Month + "/" + dtpDateAquisitionSC.Value.Day;
				SessionCustomerUpdated.Status_session = cboStatusSC.Text;
				SessionCustomerUpdated.Remarks = rtbRemarksSC.Text;
				
				String idSessionCustomer = Convert.ToString(SessionCustomerChosen.idSessionCustomer);
				if(Session_CustomerBL.EditSessionCustomer(SessionCustomerUpdated, idSessionCustomer) > 0)
				{
					MessageBox.Show("El cliente de sesion ha sido actualizado exitosamente.", "Cliente de sesion Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("El cliente de sesion aun no ha sido actualizado, ha ocurrido un error.", "Cliente de Sesion no Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
