/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/26/2020
 * Time: 5:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmAddPointOfSale
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNamePointOfSale;
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
		private System.Windows.Forms.Button btnSavePointOfSale;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtAmountCodes;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.Label label10;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPointOfSale));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNamePointOfSale = new System.Windows.Forms.TextBox();
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
			this.btnSavePointOfSale = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtAmountCodes = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
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
			this.panel1.Size = new System.Drawing.Size(784, 27);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Agregar Punto de Venta";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(758, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(423, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNamePointOfSale
			// 
			this.txtNamePointOfSale.Location = new System.Drawing.Point(529, 86);
			this.txtNamePointOfSale.MaxLength = 45;
			this.txtNamePointOfSale.Name = "txtNamePointOfSale";
			this.txtNamePointOfSale.Size = new System.Drawing.Size(204, 20);
			this.txtNamePointOfSale.TabIndex = 3;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(529, 112);
			this.txtDepartment.MaxLength = 45;
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(121, 20);
			this.txtDepartment.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(423, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Departamento:*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMunicipality
			// 
			this.txtMunicipality.Location = new System.Drawing.Point(529, 138);
			this.txtMunicipality.MaxLength = 45;
			this.txtMunicipality.Name = "txtMunicipality";
			this.txtMunicipality.Size = new System.Drawing.Size(121, 20);
			this.txtMunicipality.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(423, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ciudad/Municipio:*";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(529, 164);
			this.txtAddress.MaxLength = 100;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(204, 20);
			this.txtAddress.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(423, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Direccion:*";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNameOwner
			// 
			this.txtNameOwner.Location = new System.Drawing.Point(529, 190);
			this.txtNameOwner.MaxLength = 200;
			this.txtNameOwner.Name = "txtNameOwner";
			this.txtNameOwner.Size = new System.Drawing.Size(204, 20);
			this.txtNameOwner.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(378, 188);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Nombre del Encargado:*";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(529, 216);
			this.txtPhone.MaxLength = 20;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(105, 20);
			this.txtPhone.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(423, 214);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Telefono:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(529, 242);
			this.txtEmail.MaxLength = 50;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(204, 20);
			this.txtEmail.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(423, 240);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "E-mail:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSavePointOfSale
			// 
			this.btnSavePointOfSale.BackColor = System.Drawing.Color.DarkCyan;
			this.btnSavePointOfSale.FlatAppearance.BorderSize = 0;
			this.btnSavePointOfSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSavePointOfSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePointOfSale.Image")));
			this.btnSavePointOfSale.Location = new System.Drawing.Point(590, 361);
			this.btnSavePointOfSale.Name = "btnSavePointOfSale";
			this.btnSavePointOfSale.Size = new System.Drawing.Size(60, 60);
			this.btnSavePointOfSale.TabIndex = 16;
			this.btnSavePointOfSale.UseVisualStyleBackColor = false;
			this.btnSavePointOfSale.Click += new System.EventHandler(this.BtnSavePointOfSaleClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(90, 54);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(259, 259);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// txtAmountCodes
			// 
			this.txtAmountCodes.Location = new System.Drawing.Point(529, 268);
			this.txtAmountCodes.MaxLength = 10;
			this.txtAmountCodes.Name = "txtAmountCodes";
			this.txtAmountCodes.Size = new System.Drawing.Size(74, 20);
			this.txtAmountCodes.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(390, 266);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(133, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Cantidad de Pines Actual:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPrefix
			// 
			this.txtPrefix.Location = new System.Drawing.Point(529, 294);
			this.txtPrefix.MaxLength = 10;
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(74, 20);
			this.txtPrefix.TabIndex = 21;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(423, 292);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 20;
			this.label10.Text = "Prefijo:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmAddPointOfSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(784, 445);
			this.Controls.Add(this.txtPrefix);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtAmountCodes);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnSavePointOfSale);
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
			this.Controls.Add(this.txtNamePointOfSale);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAddPointOfSale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Punto de Venta";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
