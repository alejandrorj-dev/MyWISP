/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 22/01/2020
 * Time: 17:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmAddUser
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFisrtName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFisrtSurname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLastSurname;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPasswordUser;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnSaveUser;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label label8;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFisrtName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFisrtSurname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLastSurname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPasswordUser = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSaveUser = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(786, 26);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Agregar Usuario";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(761, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(25, 25);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(49, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(251, 279);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(452, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Primer Nombre: *";
			// 
			// txtFisrtName
			// 
			this.txtFisrtName.Location = new System.Drawing.Point(542, 74);
			this.txtFisrtName.MaxLength = 45;
			this.txtFisrtName.Name = "txtFisrtName";
			this.txtFisrtName.Size = new System.Drawing.Size(173, 20);
			this.txtFisrtName.TabIndex = 3;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(542, 110);
			this.txtLastName.MaxLength = 45;
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(173, 20);
			this.txtLastName.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(440, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Segundo Nombre:";
			// 
			// txtFisrtSurname
			// 
			this.txtFisrtSurname.Location = new System.Drawing.Point(542, 145);
			this.txtFisrtSurname.MaxLength = 45;
			this.txtFisrtSurname.Name = "txtFisrtSurname";
			this.txtFisrtSurname.Size = new System.Drawing.Size(173, 20);
			this.txtFisrtSurname.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(454, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Primer Apellido: *";
			// 
			// txtLastSurname
			// 
			this.txtLastSurname.Location = new System.Drawing.Point(542, 180);
			this.txtLastSurname.MaxLength = 45;
			this.txtLastSurname.Name = "txtLastSurname";
			this.txtLastSurname.Size = new System.Drawing.Size(173, 20);
			this.txtLastSurname.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(442, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Segundo Apellido:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(542, 215);
			this.txtUsername.MaxLength = 45;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(173, 20);
			this.txtUsername.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(434, 218);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Nombre de Usuario: *";
			// 
			// txtPasswordUser
			// 
			this.txtPasswordUser.Location = new System.Drawing.Point(542, 251);
			this.txtPasswordUser.MaxLength = 45;
			this.txtPasswordUser.Name = "txtPasswordUser";
			this.txtPasswordUser.PasswordChar = '*';
			this.txtPasswordUser.Size = new System.Drawing.Size(173, 20);
			this.txtPasswordUser.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(470, 254);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Contraseña: *";
			// 
			// btnSaveUser
			// 
			this.btnSaveUser.BackColor = System.Drawing.Color.Green;
			this.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveUser.FlatAppearance.BorderSize = 0;
			this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Image")));
			this.btnSaveUser.Location = new System.Drawing.Point(568, 342);
			this.btnSaveUser.Name = "btnSaveUser";
			this.btnSaveUser.Size = new System.Drawing.Size(60, 60);
			this.btnSaveUser.TabIndex = 14;
			this.btnSaveUser.UseVisualStyleBackColor = false;
			this.btnSaveUser.Click += new System.EventHandler(this.BtnSaveUserClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(634, 342);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(60, 60);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(542, 286);
			this.txtConfirmPassword.MaxLength = 45;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(173, 20);
			this.txtConfirmPassword.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(422, 289);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 20);
			this.label8.TabIndex = 16;
			this.label8.Text = "Confirmar Contraseña: *";
			// 
			// FrmAddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(786, 429);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveUser);
			this.Controls.Add(this.txtPasswordUser);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtLastSurname);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFisrtSurname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFisrtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAddUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Usuario";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
