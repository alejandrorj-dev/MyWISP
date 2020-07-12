/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 06/03/2020
 * Time: 4:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmEditEquipment
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.RichTextBox rtbEditRemarks;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker dtpEditDateInstalation;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtEditUbication;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEditFirmwareVersion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEditFrecuency;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEditIP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEditType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEditBrand;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEditName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEditMAC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditEquipment));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.rtbEditRemarks = new System.Windows.Forms.RichTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dtpEditDateInstalation = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.txtEditUbication = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEditFirmwareVersion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEditFrecuency = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEditIP = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEditType = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEditBrand = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEditName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEditMAC = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(699, 25);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 21);
			this.label1.TabIndex = 5;
			this.label1.Text = "Actualizar Informacion de Equipo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(643, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(23, 23);
			this.btnMinimize.TabIndex = 4;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(672, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.DimGray;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(507, 418);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(60, 60);
			this.btnEdit.TabIndex = 42;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// rtbEditRemarks
			// 
			this.rtbEditRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbEditRemarks.Location = new System.Drawing.Point(429, 296);
			this.rtbEditRemarks.MaxLength = 300;
			this.rtbEditRemarks.Name = "rtbEditRemarks";
			this.rtbEditRemarks.Size = new System.Drawing.Size(217, 104);
			this.rtbEditRemarks.TabIndex = 41;
			this.rtbEditRemarks.Text = "";
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(301, 294);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(122, 23);
			this.label11.TabIndex = 40;
			this.label11.Text = "Observaciones:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpEditDateInstalation
			// 
			this.dtpEditDateInstalation.Location = new System.Drawing.Point(429, 267);
			this.dtpEditDateInstalation.Name = "dtpEditDateInstalation";
			this.dtpEditDateInstalation.Size = new System.Drawing.Size(200, 20);
			this.dtpEditDateInstalation.TabIndex = 39;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(301, 266);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(122, 23);
			this.label10.TabIndex = 38;
			this.label10.Text = "Fecha de Instalacion:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditUbication
			// 
			this.txtEditUbication.Location = new System.Drawing.Point(429, 242);
			this.txtEditUbication.MaxLength = 60;
			this.txtEditUbication.Name = "txtEditUbication";
			this.txtEditUbication.Size = new System.Drawing.Size(217, 20);
			this.txtEditUbication.TabIndex = 37;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(349, 240);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 23);
			this.label9.TabIndex = 36;
			this.label9.Text = "Ubicacion:*";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditFirmwareVersion
			// 
			this.txtEditFirmwareVersion.Location = new System.Drawing.Point(429, 216);
			this.txtEditFirmwareVersion.MaxLength = 20;
			this.txtEditFirmwareVersion.Name = "txtEditFirmwareVersion";
			this.txtEditFirmwareVersion.Size = new System.Drawing.Size(154, 20);
			this.txtEditFirmwareVersion.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(301, 214);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 23);
			this.label8.TabIndex = 34;
			this.label8.Text = "Version de Firmware:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditFrecuency
			// 
			this.txtEditFrecuency.Location = new System.Drawing.Point(429, 190);
			this.txtEditFrecuency.MaxLength = 20;
			this.txtEditFrecuency.Name = "txtEditFrecuency";
			this.txtEditFrecuency.Size = new System.Drawing.Size(81, 20);
			this.txtEditFrecuency.TabIndex = 33;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(320, 188);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 23);
			this.label7.TabIndex = 32;
			this.label7.Text = "Frecuencia:*";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditIP
			// 
			this.txtEditIP.Location = new System.Drawing.Point(429, 164);
			this.txtEditIP.MaxLength = 45;
			this.txtEditIP.Name = "txtEditIP";
			this.txtEditIP.Size = new System.Drawing.Size(127, 20);
			this.txtEditIP.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(361, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "IP:*";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditType
			// 
			this.txtEditType.Location = new System.Drawing.Point(429, 138);
			this.txtEditType.MaxLength = 30;
			this.txtEditType.Name = "txtEditType";
			this.txtEditType.Size = new System.Drawing.Size(154, 20);
			this.txtEditType.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(320, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 23);
			this.label5.TabIndex = 28;
			this.label5.Text = "Tipo de Equipo:*";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditBrand
			// 
			this.txtEditBrand.Location = new System.Drawing.Point(429, 112);
			this.txtEditBrand.MaxLength = 45;
			this.txtEditBrand.Name = "txtEditBrand";
			this.txtEditBrand.Size = new System.Drawing.Size(106, 20);
			this.txtEditBrand.TabIndex = 27;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(361, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 23);
			this.label4.TabIndex = 26;
			this.label4.Text = "Marca:*";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditName
			// 
			this.txtEditName.Location = new System.Drawing.Point(429, 86);
			this.txtEditName.MaxLength = 60;
			this.txtEditName.Name = "txtEditName";
			this.txtEditName.Size = new System.Drawing.Size(217, 20);
			this.txtEditName.TabIndex = 25;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(349, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 23);
			this.label3.TabIndex = 24;
			this.label3.Text = "Nombre:*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditMAC
			// 
			this.txtEditMAC.Location = new System.Drawing.Point(429, 60);
			this.txtEditMAC.MaxLength = 40;
			this.txtEditMAC.Name = "txtEditMAC";
			this.txtEditMAC.Size = new System.Drawing.Size(154, 20);
			this.txtEditMAC.TabIndex = 23;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(361, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 22;
			this.label2.Text = "MAC:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(282, 280);
			this.pictureBox1.TabIndex = 43;
			this.pictureBox1.TabStop = false;
			// 
			// FrmEditEquipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(699, 500);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.rtbEditRemarks);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dtpEditDateInstalation);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtEditUbication);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtEditFirmwareVersion);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtEditFrecuency);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtEditIP);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEditType);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtEditBrand);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEditName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEditMAC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmEditEquipment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Actualizar Informacion de Equipo";
			this.Load += new System.EventHandler(this.FrmEditEquipmentLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
