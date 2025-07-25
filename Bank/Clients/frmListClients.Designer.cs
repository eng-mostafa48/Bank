namespace Bank.Clients
{
    partial class frmListClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeopleCount = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dgvListClients = new System.Windows.Forms.DataGridView();
            this.cmsClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClients)).BeginInit();
            this.cmsClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(358, 273);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(236, 30);
            this.txtFilterBy.TabIndex = 21;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filter By";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "none",
            "Client ID",
            "Person ID",
            "FullName",
            "Email",
            "Address",
            "Country"});
            this.cbFilterBy.Location = new System.Drawing.Point(162, 273);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(181, 33);
            this.cbFilterBy.TabIndex = 19;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(507, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Clients Management";
            // 
            // lblPeopleCount
            // 
            this.lblPeopleCount.AutoSize = true;
            this.lblPeopleCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleCount.Location = new System.Drawing.Point(258, 647);
            this.lblPeopleCount.Name = "lblPeopleCount";
            this.lblPeopleCount.Size = new System.Drawing.Size(34, 31);
            this.lblPeopleCount.TabIndex = 16;
            this.lblPeopleCount.Text = "??";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(12, 645);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(214, 31);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Number Of Clients";
            // 
            // dgvListClients
            // 
            this.dgvListClients.AllowUserToAddRows = false;
            this.dgvListClients.AllowUserToDeleteRows = false;
            this.dgvListClients.AllowUserToOrderColumns = true;
            this.dgvListClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvListClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClients.ContextMenuStrip = this.cmsClient;
            this.dgvListClients.Location = new System.Drawing.Point(12, 317);
            this.dgvListClients.Name = "dgvListClients";
            this.dgvListClients.ReadOnly = true;
            this.dgvListClients.RowHeadersWidth = 51;
            this.dgvListClients.RowTemplate.Height = 24;
            this.dgvListClients.Size = new System.Drawing.Size(1202, 279);
            this.dgvListClients.TabIndex = 12;
            // 
            // cmsClient
            // 
            this.cmsClient.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsClient.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.showClientAccountsToolStripMenuItem});
            this.cmsClient.Name = "cmsClient";
            this.cmsClient.Size = new System.Drawing.Size(275, 118);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // btnclose2
            // 
            this.btnclose2.BackColor = System.Drawing.Color.White;
            this.btnclose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose2.ForeColor = System.Drawing.Color.White;
            this.btnclose2.Image = global::Bank.Properties.Resources.close__2_;
            this.btnclose2.Location = new System.Drawing.Point(1175, 3);
            this.btnclose2.Name = "btnclose2";
            this.btnclose2.Size = new System.Drawing.Size(58, 51);
            this.btnclose2.TabIndex = 18;
            this.btnclose2.UseVisualStyleBackColor = false;
            this.btnclose2.Click += new System.EventHandler(this.btnclose2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Bank.Properties.Resources.close__2_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1104, 629);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 47);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bank.Properties.Resources.team1;
            this.pictureBox1.Location = new System.Drawing.Point(567, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // showClientInfoToolStripMenuItem
            // 
            this.showClientInfoToolStripMenuItem.Image = global::Bank.Properties.Resources._330401_about_details_help_info_information_icon;
            this.showClientInfoToolStripMenuItem.Name = "showClientInfoToolStripMenuItem";
            this.showClientInfoToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.showClientInfoToolStripMenuItem.Text = "Show Client info";
            this.showClientInfoToolStripMenuItem.Click += new System.EventHandler(this.showClientInfoToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Bank.Properties.Resources.trash;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showClientAccountsToolStripMenuItem
            // 
            this.showClientAccountsToolStripMenuItem.Image = global::Bank.Properties.Resources.bank_check;
            this.showClientAccountsToolStripMenuItem.Name = "showClientAccountsToolStripMenuItem";
            this.showClientAccountsToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.showClientAccountsToolStripMenuItem.Text = "Show Client Accounts ";
            this.showClientAccountsToolStripMenuItem.Click += new System.EventHandler(this.showClientAccountsToolStripMenuItem_Click);
            // 
            // frmListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 707);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnclose2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeopleCount);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvListClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListClients";
            this.Text = "frmListClients";
            this.Load += new System.EventHandler(this.frmListClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClients)).EndInit();
            this.cmsClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnclose2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeopleCount;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvListClients;
        private System.Windows.Forms.ContextMenuStrip cmsClient;
        private System.Windows.Forms.ToolStripMenuItem showClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientAccountsToolStripMenuItem;
    }
}