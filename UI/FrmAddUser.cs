/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 22/01/2020
 * Time: 17:46
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
	/// This form it allows to add information and create a new user.
	/// </summary>
	public partial class FrmAddUser : Form
	{
		public FrmAddUser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnSaveUserClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtFisrtName.Text)) || (string.IsNullOrEmpty(txtFisrtSurname.Text)) || (string.IsNullOrEmpty(txtUsername.Text)) || (string.IsNullOrEmpty(txtPasswordUser.Text)))
			{
			
				MessageBox.Show("Algún campo marcado con (*) ha quedado vacío. Por favor, verifique que estos campos hayan sido diligenciados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				
				if(txtPasswordUser.Text == txtConfirmPassword.Text)
				{
					
					if((UserBL.validateUserExistence(txtUsername.Text, txtPasswordUser.Text)) > 0)
					{
					
						MessageBox.Show("El nombre de usuario y/o contraseña ya existen. Por favor, ingrese un nombre de usuario y contraseña diferente.", "Usuario y/o Contraseña Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);					
					
					}
					else
					{
						User pUser = new User();
				
						pUser.First_Name = txtFisrtName.Text;
						pUser.Last_Name = txtLastName.Text;
						pUser.First_Surname = txtFisrtSurname.Text;
						pUser.Last_Surname = txtLastSurname.Text;
						pUser.Name_User = txtUsername.Text;
						pUser.Password_User = txtPasswordUser.Text;
						
						if((UserBL.AddUser(pUser)) > 0)
						{
						
							MessageBox.Show("El usuario ha sido ingresado exitosamente.", "Usuario Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							FrmUsers frmusers = new FrmUsers();
							frmusers.Refresh();
							this.Close();
							
						}
						else
						{
						
							MessageBox.Show("El usuario no ha sido ingresado, ha ocurrido un error", "Usuario no Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						
					}
				
									
				
				
				}
				else
				{
				
					MessageBox.Show("Las contraseñas no son iguales. Por favor, confirme que los datos ingresados en los campos de contraseña sean iguales.", "Error de Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			
				
			}
		}
		
		
	}
}
