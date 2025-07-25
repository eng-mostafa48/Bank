namespace Bank.Accounts.Controls
{
    partial class ctrlClientAccounts
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
            this.dgvListClientAccounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClientAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListClientAccounts
            // 
            this.dgvListClientAccounts.AllowUserToAddRows = false;
            this.dgvListClientAccounts.AllowUserToDeleteRows = false;
            this.dgvListClientAccounts.AllowUserToOrderColumns = true;
            this.dgvListClientAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvListClientAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClientAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListClientAccounts.GridColor = System.Drawing.Color.White;
            this.dgvListClientAccounts.Location = new System.Drawing.Point(0, 0);
            this.dgvListClientAccounts.Name = "dgvListClientAccounts";
            this.dgvListClientAccounts.ReadOnly = true;
            this.dgvListClientAccounts.RowHeadersWidth = 51;
            this.dgvListClientAccounts.RowTemplate.Height = 24;
            this.dgvListClientAccounts.Size = new System.Drawing.Size(978, 312);
            this.dgvListClientAccounts.TabIndex = 0;
            // 
            // ctrlClientAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvListClientAccounts);
            this.Name = "ctrlClientAccounts";
            this.Size = new System.Drawing.Size(978, 312);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClientAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListClientAccounts;
    }
}
