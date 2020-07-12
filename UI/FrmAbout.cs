/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 11/03/2020
 * Time: 5:36 p. m.
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
	/// <summary>
	/// This form it allows to show information about the application.
	/// </summary>
	public partial class FrmAbout : Form
	{
		public FrmAbout()
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
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
