/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 23/01/2020
 * Time: 15:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmUsers
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.TextBox txtSearchUser;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnAddNewUser;
		private System.Windows.Forms.Button btnRefreshdgvUsers;
		private System.Windows.Forms.Button btnCompanyInformation;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.txtSearchUser = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnAddNewUser = new System.Windows.Forms.Button();
			this.btnRefreshdgvUsers = new System.Windows.Forms.Button();
			this.btnCompanyInformation = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1129, 19);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuarios Activos";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(1109, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(20, 20);
			this.btnClose.TabIndex = 2;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(73, 103);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(252, 273);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// dgvUsers
			// 
			this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
			this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.GridColor = System.Drawing.Color.White;
			this.dgvUsers.Location = new System.Drawing.Point(374, 103);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.Size = new System.Drawing.Size(727, 314);
			this.dgvUsers.TabIndex = 2;
			// 
			// txtSearchUser
			// 
			this.txtSearchUser.Location = new System.Drawing.Point(374, 77);
			this.txtSearchUser.Name = "txtSearchUser";
			this.txtSearchUser.Size = new System.Drawing.Size(229, 20);
			this.txtSearchUser.TabIndex = 3;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(606, 77);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(21, 21);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// btnAddNewUser
			// 
			this.btnAddNewUser.BackColor = System.Drawing.Color.Green;
			this.btnAddNewUser.FlatAppearance.BorderSize = 0;
			this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.Image")));
			this.btnAddNewUser.Location = new System.Drawing.Point(1079, 76);
			this.btnAddNewUser.Name = "btnAddNewUser";
			this.btnAddNewUser.Size = new System.Drawing.Size(21, 21);
			this.btnAddNewUser.TabIndex = 5;
			this.btnAddNewUser.UseVisualStyleBackColor = false;
			this.btnAddNewUser.Click += new System.EventHandler(this.BtnAddNewUserClick);
			// 
			// btnRefreshdgvUsers
			// 
			this.btnRefreshdgvUsers.BackColor = System.Drawing.Color.Navy;
			this.btnRefreshdgvUsers.FlatAppearance.BorderSize = 0;
			this.btnRefreshdgvUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefreshdgvUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshdgvUsers.Image")));
			this.btnRefreshdgvUsers.Location = new System.Drawing.Point(1021, 76);
			this.btnRefreshdgvUsers.Name = "btnRefreshdgvUsers";
			this.btnRefreshdgvUsers.Size = new System.Drawing.Size(21, 21);
			this.btnRefreshdgvUsers.TabIndex = 6;
			this.btnRefreshdgvUsers.UseVisualStyleBackColor = false;
			this.btnRefreshdgvUsers.Click += new System.EventHandler(this.BtnRefreshdgvUsersClick);
			// 
			// btnCompanyInformation
			// 
			this.btnCompanyInformation.BackColor = System.Drawing.Color.DarkViolet;
			this.btnCompanyInformation.FlatAppearance.BorderSize = 0;
			this.btnCompanyInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCompanyInformation.ForeColor = System.Drawing.Color.White;
			this.btnCompanyInformation.Location = new System.Drawing.Point(122, 451);
			this.btnCompanyInformation.Name = "btnCompanyInformation";
			this.btnCompanyInformation.Size = new System.Drawing.Size(153, 23);
			this.btnCompanyInformation.TabIndex = 7;
			this.btnCompanyInformation.Text = "Informacion de la Empresa";
			this.btnCompanyInformation.UseVisualStyleBackColor = false;
			this.btnCompanyInformation.Click += new System.EventHandler(this.BtnCompanyInformationClick);
			// 
			// FrmUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(1129, 492);
			this.Controls.Add(this.btnCompanyInformation);
			this.Controls.Add(this.btnRefreshdgvUsers);
			this.Controls.Add(this.btnAddNewUser);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearchUser);
			this.Controls.Add(this.dgvUsers);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Usuarios Registrados";
			this.Load += new System.EventHandler(this.FrmUsersLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
