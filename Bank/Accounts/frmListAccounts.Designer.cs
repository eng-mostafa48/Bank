namespace Bank.Accounts
{
    partial class frmListAccounts
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
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountsCount = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dgvListAccounts = new System.Windows.Forms.DataGridView();
            this.cmsAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAccountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showTransactiosHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.depositeWithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccounts)).BeginInit();
            this.cmsAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(333, 295);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(236, 30);
            this.txtFilterBy.TabIndex = 20;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "none",
            "Account ID",
            "Client ID",
            "Client Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(137, 295);
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
            this.label1.Location = new System.Drawing.Point(489, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Accounts Management";
            // 
            // lblAccountsCount
            // 
            this.lblAccountsCount.AutoSize = true;
            this.lblAccountsCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountsCount.Location = new System.Drawing.Point(275, 650);
            this.lblAccountsCount.Name = "lblAccountsCount";
            this.lblAccountsCount.Size = new System.Drawing.Size(34, 31);
            this.lblAccountsCount.TabIndex = 16;
            this.lblAccountsCount.Text = "??";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(18, 650);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(238, 31);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Number Of Accounts";
            // 
            // dgvListAccounts
            // 
            this.dgvListAccounts.AllowUserToAddRows = false;
            this.dgvListAccounts.AllowUserToDeleteRows = false;
            this.dgvListAccounts.AllowUserToOrderColumns = true;
            this.dgvListAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvListAccounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAccounts.ContextMenuStrip = this.cmsAccount;
            this.dgvListAccounts.Location = new System.Drawing.Point(24, 335);
            this.dgvListAccounts.Name = "dgvListAccounts";
            this.dgvListAccounts.ReadOnly = true;
            this.dgvListAccounts.RowHeadersWidth = 51;
            this.dgvListAccounts.RowTemplate.Height = 24;
            this.dgvListAccounts.Size = new System.Drawing.Size(1230, 279);
            this.dgvListAccounts.TabIndex = 12;
            // 
            // cmsAccount
            // 
            this.cmsAccount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAccount.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAccountInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewAccountToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.showTransactiosHistoryToolStripMenuItem,
            this.depositeWithdrawToolStripMenuItem});
            this.cmsAccount.Name = "cmsAccount";
            this.cmsAccount.Size = new System.Drawing.Size(296, 260);
            this.cmsAccount.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAccount_Opening);
            // 
            // showAccountInfoToolStripMenuItem
            // 
            this.showAccountInfoToolStripMenuItem.Image = global::Bank.Properties.Resources.file;
            this.showAccountInfoToolStripMenuItem.Name = "showAccountInfoToolStripMenuItem";
            this.showAccountInfoToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.showAccountInfoToolStripMenuItem.Text = "Show Account Info";
            this.showAccountInfoToolStripMenuItem.Click += new System.EventHandler(this.showAccountInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(292, 6);
            // 
            // addNewAccountToolStripMenuItem
            // 
            this.addNewAccountToolStripMenuItem.Image = global::Bank.Properties.Resources.add_user;
            this.addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            this.addNewAccountToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.addNewAccountToolStripMenuItem.Text = "Add New Account";
            this.addNewAccountToolStripMenuItem.Click += new System.EventHandler(this.addNewAccountToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::Bank.Properties.Resources.card;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Bank.Properties.Resources.trash;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(292, 6);
            // 
            // showTransactiosHistoryToolStripMenuItem
            // 
            this.showTransactiosHistoryToolStripMenuItem.Image = global::Bank.Properties.Resources.report1;
            this.showTransactiosHistoryToolStripMenuItem.Name = "showTransactiosHistoryToolStripMenuItem";
            this.showTransactiosHistoryToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.showTransactiosHistoryToolStripMenuItem.Text = "Show Transactios History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filter";
            // 
            // cbIsActive
            // 
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(333, 296);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(181, 33);
            this.cbIsActive.TabIndex = 23;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Bank.Properties.Resources.add_user;
            this.btnAdd.Location = new System.Drawing.Point(1163, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 78);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnclose2
            // 
            this.btnclose2.BackColor = System.Drawing.Color.White;
            this.btnclose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose2.ForeColor = System.Drawing.Color.White;
            this.btnclose2.Image = global::Bank.Properties.Resources.close__2_;
            this.btnclose2.Location = new System.Drawing.Point(1238, 3);
            this.btnclose2.Name = "btnclose2";
            this.btnclose2.Size = new System.Drawing.Size(51, 47);
            this.btnclose2.TabIndex = 18;
            this.btnclose2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnClose.Location = new System.Drawing.Point(1144, 647);
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
            this.pictureBox1.Image = global::Bank.Properties.Resources.bank_account;
            this.pictureBox1.Location = new System.Drawing.Point(569, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // depositeWithdrawToolStripMenuItem
            // 
            this.depositeWithdrawToolStripMenuItem.Image = global::Bank.Properties.Resources.exchange;
            this.depositeWithdrawToolStripMenuItem.Name = "depositeWithdrawToolStripMenuItem";
            this.depositeWithdrawToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.depositeWithdrawToolStripMenuItem.Text = "Deposite / Withdraw";
            this.depositeWithdrawToolStripMenuItem.Click += new System.EventHandler(this.depositeWithdrawToolStripMenuItem_Click);
            // 
            // frmListAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 746);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnclose2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccountsCount);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvListAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListAccounts";
            this.Text = "Manag Accounts";
            this.Load += new System.EventHandler(this.frmListAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccounts)).EndInit();
            this.cmsAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnclose2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountsCount;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvListAccounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsAccount;
        private System.Windows.Forms.ToolStripMenuItem showAccountInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showTransactiosHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositeWithdrawToolStripMenuItem;
    }
}