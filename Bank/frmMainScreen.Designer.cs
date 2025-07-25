namespace Bank
{
    partial class frmMainScreen
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
            this.sbPanel = new System.Windows.Forms.Panel();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.AccSettingsPanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChagePassword = new System.Windows.Forms.Button();
            this.btnCurrentUserInfo = new System.Windows.Forms.Button();
            this.btnAccSettings = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sbTimer = new System.Windows.Forms.Timer(this.components);
            this.AccSettingsTimer = new System.Windows.Forms.Timer(this.components);
            this.Containeerpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbPanel.SuspendLayout();
            this.AccSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Containeerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sbPanel
            // 
            this.sbPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.sbPanel.Controls.Add(this.panel1);
            this.sbPanel.Controls.Add(this.btnTransactions);
            this.sbPanel.Controls.Add(this.pictureBox1);
            this.sbPanel.Controls.Add(this.label1);
            this.sbPanel.Controls.Add(this.btnAccounts);
            this.sbPanel.Controls.Add(this.btnClients);
            this.sbPanel.Controls.Add(this.btnPeople);
            this.sbPanel.Controls.Add(this.btnUsers);
            this.sbPanel.Controls.Add(this.AccSettingsPanel);
            this.sbPanel.Controls.Add(this.pictureBox5);
            this.sbPanel.Controls.Add(this.pictureBox3);
            this.sbPanel.Controls.Add(this.label3);
            this.sbPanel.Location = new System.Drawing.Point(0, 0);
            this.sbPanel.MaximumSize = new System.Drawing.Size(279, 2900);
            this.sbPanel.MinimumSize = new System.Drawing.Size(84, 2900);
            this.sbPanel.Name = "sbPanel";
            this.sbPanel.Size = new System.Drawing.Size(279, 2900);
            this.sbPanel.TabIndex = 6;
            this.sbPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sbPanel_Paint);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnTransactions.Image = global::Bank.Properties.Resources.transaction;
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(0, 180);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(276, 63);
            this.btnTransactions.TabIndex = 10;
            this.btnTransactions.Text = "    Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.Black;
            this.btnAccounts.Image = global::Bank.Properties.Resources.bank_account__1_;
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(0, 254);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(276, 63);
            this.btnAccounts.TabIndex = 9;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.Black;
            this.btnClients.Image = global::Bank.Properties.Resources.Ionic_Ionicons_People_48;
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(0, 406);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(276, 63);
            this.btnClients.TabIndex = 9;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.Black;
            this.btnPeople.Image = global::Bank.Properties.Resources.Ionic_Ionicons_People_48;
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.Location = new System.Drawing.Point(0, 330);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(276, 63);
            this.btnPeople.TabIndex = 8;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Image = global::Bank.Properties.Resources.Icons8_Windows_8_Users_Name_48;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(3, 482);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(276, 63);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // AccSettingsPanel
            // 
            this.AccSettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.AccSettingsPanel.Controls.Add(this.btnLogOut);
            this.AccSettingsPanel.Controls.Add(this.btnChagePassword);
            this.AccSettingsPanel.Controls.Add(this.btnCurrentUserInfo);
            this.AccSettingsPanel.Controls.Add(this.btnAccSettings);
            this.AccSettingsPanel.ForeColor = System.Drawing.Color.Black;
            this.AccSettingsPanel.Location = new System.Drawing.Point(3, 558);
            this.AccSettingsPanel.MaximumSize = new System.Drawing.Size(276, 200);
            this.AccSettingsPanel.MinimumSize = new System.Drawing.Size(270, 62);
            this.AccSettingsPanel.Name = "AccSettingsPanel";
            this.AccSettingsPanel.Size = new System.Drawing.Size(273, 62);
            this.AccSettingsPanel.TabIndex = 10;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::Bank.Properties.Resources.Pictogrammers_Material_Login_variant_24;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 150);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(276, 47);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnChagePassword
            // 
            this.btnChagePassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChagePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChagePassword.FlatAppearance.BorderSize = 0;
            this.btnChagePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChagePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChagePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChagePassword.Image = global::Bank.Properties.Resources.Iconsmind_Outline_Password_Field_24;
            this.btnChagePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChagePassword.Location = new System.Drawing.Point(0, 110);
            this.btnChagePassword.Name = "btnChagePassword";
            this.btnChagePassword.Size = new System.Drawing.Size(273, 47);
            this.btnChagePassword.TabIndex = 2;
            this.btnChagePassword.Text = "       Change Password";
            this.btnChagePassword.UseVisualStyleBackColor = false;
            this.btnChagePassword.Click += new System.EventHandler(this.btnChagePassword_Click);
            // 
            // btnCurrentUserInfo
            // 
            this.btnCurrentUserInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCurrentUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentUserInfo.FlatAppearance.BorderSize = 0;
            this.btnCurrentUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentUserInfo.ForeColor = System.Drawing.Color.Black;
            this.btnCurrentUserInfo.Image = global::Bank.Properties.Resources.Custom_Icon_Design_Silky_Line_User_User_info_24;
            this.btnCurrentUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentUserInfo.Location = new System.Drawing.Point(0, 63);
            this.btnCurrentUserInfo.Name = "btnCurrentUserInfo";
            this.btnCurrentUserInfo.Size = new System.Drawing.Size(273, 47);
            this.btnCurrentUserInfo.TabIndex = 1;
            this.btnCurrentUserInfo.Text = "Cuurent User";
            this.btnCurrentUserInfo.UseVisualStyleBackColor = false;
            this.btnCurrentUserInfo.Click += new System.EventHandler(this.btnCurrentUserInfo_Click);
            // 
            // btnAccSettings
            // 
            this.btnAccSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnAccSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccSettings.FlatAppearance.BorderSize = 0;
            this.btnAccSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSettings.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccSettings.ForeColor = System.Drawing.Color.Black;
            this.btnAccSettings.Image = global::Bank.Properties.Resources.Froyoshark_Enkel_Settings_48;
            this.btnAccSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccSettings.Location = new System.Drawing.Point(0, 0);
            this.btnAccSettings.Name = "btnAccSettings";
            this.btnAccSettings.Size = new System.Drawing.Size(273, 63);
            this.btnAccSettings.TabIndex = 0;
            this.btnAccSettings.Text = "      Account Settings";
            this.btnAccSettings.UseVisualStyleBackColor = false;
            this.btnAccSettings.Click += new System.EventHandler(this.btnAccSettings_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Bank.Properties.Resources.Ionic_Ionicons_People_48;
            this.pictureBox5.Location = new System.Drawing.Point(110, 1475);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 50);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bank.Properties.Resources.Ionic_Ionicons_People_48;
            this.pictureBox3.Location = new System.Drawing.Point(69, 1475);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 1490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(82, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.Aniket_Suvarna_Box_Regular_Bx_menu_alt_left_48;
            this.pictureBox1.Location = new System.Drawing.Point(9, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sbTimer
            // 
            this.sbTimer.Interval = 10;
            this.sbTimer.Tick += new System.EventHandler(this.sbTimer_Tick);
            // 
            // AccSettingsTimer
            // 
            this.AccSettingsTimer.Interval = 10;
            this.AccSettingsTimer.Tick += new System.EventHandler(this.AccSettingsTimer_Tick);
            // 
            // Containeerpanel
            // 
            this.Containeerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Containeerpanel.Controls.Add(this.pictureBox2);
            this.Containeerpanel.Controls.Add(this.label2);
            this.Containeerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Containeerpanel.Location = new System.Drawing.Point(0, 0);
            this.Containeerpanel.Name = "Containeerpanel";
            this.Containeerpanel.Size = new System.Drawing.Size(1483, 713);
            this.Containeerpanel.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bank.Properties.Resources.bank1;
            this.pictureBox2.Location = new System.Drawing.Point(1056, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(412, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(973, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digital Banking System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 4);
            this.panel1.TabIndex = 5;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1483, 713);
            this.Controls.Add(this.sbPanel);
            this.Controls.Add(this.Containeerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMainScreen";
            this.Text = "Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.sbPanel.ResumeLayout(false);
            this.sbPanel.PerformLayout();
            this.AccSettingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Containeerpanel.ResumeLayout(false);
            this.Containeerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sbPanel;
        private System.Windows.Forms.Timer sbTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel AccSettingsPanel;
        private System.Windows.Forms.Button btnAccSettings;
        private System.Windows.Forms.Button btnCurrentUserInfo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChagePassword;
        private System.Windows.Forms.Timer AccSettingsTimer;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Panel Containeerpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Panel panel1;
    }
}