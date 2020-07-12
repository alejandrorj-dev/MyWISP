/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/25/2020
 * Time: 6:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmEditSessionCustomer
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIdSessionCustomer;
		private System.Windows.Forms.TextBox txtFullNameSC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPhoneSC;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmailSC;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUserSC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPasswordSC;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpDateAquisitionSC;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cboStatusSC;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RichTextBox rtbRemarksSC;
		private System.Windows.Forms.Button btnEditSessionCustomer;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditSessionCustomer));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIdSessionCustomer = new System.Windows.Forms.TextBox();
			this.txtFullNameSC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhoneSC = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmailSC = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUserSC = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPasswordSC = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dtpDateAquisitionSC = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.cboStatusSC = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.rtbRemarksSC = new System.Windows.Forms.RichTextBox();
			this.btnEditSessionCustomer = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(680, 27);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Actualizar Cliente de Sesion";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(654, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(334, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Identificacion:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIdSessionCustomer
			// 
			this.txtIdSessionCustomer.Location = new System.Drawing.Point(441, 62);
			this.txtIdSessionCustomer.MaxLength = 20;
			this.txtIdSessionCustomer.Name = "txtIdSessionCustomer";
			this.txtIdSessionCustomer.Size = new System.Drawing.Size(121, 20);
			this.txtIdSessionCustomer.TabIndex = 2;
			// 
			// txtFullNameSC
			// 
			this.txtFullNameSC.Location = new System.Drawing.Point(441, 95);
			this.txtFullNameSC.MaxLength = 200;
			this.txtFullNameSC.Name = "txtFullNameSC";
			this.txtFullNameSC.Size = new System.Drawing.Size(172, 20);
			this.txtFullNameSC.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(307, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nombre Completo:*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhoneSC
			// 
			this.txtPhoneSC.Location = new System.Drawing.Point(441, 130);
			this.txtPhoneSC.MaxLength = 20;
			this.txtPhoneSC.Name = "txtPhoneSC";
			this.txtPhoneSC.Size = new System.Drawing.Size(121, 20);
			this.txtPhoneSC.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(334, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Telefono:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmailSC
			// 
			this.txtEmailSC.Location = new System.Drawing.Point(441, 166);
			this.txtEmailSC.MaxLength = 60;
			this.txtEmailSC.Name = "txtEmailSC";
			this.txtEmailSC.Size = new System.Drawing.Size(172, 20);
			this.txtEmailSC.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(334, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "E-mail:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserSC
			// 
			this.txtUserSC.Location = new System.Drawing.Point(441, 202);
			this.txtUserSC.MaxLength = 45;
			this.txtUserSC.Name = "txtUserSC";
			this.txtUserSC.Size = new System.Drawing.Size(121, 20);
			this.txtUserSC.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(334, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Usuario:*";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPasswordSC
			// 
			this.txtPasswordSC.Location = new System.Drawing.Point(441, 237);
			this.txtPasswordSC.MaxLength = 45;
			this.txtPasswordSC.Name = "txtPasswordSC";
			this.txtPasswordSC.Size = new System.Drawing.Size(121, 20);
			this.txtPasswordSC.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(334, 235);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Password:*";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(295, 270);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(138, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Fecha de adquisicion:*";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDateAquisitionSC
			// 
			this.dtpDateAquisitionSC.Location = new System.Drawing.Point(441, 272);
			this.dtpDateAquisitionSC.Name = "dtpDateAquisitionSC";
			this.dtpDateAquisitionSC.Size = new System.Drawing.Size(184, 20);
			this.dtpDateAquisitionSC.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(296, 303);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(138, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "Estado:*";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cboStatusSC
			// 
			this.cboStatusSC.FormattingEnabled = true;
			this.cboStatusSC.Location = new System.Drawing.Point(441, 304);
			this.cboStatusSC.Name = "cboStatusSC";
			this.cboStatusSC.Size = new System.Drawing.Size(121, 21);
			this.cboStatusSC.TabIndex = 16;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(251, 342);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(138, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "Observaciones:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbRemarksSC
			// 
			this.rtbRemarksSC.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbRemarksSC.Location = new System.Drawing.Point(395, 342);
			this.rtbRemarksSC.MaxLength = 200;
			this.rtbRemarksSC.Name = "rtbRemarksSC";
			this.rtbRemarksSC.Size = new System.Drawing.Size(230, 65);
			this.rtbRemarksSC.TabIndex = 18;
			this.rtbRemarksSC.Text = "";
			// 
			// btnEditSessionCustomer
			// 
			this.btnEditSessionCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnEditSessionCustomer.FlatAppearance.BorderSize = 0;
			this.btnEditSessionCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditSessionCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSessionCustomer.Image")));
			this.btnEditSessionCustomer.Location = new System.Drawing.Point(482, 430);
			this.btnEditSessionCustomer.Name = "btnEditSessionCustomer";
			this.btnEditSessionCustomer.Size = new System.Drawing.Size(60, 60);
			this.btnEditSessionCustomer.TabIndex = 19;
			this.btnEditSessionCustomer.UseVisualStyleBackColor = false;
			this.btnEditSessionCustomer.Click += new System.EventHandler(this.BtnEditSessionCustomerClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(36, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(254, 265);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// FrmEditSessionCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(680, 509);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEditSessionCustomer);
			this.Controls.Add(this.rtbRemarksSC);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cboStatusSC);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtpDateAquisitionSC);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtPasswordSC);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtUserSC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEmailSC);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPhoneSC);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFullNameSC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdSessionCustomer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmEditSessionCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Actualizar Cliente de Sesion";
			this.Load += new System.EventHandler(this.FrmEditSessionCustomerLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
