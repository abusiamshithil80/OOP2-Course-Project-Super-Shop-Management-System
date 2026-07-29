namespace Project
{
    partial class ProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panProductDetails = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2PictureBox12 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSalesmanId = new System.Windows.Forms.Label();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.panProductList = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDeleteProduct = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProductList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductList = new System.Windows.Forms.Label();
            this.panProductDetails.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).BeginInit();
            this.panProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // panProductDetails
            // 
            this.panProductDetails.BackColor = System.Drawing.Color.PapayaWhip;
            this.panProductDetails.Controls.Add(this.panel7);
            this.panProductDetails.Controls.Add(this.cmbCategory);
            this.panProductDetails.Controls.Add(this.lblCategory);
            this.panProductDetails.Controls.Add(this.txtUnitPrice);
            this.panProductDetails.Controls.Add(this.lblUnitPrice);
            this.panProductDetails.Controls.Add(this.lblQuantity);
            this.panProductDetails.Controls.Add(this.lblProductName);
            this.panProductDetails.Controls.Add(this.txtQuantity);
            this.panProductDetails.Controls.Add(this.txtProductName);
            this.panProductDetails.Controls.Add(this.txtProductID);
            this.panProductDetails.Controls.Add(this.lblSalesmanId);
            this.panProductDetails.Controls.Add(this.lblProductDetails);
            this.panProductDetails.Location = new System.Drawing.Point(10, 10);
            this.panProductDetails.Name = "panProductDetails";
            this.panProductDetails.Size = new System.Drawing.Size(206, 440);
            this.panProductDetails.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.guna2PictureBox12);
            this.panel7.Controls.Add(this.lblBack);
            this.panel7.Location = new System.Drawing.Point(3, 395);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(203, 45);
            this.panel7.TabIndex = 17;
            // 
            // guna2PictureBox12
            // 
            this.guna2PictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox12.Image")));
            this.guna2PictureBox12.ImageRotate = 0F;
            this.guna2PictureBox12.Location = new System.Drawing.Point(43, 8);
            this.guna2PictureBox12.Name = "guna2PictureBox12";
            this.guna2PictureBox12.Size = new System.Drawing.Size(41, 31);
            this.guna2PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox12.TabIndex = 5;
            this.guna2PictureBox12.TabStop = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBack.Location = new System.Drawing.Point(82, 15);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(48, 19);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoRoundedCorners = true;
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Items.AddRange(new object[] {
            "Beverage",
            "Dairy",
            "Meat",
            "Fish",
            "Grocery & Food",
            "Fresh Products",
            "Frozen",
            "Beauty Care"});
            this.cmbCategory.Location = new System.Drawing.Point(13, 334);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 36);
            this.cmbCategory.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCategory.Location = new System.Drawing.Point(10, 313);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 16);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoRoundedCorners = true;
            this.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitPrice.DefaultText = "";
            this.txtUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.Location = new System.Drawing.Point(13, 276);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PlaceholderText = "";
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.Size = new System.Drawing.Size(180, 30);
            this.txtUnitPrice.TabIndex = 14;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUnitPrice.Location = new System.Drawing.Point(10, 255);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(65, 16);
            this.lblUnitPrice.TabIndex = 13;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQuantity.Location = new System.Drawing.Point(10, 191);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 16);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProductName.Location = new System.Drawing.Point(10, 117);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(99, 16);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Product Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Animated = true;
            this.txtQuantity.AutoRoundedCorners = true;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(13, 210);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(180, 30);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.AutoRoundedCorners = true;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(13, 142);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(180, 30);
            this.txtProductName.TabIndex = 8;
            // 
            // txtProductID
            // 
            this.txtProductID.AutoRoundedCorners = true;
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductID.DefaultText = "";
            this.txtProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Location = new System.Drawing.Point(13, 74);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PlaceholderText = "";
            this.txtProductID.SelectedText = "";
            this.txtProductID.Size = new System.Drawing.Size(180, 30);
            this.txtProductID.TabIndex = 7;
            // 
            // lblSalesmanId
            // 
            this.lblSalesmanId.AutoSize = true;
            this.lblSalesmanId.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesmanId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalesmanId.Location = new System.Drawing.Point(10, 52);
            this.lblSalesmanId.Name = "lblSalesmanId";
            this.lblSalesmanId.Size = new System.Drawing.Size(73, 16);
            this.lblSalesmanId.TabIndex = 6;
            this.lblSalesmanId.Text = "Product ID";
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProductDetails.Location = new System.Drawing.Point(10, 10);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(148, 23);
            this.lblProductDetails.TabIndex = 5;
            this.lblProductDetails.Text = "Product Details";
            // 
            // panProductList
            // 
            this.panProductList.BackColor = System.Drawing.Color.PapayaWhip;
            this.panProductList.Controls.Add(this.btnClear);
            this.panProductList.Controls.Add(this.BtnDeleteProduct);
            this.panProductList.Controls.Add(this.BtnAddProduct);
            this.panProductList.Controls.Add(this.dgvProductList);
            this.panProductList.Controls.Add(this.lblProductList);
            this.panProductList.Location = new System.Drawing.Point(238, 10);
            this.panProductList.Name = "panProductList";
            this.panProductList.Size = new System.Drawing.Size(534, 440);
            this.panProductList.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.SlateGray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(206, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 29);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.AutoRoundedCorners = true;
            this.BtnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteProduct.FillColor = System.Drawing.Color.SlateGray;
            this.BtnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProduct.Location = new System.Drawing.Point(390, 366);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(130, 29);
            this.BtnDeleteProduct.TabIndex = 10;
            this.BtnDeleteProduct.Text = "Delete Product";
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.AutoRoundedCorners = true;
            this.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddProduct.FillColor = System.Drawing.Color.SlateGray;
            this.BtnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProduct.ForeColor = System.Drawing.Color.White;
            this.BtnAddProduct.Location = new System.Drawing.Point(16, 366);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(130, 29);
            this.BtnAddProduct.TabIndex = 8;
            this.BtnAddProduct.Text = "Add Product";
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.AntiqueWhite;
            this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductList.ColumnHeadersHeight = 15;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.UnitPrice,
            this.Category});
            this.dgvProductList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductList.GridColor = System.Drawing.Color.Black;
            this.dgvProductList.Location = new System.Drawing.Point(16, 64);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.Size = new System.Drawing.Size(504, 267);
            this.dgvProductList.TabIndex = 7;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductList.ThemeStyle.BackColor = System.Drawing.Color.Snow;
            this.dgvProductList.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvProductList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProductList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProductList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductList.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvProductList.ThemeStyle.ReadOnly = true;
            this.dgvProductList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dgvProductList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProductList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProductList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProductList.Location = new System.Drawing.Point(13, 10);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(113, 23);
            this.lblProductList.TabIndex = 6;
            this.lblProductList.Text = "Product List";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panProductList);
            this.Controls.Add(this.panProductDetails);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.panProductDetails.ResumeLayout(false);
            this.panProductDetails.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).EndInit();
            this.panProductList.ResumeLayout(false);
            this.panProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panProductDetails;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtProductID;
        private System.Windows.Forms.Label lblSalesmanId;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Panel panProductList;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteProduct;
        private Guna.UI2.WinForms.Guna2Button BtnAddProduct;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductList;
        private System.Windows.Forms.Label lblProductList;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox12;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}