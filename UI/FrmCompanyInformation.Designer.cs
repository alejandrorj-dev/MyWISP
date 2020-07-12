/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/14/2020
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmCompanyInformation
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNIT;
		private System.Windows.Forms.TextBox txtNameCompany;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtWebsite;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnAttachImg;
		private System.Windows.Forms.PictureBox pcbLogoCompany;
		private System.Windows.Forms.Button btnUpdateCompany;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label11;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyInformation));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNIT = new System.Windows.Forms.TextBox();
			this.txtNameCompany = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtWebsite = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnAttachImg = new System.Windows.Forms.Button();
			this.pcbLogoCompany = new System.Windows.Forms.PictureBox();
			this.btnUpdateCompany = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbLogoCompany)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Purple;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(857, 25);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Informacion de la Empresa";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(830, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(573, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NIT:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNIT
			// 
			this.txtNIT.Location = new System.Drawing.Point(614, 86);
			this.txtNIT.MaxLength = 20;
			this.txtNIT.Name = "txtNIT";
			this.txtNIT.Size = new System.Drawing.Size(155, 20);
			this.txtNIT.TabIndex = 2;
			// 
			// txtNameCompany
			// 
			this.txtNameCompany.Location = new System.Drawing.Point(614, 114);
			this.txtNameCompany.MaxLength = 200;
			this.txtNameCompany.Name = "txtNameCompany";
			this.txtNameCompany.Size = new System.Drawing.Size(212, 20);
			this.txtNameCompany.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(480, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nombre de la empresa:*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(614, 144);
			this.txtCity.MaxLength = 20;
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(102, 20);
			this.txtCity.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(495, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Ciudad/Municipio:*";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(614, 172);
			this.txtDepartment.MaxLength = 45;
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(161, 20);
			this.txtDepartment.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(508, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Departamento:*";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(614, 200);
			this.txtAddress.MaxLength = 100;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(161, 20);
			this.txtAddress.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(537, 198);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Direccion:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(614, 230);
			this.txtPhone.MaxLength = 20;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(161, 20);
			this.txtPhone.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(537, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Telefono:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(614, 259);
			this.txtEmail.MaxLength = 100;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(161, 20);
			this.txtEmail.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(537, 257);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "E-mail:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtWebsite
			// 
			this.txtWebsite.Location = new System.Drawing.Point(614, 288);
			this.txtWebsite.Name = "txtWebsite";
			this.txtWebsite.Size = new System.Drawing.Size(161, 20);
			this.txtWebsite.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(537, 286);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "Website:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(573, 315);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(36, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "Logo:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAttachImg
			// 
			this.btnAttachImg.BackColor = System.Drawing.Color.DarkCyan;
			this.btnAttachImg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAttachImg.FlatAppearance.BorderSize = 0;
			this.btnAttachImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAttachImg.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachImg.Image")));
			this.btnAttachImg.Location = new System.Drawing.Point(615, 318);
			this.btnAttachImg.Name = "btnAttachImg";
			this.btnAttachImg.Size = new System.Drawing.Size(20, 20);
			this.btnAttachImg.TabIndex = 18;
			this.btnAttachImg.UseVisualStyleBackColor = false;
			this.btnAttachImg.Click += new System.EventHandler(this.BtnAttachImgClick);
			// 
			// pcbLogoCompany
			// 
			this.pcbLogoCompany.BackColor = System.Drawing.Color.White;
			this.pcbLogoCompany.Location = new System.Drawing.Point(650, 318);
			this.pcbLogoCompany.Name = "pcbLogoCompany";
			this.pcbLogoCompany.Size = new System.Drawing.Size(150, 100);
			this.pcbLogoCompany.TabIndex = 19;
			this.pcbLogoCompany.TabStop = false;
			// 
			// btnUpdateCompany
			// 
			this.btnUpdateCompany.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.btnUpdateCompany.FlatAppearance.BorderSize = 0;
			this.btnUpdateCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCompany.Image")));
			this.btnUpdateCompany.Location = new System.Drawing.Point(634, 483);
			this.btnUpdateCompany.Name = "btnUpdateCompany";
			this.btnUpdateCompany.Size = new System.Drawing.Size(60, 60);
			this.btnUpdateCompany.TabIndex = 21;
			this.btnUpdateCompany.UseVisualStyleBackColor = false;
			this.btnUpdateCompany.Click += new System.EventHandler(this.BtnUpdateCompanyClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(78, 71);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(371, 334);
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(654, 421);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(91, 23);
			this.label11.TabIndex = 23;
			this.label11.Text = "max. 150x100 px";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmCompanyInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkViolet;
			this.ClientSize = new System.Drawing.Size(857, 587);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnUpdateCompany);
			this.Controls.Add(this.pcbLogoCompany);
			this.Controls.Add(this.btnAttachImg);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtWebsite);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDepartment);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNameCompany);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNIT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmCompanyInformation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Informacion de la Empresa";
			this.Load += new System.EventHandler(this.FrmCompanyInformationLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcbLogoCompany)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
