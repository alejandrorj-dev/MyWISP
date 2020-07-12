/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 23/01/2020
 * Time: 9:18
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
	/// This form it allows validate the user for access to the application.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public User CurrentUser {get; set;}
		
		void BtnAcceptClick(object sender, EventArgs e)
		{
						
			
			if(UserBL.ValidateUser(txtUsername.Text, txtPassword.Text) > 0)
			{
				CurrentUser = UserBL.GetCurrentUser(txtUsername.Text, txtPassword.Text);
				MainForm mainform = new MainForm();
				mainform.CurrentUser = this.CurrentUser;
				this.Hide();
				mainform.Show();
			}
			else
			{
			
				MessageBox.Show("Usuario no registrado.", "Usuario Inactivo", MessageBoxButtons.OK, MessageBoxIcon.Error);											
			}
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
