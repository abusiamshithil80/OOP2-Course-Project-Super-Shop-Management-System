using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ProductDetails : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }


        public ProductDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateProductID();
        }

        private void PopulateGridView(string sql = "select * from Product;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvProductList.AutoGenerateColumns = false;
            this.dgvProductList.DataSource = this.Ds.Tables[0];
        }

        private void GenerateProductID()
        {
            this.Sql = "select * from Product order by ProductID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string ProductID = Dt.Rows[0]["ProductID"].ToString();
            string[] str = ProductID.Split('r');
            int n = Convert.ToInt32(str[1]);
            string newProductID = "Pr" + (++n).ToString("d3");
            this.txtProductID.Text = newProductID;

        }

        private void ClearAll()
        {
            this.txtProductID.Clear();
            this.txtProductID.ReadOnly = true;
            this.txtProductName.Clear();
            this.txtQuantity.Clear();
            this.txtUnitPrice.Clear();
            this.cmbCategory.SelectedIndex = -1; ;
            GenerateProductID();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
        }



        private void lblBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "Select * from Product where ProductID = '" + this.txtProductID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update Product
                   set ProductName = '" + this.txtProductName.Text + @"',
                   Quantity = '" + this.txtQuantity.Text + @"',
                   UnitPrice = '" + this.txtUnitPrice.Text + @"',
                   Category = '" + this.cmbCategory.Text + @"'
                   where ProductID = '" + this.txtProductID.Text + "';";
                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Product Updated Successfully.");
                        this.PopulateGridView();

                    }
                    else
                    {
                        MessageBox.Show("Product Updation Failed.");
                    }
                }
                else
                {
                    this.Sql = @"insert into Product
                    values('" + this.txtProductID.Text + "','" + this.txtProductName.Text + "','" + this.txtQuantity.Text + "','" + this.txtUnitPrice.Text + "','" + this.cmbCategory.Text + "');";

                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Product Added Successfully.");
                        this.GenerateProductID();

                    }
                    else
                    {
                        MessageBox.Show("Product Insertion Failed.");
                    }

                    this.PopulateGridView();
                    this.ClearAll();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string productID = this.dgvProductList.CurrentRow.Cells["ProductID"].Value.ToString();
                string productName = this.dgvProductList.CurrentRow.Cells["ProductName"].Value.ToString();

                this.Sql = @"delete from Product where ProductID = '" + productID + "';";
                int count = this.Da.ExecuteUpdate(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Product " + ProductName + " Deleted Successfully.");

                }
                else
                {
                    MessageBox.Show("Product Deletion Failed.");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductList.CurrentRow != null)
            {
                try
                {
                    this.txtProductID.ReadOnly = true;
                    this.txtProductID.Text = dgvProductList.CurrentRow.Cells["ProductID"].Value?.ToString();
                    this.txtProductName.Text = dgvProductList.CurrentRow.Cells["ProductName"].Value?.ToString();
                    this.txtQuantity.Text = dgvProductList.CurrentRow.Cells["Quantity"].Value?.ToString();
                    this.txtUnitPrice.Text = dgvProductList.CurrentRow.Cells["UnitPrice"].Value?.ToString();
                    this.cmbCategory.Text = dgvProductList.CurrentRow.Cells["Category"].Value?.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Product details:" + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
