/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 04/02/2020
 * Time: 15:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmEditService
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtIdService;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNameService;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPriceService;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.Button btnEditService;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditService));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtIdService = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNameService = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPriceService = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.btnEditService = new System.Windows.Forms.Button();
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
			this.panel1.Size = new System.Drawing.Size(783, 25);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Editar Plan de Servicio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(756, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(48, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(247, 244);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// txtIdService
			// 
			this.txtIdService.Location = new System.Drawing.Point(497, 76);
			this.txtIdService.MaxLength = 20;
			this.txtIdService.Name = "txtIdService";
			this.txtIdService.Size = new System.Drawing.Size(146, 20);
			this.txtIdService.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(394, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Referencia: *";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(394, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nombre: *";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNameService
			// 
			this.txtNameService.Location = new System.Drawing.Point(497, 102);
			this.txtNameService.MaxLength = 45;
			this.txtNameService.Name = "txtNameService";
			this.txtNameService.Size = new System.Drawing.Size(181, 20);
			this.txtNameService.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(394, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Precio CO: *";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPriceService
			// 
			this.txtPriceService.Location = new System.Drawing.Point(497, 128);
			this.txtPriceService.Name = "txtPriceService";
			this.txtPriceService.Size = new System.Drawing.Size(146, 20);
			this.txtPriceService.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(394, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Descripcion:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbDescription
			// 
			this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbDescription.Location = new System.Drawing.Point(500, 160);
			this.rtbDescription.MaxLength = 200;
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.Size = new System.Drawing.Size(178, 109);
			this.rtbDescription.TabIndex = 9;
			this.rtbDescription.Text = "";
			// 
			// btnEditService
			// 
			this.btnEditService.BackColor = System.Drawing.Color.ForestGreen;
			this.btnEditService.FlatAppearance.BorderSize = 0;
			this.btnEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditService.Image = ((System.Drawing.Image)(resources.GetObject("btnEditService.Image")));
			this.btnEditService.Location = new System.Drawing.Point(539, 300);
			this.btnEditService.Name = "btnEditService";
			this.btnEditService.Size = new System.Drawing.Size(50, 50);
			this.btnEditService.TabIndex = 10;
			this.btnEditService.UseVisualStyleBackColor = false;
			this.btnEditService.Click += new System.EventHandler(this.BtnEditServiceClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Maroon;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(595, 300);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 50);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// FrmEditService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(783, 405);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnEditService);
			this.Controls.Add(this.rtbDescription);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPriceService);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNameService);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIdService);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmEditService";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editar Plan de Servicio";
			this.Load += new System.EventHandler(this.FrmEditServiceLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
