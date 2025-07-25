namespace Bank.Transactions
{
    partial class frmListTransactions
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
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTransactionsCount = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dgvListTransactios = new System.Windows.Forms.DataGridView();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbTransactionType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransactios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(391, 320);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(236, 30);
            this.txtFilterBy.TabIndex = 21;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 319);
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
            "TransactionID",
            "FromAccountID",
            "ToAccountID",
            "TransactionType"});
            this.cbFilterBy.Location = new System.Drawing.Point(195, 320);
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
            this.label1.Location = new System.Drawing.Point(739, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Transactions";
            // 
            // lblTransactionsCount
            // 
            this.lblTransactionsCount.AutoSize = true;
            this.lblTransactionsCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsCount.Location = new System.Drawing.Point(296, 691);
            this.lblTransactionsCount.Name = "lblTransactionsCount";
            this.lblTransactionsCount.Size = new System.Drawing.Size(34, 31);
            this.lblTransactionsCount.TabIndex = 16;
            this.lblTransactionsCount.Text = "??";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(47, 691);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(243, 31);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Transactions Records";
            // 
            // dgvListTransactios
            // 
            this.dgvListTransactios.AllowUserToAddRows = false;
            this.dgvListTransactios.AllowUserToDeleteRows = false;
            this.dgvListTransactios.AllowUserToOrderColumns = true;
            this.dgvListTransactios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTransactios.BackgroundColor = System.Drawing.Color.White;
            this.dgvListTransactios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListTransactios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTransactios.Location = new System.Drawing.Point(52, 360);
            this.dgvListTransactios.Name = "dgvListTransactios";
            this.dgvListTransactios.ReadOnly = true;
            this.dgvListTransactios.RowHeadersWidth = 51;
            this.dgvListTransactios.RowTemplate.Height = 24;
            this.dgvListTransactios.Size = new System.Drawing.Size(1436, 279);
            this.dgvListTransactios.TabIndex = 12;
            // 
            // btnclose2
            // 
            this.btnclose2.BackColor = System.Drawing.Color.White;
            this.btnclose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose2.ForeColor = System.Drawing.Color.White;
            this.btnclose2.Image = global::Bank.Properties.Resources.close__2_;
            this.btnclose2.Location = new System.Drawing.Point(1441, 2);
            this.btnclose2.Name = "btnclose2";
            this.btnclose2.Size = new System.Drawing.Size(57, 47);
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
            this.btnClose.Location = new System.Drawing.Point(1378, 675);
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
            this.pictureBox1.Image = global::Bank.Properties.Resources.money_exchange;
            this.pictureBox1.Location = new System.Drawing.Point(722, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.Items.AddRange(new object[] {
            "All",
            "Deposit",
            "Withdraw",
            "Transfer"});
            this.cbTransactionType.Location = new System.Drawing.Point(391, 321);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(181, 33);
            this.cbTransactionType.TabIndex = 22;
            this.cbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cbTransactionType_SelectedIndexChanged);
            // 
            // frmListTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 759);
            this.Controls.Add(this.cbTransactionType);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnclose2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTransactionsCount);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvListTransactios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListTransactions";
            this.Text = "frmListTransactions";
            this.Load += new System.EventHandler(this.frmListTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTransactios)).EndInit();
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
        private System.Windows.Forms.Label lblTransactionsCount;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvListTransactios;
        private System.Windows.Forms.ComboBox cbTransactionType;
    }
}