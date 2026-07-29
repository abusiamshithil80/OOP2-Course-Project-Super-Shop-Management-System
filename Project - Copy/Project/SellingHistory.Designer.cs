namespace Project
{
    partial class SellingHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSellingHistory = new System.Windows.Forms.Panel();
            this.dgvSoldDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.panSellingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panSellingHistory
            // 
            this.panSellingHistory.BackColor = System.Drawing.Color.Snow;
            this.panSellingHistory.Controls.Add(this.btnBack);
            this.panSellingHistory.Controls.Add(this.label1);
            this.panSellingHistory.Controls.Add(this.dgvSoldDetails);
            this.panSellingHistory.Location = new System.Drawing.Point(24, 21);
            this.panSellingHistory.Name = "panSellingHistory";
            this.panSellingHistory.Size = new System.Drawing.Size(639, 416);
            this.panSellingHistory.TabIndex = 0;
            // 
            // dgvSoldDetails
            // 
            this.dgvSoldDetails.AllowUserToAddRows = false;
            this.dgvSoldDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AntiqueWhite;
            this.dgvSoldDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldDetails.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvSoldDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoldDetails.ColumnHeadersHeight = 15;
            this.dgvSoldDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSoldDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartID,
            this.CoustomerID,
            this.CoustomerName,
            this.SalesmanID,
            this.SalesmanName,
            this.GrandTotal,
            this.Date});
            this.dgvSoldDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSoldDetails.GridColor = System.Drawing.Color.Black;
            this.dgvSoldDetails.Location = new System.Drawing.Point(59, 64);
            this.dgvSoldDetails.Name = "dgvSoldDetails";
            this.dgvSoldDetails.ReadOnly = true;
            this.dgvSoldDetails.RowHeadersVisible = false;
            this.dgvSoldDetails.Size = new System.Drawing.Size(529, 261);
            this.dgvSoldDetails.TabIndex = 9;
            this.dgvSoldDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSoldDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSoldDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSoldDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSoldDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSoldDetails.ThemeStyle.BackColor = System.Drawing.Color.Snow;
            this.dgvSoldDetails.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvSoldDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSoldDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSoldDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSoldDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSoldDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSoldDetails.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvSoldDetails.ThemeStyle.ReadOnly = true;
            this.dgvSoldDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSoldDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSoldDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSoldDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dgvSoldDetails.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSoldDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSoldDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selling History";
            // 
            // CartID
            // 
            this.CartID.DataPropertyName = "CartID";
            this.CartID.HeaderText = "Cart ID";
            this.CartID.Name = "CartID";
            this.CartID.ReadOnly = true;
            // 
            // CoustomerID
            // 
            this.CoustomerID.DataPropertyName = "CoustomerID";
            this.CoustomerID.HeaderText = "Coustomer ID";
            this.CoustomerID.Name = "CoustomerID";
            this.CoustomerID.ReadOnly = true;
            // 
            // CoustomerName
            // 
            this.CoustomerName.DataPropertyName = "CoustomerName";
            this.CoustomerName.HeaderText = "Coustomer Name";
            this.CoustomerName.Name = "CoustomerName";
            this.CoustomerName.ReadOnly = true;
            // 
            // SalesmanID
            // 
            this.SalesmanID.DataPropertyName = "SalesmanID";
            this.SalesmanID.HeaderText = "Salesman ID";
            this.SalesmanID.Name = "SalesmanID";
            this.SalesmanID.ReadOnly = true;
            // 
            // SalesmanName
            // 
            this.SalesmanName.DataPropertyName = "SalesmanName";
            this.SalesmanName.HeaderText = "Salesman Name";
            this.SalesmanName.Name = "SalesmanName";
            this.SalesmanName.ReadOnly = true;
            // 
            // GrandTotal
            // 
            this.GrandTotal.DataPropertyName = "GrandTotal";
            this.GrandTotal.HeaderText = "Grand Total";
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.SlateGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(235, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 29);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SellingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panSellingHistory);
            this.Name = "SellingHistory";
            this.Text = "SellingHistory";
            this.panSellingHistory.ResumeLayout(false);
            this.panSellingHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSellingHistory;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSoldDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}