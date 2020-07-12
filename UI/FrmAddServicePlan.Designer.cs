/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 29/01/2020
 * Time: 15:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmAddServicePlan
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIdService;
		private System.Windows.Forms.TextBox txtNamePlan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPricePlan;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox rtbDescriptionPlan;
		private System.Windows.Forms.Button btnSaveService;
		private System.Windows.Forms.Button btnCancel;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddServicePlan));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIdService = new System.Windows.Forms.TextBox();
			this.txtNamePlan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPricePlan = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rtbDescriptionPlan = new System.Windows.Forms.RichTextBox();
			this.btnSaveService = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
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
			this.panel1.Size = new System.Drawing.Size(714, 26);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nuevo Plan de Servicio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(687, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(240, 246);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(351, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Referencia: *";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIdService
			// 
			this.txtIdService.Location = new System.Drawing.Point(423, 45);
			this.txtIdService.MaxLength = 20;
			this.txtIdService.Name = "txtIdService";
			this.txtIdService.Size = new System.Drawing.Size(162, 20);
			this.txtIdService.TabIndex = 3;
			// 
			// txtNamePlan
			// 
			this.txtNamePlan.Location = new System.Drawing.Point(423, 82);
			this.txtNamePlan.MaxLength = 45;
			this.txtNamePlan.Name = "txtNamePlan";
			this.txtNamePlan.Size = new System.Drawing.Size(162, 20);
			this.txtNamePlan.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(314, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nombre del Plan: *";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPricePlan
			// 
			this.txtPricePlan.Location = new System.Drawing.Point(423, 120);
			this.txtPricePlan.Name = "txtPricePlan";
			this.txtPricePlan.Size = new System.Drawing.Size(162, 20);
			this.txtPricePlan.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(331, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Precio (CO): *";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(331, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Descripción: *";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbDescriptionPlan
			// 
			this.rtbDescriptionPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbDescriptionPlan.Location = new System.Drawing.Point(426, 160);
			this.rtbDescriptionPlan.MaxLength = 200;
			this.rtbDescriptionPlan.Name = "rtbDescriptionPlan";
			this.rtbDescriptionPlan.Size = new System.Drawing.Size(159, 98);
			this.rtbDescriptionPlan.TabIndex = 9;
			this.rtbDescriptionPlan.Text = "";
			// 
			// btnSaveService
			// 
			this.btnSaveService.BackColor = System.Drawing.Color.ForestGreen;
			this.btnSaveService.FlatAppearance.BorderSize = 0;
			this.btnSaveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveService.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveService.Image")));
			this.btnSaveService.Location = new System.Drawing.Point(453, 297);
			this.btnSaveService.Name = "btnSaveService";
			this.btnSaveService.Size = new System.Drawing.Size(50, 50);
			this.btnSaveService.TabIndex = 10;
			this.btnSaveService.UseVisualStyleBackColor = false;
			this.btnSaveService.Click += new System.EventHandler(this.BtnSaveServiceClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Brown;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(509, 297);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// FrmAddServicePlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(714, 384);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveService);
			this.Controls.Add(this.rtbDescriptionPlan);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPricePlan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNamePlan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdService);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAddServicePlan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo Plan de Servicio";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
