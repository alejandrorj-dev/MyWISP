/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 06/03/2020
 * Time: 2:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmAddEquipment
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMAC;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBrand;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFrecuency;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtFirmwareVersion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtUbication;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpDateInstalation;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.RichTextBox rtbRemarks;
		private System.Windows.Forms.Button btnSave;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEquipment));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMAC = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBrand = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtType = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFrecuency = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFirmwareVersion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUbication = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpDateInstalation = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.rtbRemarks = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
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
			this.panel1.Size = new System.Drawing.Size(715, 26);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Agregar un Nuevo Equipo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(661, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(23, 23);
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(690, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(371, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "MAC:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMAC
			// 
			this.txtMAC.Location = new System.Drawing.Point(439, 62);
			this.txtMAC.MaxLength = 40;
			this.txtMAC.Name = "txtMAC";
			this.txtMAC.Size = new System.Drawing.Size(154, 20);
			this.txtMAC.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(439, 88);
			this.txtName.MaxLength = 60;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(217, 20);
			this.txtName.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(359, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nombre:*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBrand
			// 
			this.txtBrand.Location = new System.Drawing.Point(439, 114);
			this.txtBrand.MaxLength = 45;
			this.txtBrand.Name = "txtBrand";
			this.txtBrand.Size = new System.Drawing.Size(106, 20);
			this.txtBrand.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(371, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Marca:*";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(439, 140);
			this.txtType.MaxLength = 30;
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(154, 20);
			this.txtType.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(330, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Tipo de Equipo:*";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(439, 166);
			this.txtIP.MaxLength = 45;
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(127, 20);
			this.txtIP.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(371, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "IP:*";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFrecuency
			// 
			this.txtFrecuency.Location = new System.Drawing.Point(439, 192);
			this.txtFrecuency.MaxLength = 20;
			this.txtFrecuency.Name = "txtFrecuency";
			this.txtFrecuency.Size = new System.Drawing.Size(81, 20);
			this.txtFrecuency.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(330, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Frecuencia:*";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFirmwareVersion
			// 
			this.txtFirmwareVersion.Location = new System.Drawing.Point(439, 218);
			this.txtFirmwareVersion.MaxLength = 20;
			this.txtFirmwareVersion.Name = "txtFirmwareVersion";
			this.txtFirmwareVersion.Size = new System.Drawing.Size(154, 20);
			this.txtFirmwareVersion.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(311, 216);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Version de Firmware:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUbication
			// 
			this.txtUbication.Location = new System.Drawing.Point(439, 244);
			this.txtUbication.MaxLength = 60;
			this.txtUbication.Name = "txtUbication";
			this.txtUbication.Size = new System.Drawing.Size(217, 20);
			this.txtUbication.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(359, 242);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "Ubicacion:*";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(311, 268);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(122, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "Fecha de Instalacion:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDateInstalation
			// 
			this.dtpDateInstalation.Location = new System.Drawing.Point(439, 269);
			this.dtpDateInstalation.Name = "dtpDateInstalation";
			this.dtpDateInstalation.Size = new System.Drawing.Size(200, 20);
			this.dtpDateInstalation.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(311, 296);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(122, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "Observaciones:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbRemarks
			// 
			this.rtbRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbRemarks.Location = new System.Drawing.Point(439, 298);
			this.rtbRemarks.MaxLength = 300;
			this.rtbRemarks.Name = "rtbRemarks";
			this.rtbRemarks.Size = new System.Drawing.Size(217, 104);
			this.rtbRemarks.TabIndex = 20;
			this.rtbRemarks.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.DimGray;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.Location = new System.Drawing.Point(517, 418);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(60, 60);
			this.btnSave.TabIndex = 21;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(284, 276);
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// FrmAddEquipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(715, 501);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.rtbRemarks);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dtpDateInstalation);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtUbication);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtFirmwareVersion);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtFrecuency);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtBrand);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMAC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAddEquipment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar un Nuevo Equipo";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
