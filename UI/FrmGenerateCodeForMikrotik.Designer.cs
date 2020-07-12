/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/28/2020
 * Time: 2:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmGenerateCodeForMikrotik
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
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboTime;
		private System.Windows.Forms.ComboBox cboLimitTraffic;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbUserAndPassword;
		private System.Windows.Forms.RadioButton rbVoucherCodeOnly;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtProfileName;
		private System.Windows.Forms.RichTextBox rtbCode;
		private System.Windows.Forms.Button btnGenerateCode;
		private System.Windows.Forms.Button btnGenerateExcel;
		private System.Windows.Forms.Label lblAdvertisement;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerateCodeForMikrotik));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboTime = new System.Windows.Forms.ComboBox();
			this.cboLimitTraffic = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbUserAndPassword = new System.Windows.Forms.RadioButton();
			this.rbVoucherCodeOnly = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.txtProfileName = new System.Windows.Forms.TextBox();
			this.rtbCode = new System.Windows.Forms.RichTextBox();
			this.btnGenerateCode = new System.Windows.Forms.Button();
			this.btnGenerateExcel = new System.Windows.Forms.Button();
			this.lblAdvertisement = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(844, 26);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Generador de Pines para Consola Mikrotik";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(790, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(23, 23);
			this.btnMinimize.TabIndex = 1;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(818, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(118, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cantidad:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(224, 76);
			this.txtAmount.MaxLength = 4;
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(100, 20);
			this.txtAmount.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(118, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tiempo:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cboTime
			// 
			this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTime.FormattingEnabled = true;
			this.cboTime.Location = new System.Drawing.Point(224, 115);
			this.cboTime.Name = "cboTime";
			this.cboTime.Size = new System.Drawing.Size(147, 21);
			this.cboTime.TabIndex = 4;
			this.cboTime.SelectionChangeCommitted += new System.EventHandler(this.CboTimeSelectionChangeCommitted);
			// 
			// cboLimitTraffic
			// 
			this.cboLimitTraffic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLimitTraffic.FormattingEnabled = true;
			this.cboLimitTraffic.Location = new System.Drawing.Point(224, 158);
			this.cboLimitTraffic.Name = "cboLimitTraffic";
			this.cboLimitTraffic.Size = new System.Drawing.Size(72, 21);
			this.cboLimitTraffic.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(102, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Limite de Trafico:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPrefix
			// 
			this.txtPrefix.Location = new System.Drawing.Point(224, 200);
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(100, 20);
			this.txtPrefix.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(118, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Prefijo:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbUserAndPassword);
			this.groupBox1.Controls.Add(this.rbVoucherCodeOnly);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(184, 241);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 73);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de Codigo";
			// 
			// rbUserAndPassword
			// 
			this.rbUserAndPassword.Location = new System.Drawing.Point(207, 29);
			this.rbUserAndPassword.Name = "rbUserAndPassword";
			this.rbUserAndPassword.Size = new System.Drawing.Size(165, 24);
			this.rbUserAndPassword.TabIndex = 1;
			this.rbUserAndPassword.TabStop = true;
			this.rbUserAndPassword.Text = "Usuario y Password";
			this.rbUserAndPassword.UseVisualStyleBackColor = true;
			// 
			// rbVoucherCodeOnly
			// 
			this.rbVoucherCodeOnly.Location = new System.Drawing.Point(18, 29);
			this.rbVoucherCodeOnly.Name = "rbVoucherCodeOnly";
			this.rbVoucherCodeOnly.Size = new System.Drawing.Size(180, 24);
			this.rbVoucherCodeOnly.TabIndex = 0;
			this.rbVoucherCodeOnly.TabStop = true;
			this.rbVoucherCodeOnly.Text = "Codigo de Ticket Unicamente";
			this.rbVoucherCodeOnly.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(70, 339);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(148, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Nombre de Perfil (Opcional):";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtProfileName
			// 
			this.txtProfileName.Location = new System.Drawing.Point(224, 341);
			this.txtProfileName.Name = "txtProfileName";
			this.txtProfileName.Size = new System.Drawing.Size(100, 20);
			this.txtProfileName.TabIndex = 12;
			// 
			// rtbCode
			// 
			this.rtbCode.Location = new System.Drawing.Point(40, 466);
			this.rtbCode.Name = "rtbCode";
			this.rtbCode.ReadOnly = true;
			this.rtbCode.Size = new System.Drawing.Size(756, 161);
			this.rtbCode.TabIndex = 13;
			this.rtbCode.Text = "";
			// 
			// btnGenerateCode
			// 
			this.btnGenerateCode.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnGenerateCode.FlatAppearance.BorderSize = 0;
			this.btnGenerateCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerateCode.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateCode.Image")));
			this.btnGenerateCode.Location = new System.Drawing.Point(407, 395);
			this.btnGenerateCode.Name = "btnGenerateCode";
			this.btnGenerateCode.Size = new System.Drawing.Size(50, 50);
			this.btnGenerateCode.TabIndex = 14;
			this.btnGenerateCode.UseVisualStyleBackColor = false;
			this.btnGenerateCode.Click += new System.EventHandler(this.BtnGenerateCodeClick);
			// 
			// btnGenerateExcel
			// 
			this.btnGenerateExcel.BackColor = System.Drawing.Color.DarkGreen;
			this.btnGenerateExcel.FlatAppearance.BorderSize = 0;
			this.btnGenerateExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerateExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateExcel.Image")));
			this.btnGenerateExcel.Location = new System.Drawing.Point(407, 647);
			this.btnGenerateExcel.Name = "btnGenerateExcel";
			this.btnGenerateExcel.Size = new System.Drawing.Size(55, 55);
			this.btnGenerateExcel.TabIndex = 15;
			this.btnGenerateExcel.UseVisualStyleBackColor = false;
			this.btnGenerateExcel.Click += new System.EventHandler(this.BtnGenerateExcelClick);
			// 
			// lblAdvertisement
			// 
			this.lblAdvertisement.ForeColor = System.Drawing.Color.White;
			this.lblAdvertisement.Location = new System.Drawing.Point(377, 114);
			this.lblAdvertisement.Name = "lblAdvertisement";
			this.lblAdvertisement.Size = new System.Drawing.Size(100, 23);
			this.lblAdvertisement.TabIndex = 16;
			this.lblAdvertisement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmGenerateCodeForMikrotik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(844, 719);
			this.Controls.Add(this.lblAdvertisement);
			this.Controls.Add(this.btnGenerateExcel);
			this.Controls.Add(this.btnGenerateCode);
			this.Controls.Add(this.rtbCode);
			this.Controls.Add(this.txtProfileName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtPrefix);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboLimitTraffic);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmGenerateCodeForMikrotik";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Genrador de Pines";
			this.Load += new System.EventHandler(this.FrmGenerateCodeForMikrotikLoad);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
