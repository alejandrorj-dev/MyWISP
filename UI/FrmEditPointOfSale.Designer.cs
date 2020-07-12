/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/27/2020
 * Time: 3:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmEditPointOfSale
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNamePoint;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMunicipality;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNameOwner;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtIdPOS;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtAmountCodes;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditPointOfSale));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNamePoint = new System.Windows.Forms.TextBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMunicipality = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNameOwner = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtIdPOS = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtAmountCodes = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 26);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Actualizar Informacion de Punto de Venta";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(759, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(429, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNamePoint
			// 
			this.txtNamePoint.Location = new System.Drawing.Point(535, 96);
			this.txtNamePoint.Name = "txtNamePoint";
			this.txtNamePoint.Size = new System.Drawing.Size(195, 20);
			this.txtNamePoint.TabIndex = 3;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(535, 122);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(142, 20);
			this.txtDepartment.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(429, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Departamento:*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMunicipality
			// 
			this.txtMunicipality.Location = new System.Drawing.Point(535, 148);
			this.txtMunicipality.Name = "txtMunicipality";
			this.txtMunicipality.Size = new System.Drawing.Size(109, 20);
			this.txtMunicipality.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(429, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Municipio:*";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(535, 174);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(195, 20);
			this.txtAddress.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(429, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Direccion:*";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNameOwner
			// 
			this.txtNameOwner.Location = new System.Drawing.Point(535, 200);
			this.txtNameOwner.Name = "txtNameOwner";
			this.txtNameOwner.Size = new System.Drawing.Size(195, 20);
			this.txtNameOwner.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(353, 198);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Nombre del Encargado:*";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(535, 226);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(119, 20);
			this.txtPhone.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(429, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Telefono:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(535, 252);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(195, 20);
			this.txtEmail.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(429, 250);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "E-mail:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.Location = new System.Drawing.Point(594, 360);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(60, 60);
			this.btnUpdate.TabIndex = 16;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(67, 50);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(247, 245);
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// txtIdPOS
			// 
			this.txtIdPOS.Enabled = false;
			this.txtIdPOS.Location = new System.Drawing.Point(535, 70);
			this.txtIdPOS.Name = "txtIdPOS";
			this.txtIdPOS.Size = new System.Drawing.Size(38, 20);
			this.txtIdPOS.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(427, 68);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Id:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPrefix
			// 
			this.txtPrefix.Location = new System.Drawing.Point(535, 304);
			this.txtPrefix.MaxLength = 10;
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(74, 20);
			this.txtPrefix.TabIndex = 25;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(429, 302);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "Prefijo:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAmountCodes
			// 
			this.txtAmountCodes.Location = new System.Drawing.Point(535, 278);
			this.txtAmountCodes.MaxLength = 10;
			this.txtAmountCodes.Name = "txtAmountCodes";
			this.txtAmountCodes.Size = new System.Drawing.Size(74, 20);
			this.txtAmountCodes.TabIndex = 23;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(396, 276);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "Cantidad de Pines Actual:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmEditPointOfSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(784, 445);
			this.Controls.Add(this.txtPrefix);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtAmountCodes);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtIdPOS);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtNameOwner);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtMunicipality);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDepartment);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNamePoint);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmEditPointOfSale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Actualizar Informacion de Punto de Venta";
			this.Load += new System.EventHandler(this.FrmEditPointOfSaleLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
