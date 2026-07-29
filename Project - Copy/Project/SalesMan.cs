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
    public partial class SalesMan : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        

        public SalesMan(string salesmanname, string salesmanid)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            PopulateCoustomerGridView();
            PopulateSoldProductGridView();
            GenerateCartID();
            this.salesManID = salesmanid;
            this.salesManName = salesmanname;
            this.lblShowSalesmanName.Text = salesManName;
        }

        private string coustomerID;
        private string coustomerName;
        private string salesManID;
        private string salesManName;
        private double grandTotal;
        private string cartID;

        private void PopulateGridView(string sql = "select * from Product;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvProductList.AutoGenerateColumns = false;
            this.dgvProductList.DataSource = this.Ds.Tables[0];
        }

        private void PopulateSoldProductGridView(string sql = "select * from SoldProduct;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = this.Ds.Tables[0];
        }

        private void PopulateCoustomerGridView(string sql = "select * from CoustomerNew;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvCoustomerList.AutoGenerateColumns = false;
            this.dgvCoustomerList.DataSource = this.Ds.Tables[0];
        }

        private void GenerateCartID()
        {
            this.Sql = "select * from NewSoldDetails order by CartID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string CartID = Dt.Rows[0]["CartID"].ToString();
            string[] str = CartID.Split('r');
            int n = Convert.ToInt32(str[1]);
            string newCartID = "Cr" + (++n).ToString("d3");
            this.cartID = newCartID;

        }


        private void ClearAll()
        {
            
            
            this.txtSearchProductName.Clear();
            this.txtQuantity.Clear();
            this.cmbCategory.SelectedIndex = -1; ;
           // GenerateProductID();
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Product where ProductName like '" + this.txtSearchProductName.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Product where Category= '" + this.cmbCategory.Text + "'";
            this.PopulateGridView(this.Sql);
        }

        private string productID;
        private string productName;
        private double unitPrice;
        private double totalPrice;

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductList.CurrentRow != null)
            {
                try
                {
                    this.txtQuantity.Text = dgvProductList.CurrentRow.Cells["Quantity"].Value?.ToString();
                    this.productID = dgvProductList.CurrentRow.Cells["ProductID"].Value?.ToString();
                    this.productName = dgvProductList.CurrentRow.Cells["ProductName"].Value?.ToString();
                    this.unitPrice = Convert.ToDouble(dgvProductList.CurrentRow.Cells["UnitPrice"].Value?.ToString());
                    //this.totalPrice = this.unitPrice * Convert.ToDouble(this.txtQuantity.Text);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Product details:" + ex.Message);
                }
            }
        }
       
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                
                string stockQuery = $"select Quantity from Product where ProductID = '{this.productID}'";
                DataTable dtStock = this.Da.ExecuteQueryTable(stockQuery);

                if (dtStock.Rows.Count == 0)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                int stockQuantity = Convert.ToInt32(dtStock.Rows[0]["Quantity"]);
                int requestedQuantity = Convert.ToInt32(this.txtQuantity.Text);

                
                string checkQuery = $"select Quantity from SoldProduct where ProductID = '{this.productID}'";
                DataTable dtCart = this.Da.ExecuteQueryTable(checkQuery);

                if (dtCart.Rows.Count > 0)
                {
                    
                    int existingQuantity = Convert.ToInt32(dtCart.Rows[0]["Quantity"]);
                    int newQuantity = existingQuantity + requestedQuantity;

                    if (newQuantity > stockQuantity)
                    {
                        MessageBox.Show("Requested quantity exceeds available stock.");
                        return;
                    }

                    double newTotalPrice = newQuantity * this.unitPrice;
                    string updateSql = $"update SoldProduct set Quantity = {newQuantity}, TotalPrice = {newTotalPrice} where ProductID = '{this.productID}'";
                    int count = this.Da.ExecuteUpdate(updateSql);

                    if (count == 1)
                    {
                        MessageBox.Show("Product quantity updated in cart.");
                        this.PopulateSoldProductGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product in cart.");
                    }
                }
                else
                {
                   
                    if (requestedQuantity > stockQuantity)
                    {
                        MessageBox.Show("Requested quantity exceeds available stock.");
                        return;
                    }

                    this.Sql = @"insert into SoldProduct
                        values( '" + this.productID + "', '" + this.productName + "','" + this.txtQuantity.Text + "', '" + this.unitPrice + "', '" + this.unitPrice * requestedQuantity + "');";

                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Product Added Successfully.");
                        this.PopulateSoldProductGridView();
                    }
                    else
                    {
                        MessageBox.Show("Product Insertion Failed.");
                    }
                }

                this.txtQuantity.Clear();
                this.cmbCategory.SelectedIndex = -1;
                this.PopulateSoldProductGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGridView();
        }

        private void txtCoustomerSearchPhone_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from CoustomerNew where Phone like '" + this.txtCoustomerSearchPhone.Text + "%';";
            this.PopulateCoustomerGridView(this.Sql);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            this.txtCoustomerSearchPhone.Clear();
            this.PopulateCoustomerGridView();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                string productID = this.dgvCart.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                string productName = this.dgvCart.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                this.Sql = @"delete from SoldProduct where ProductID = '" + productID + "';";
                int count = this.Da.ExecuteUpdate(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Product " + ProductName + " Deleted Successfully.");

                }
                else
                {
                    MessageBox.Show("Product Deletion Failed.");
                }
                this.PopulateSoldProductGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private void btnClearCustomerCart_Click(object sender, EventArgs e)
        {
            try
            {
                //string productID = this.dgvCart.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                //string productName = this.dgvCart.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                this.Sql = @"delete from SoldProduct;";
                int count = this.Da.ExecuteUpdate(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Clear Cart.");

                }
                else
                {
                    MessageBox.Show("Product Deletion Failed.");
                }
                this.PopulateSoldProductGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private double GetGrandTotal()
        {
            double grandTotal = 0.0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["TPrice"].Value != null &&
                    double.TryParse(row.Cells["TPrice"].Value.ToString(), out double total))
                {
                    grandTotal += total;
                }
            }

            return grandTotal;
        }

        

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.coustomerID == null || this.coustomerName == null)
                {
                    this.coustomerID = "Guest";
                    this.coustomerName = "Guest";
                }


                this.Sql = @"insert into NewSoldDetails
                values( '" + this.cartID + "','" + this.coustomerID + "', '" + this.coustomerName + "','" + this.salesManID + "', '" + this.salesManName + "', '" + GetGrandTotal() + "', '" + DateTime.Now.ToString() + "');";

                int count = this.Da.ExecuteUpdate(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Bill Genarate Successfull.");
                    // this.GenerateProductID();
                    this.updateStock();

                    try
                    {
                        //string productID = this.dgvCart.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                        //string productName = this.dgvCart.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                        this.Sql = @"delete from SoldProduct;";
                        int cnt = this.Da.ExecuteUpdate(this.Sql);
                        if (cnt == 1)
                        {
                            MessageBox.Show("Clear Cart.");

                        }
                        else
                        {
                            MessageBox.Show("Product Deletion Failed.");
                        }
                        this.PopulateSoldProductGridView();
                        this.ClearAll();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has occured. " + exc.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Failed.");
                }

                //this.PopulateSoldProductGridView();
                //this.ClearAll();


            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }

            GenaratedBill g = new GenaratedBill();
            this.Hide();
            g.Show();
            //this.updateStock();

        }

       

        public void updateStock()
        {
            try
            {
               // string productID = this.dgvCart.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                string sql = "select * from SoldProduct ;";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                foreach (DataRow row in dt.Rows)
                {
                    string productId = row["ProductID"].ToString();
                    int quantitySold = Convert.ToInt32(row["Quantity"]);
                    string updateSql = "update Product set Quantity = Quantity - " + quantitySold + " where ProductID = '" + productId + "';";
                    int count = this.Da.ExecuteUpdate(updateSql);
                    if (count != 1)
                    {
                        MessageBox.Show("Failed to update stock for Product ID: " + productId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating stock: " + ex.Message);
            }
        }

        private void dgvCoustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCoustomerList.CurrentRow != null)
            {
                try
                {
                   
                    this.coustomerID = dgvCoustomerList.CurrentRow.Cells["CId"].Value?.ToString();
                    this.coustomerName = dgvCoustomerList.CurrentRow.Cells["CName"].Value?.ToString();
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Coustomer details:" + ex.Message);
                }
            }
        }
    }
}
