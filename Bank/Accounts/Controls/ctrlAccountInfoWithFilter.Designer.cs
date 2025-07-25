namespace Bank.Accounts.Controls
{
    partial class ctrlAccountInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlAccountInfo1 = new Bank.Accounts.Controls.ctrlAccountInfo();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlAccountInfo1
            // 
            this.ctrlAccountInfo1.AutoSize = true;
            this.ctrlAccountInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlAccountInfo1.Location = new System.Drawing.Point(0, 133);
            this.ctrlAccountInfo1.Name = "ctrlAccountInfo1";
            this.ctrlAccountInfo1.Size = new System.Drawing.Size(877, 506);
            this.ctrlAccountInfo1.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.txtAccountID);
            this.gbFilter.Controls.Add(this.lblAccountID);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(880, 130);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Image = global::Bank.Properties.Resources.Graphicloads_Colorful_Long_Shadow_Search_32;
            this.btnFind.Location = new System.Drawing.Point(464, 37);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(51, 44);
            this.btnFind.TabIndex = 4;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(182, 48);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(231, 24);
            this.txtAccountID.TabIndex = 3;
            this.txtAccountID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonID_KeyPress);
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(73, 50);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(85, 18);
            this.lblAccountID.TabIndex = 0;
            this.lblAccountID.Text = "AccountID";
            // 
            // ctrlAccountInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlAccountInfo1);
            this.Name = "ctrlAccountInfoWithFilter";
            this.Size = new System.Drawing.Size(880, 642);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAccountInfo ctrlAccountInfo1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtAccountID;
    }
}
