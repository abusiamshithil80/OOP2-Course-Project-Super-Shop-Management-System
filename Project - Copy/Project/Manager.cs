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
    public partial class Manager : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public string Managername;
        private double grandGrandTotal = 0;
        private double todayGrandTotal = 0;


        public Manager(string managername )
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateCoustomerID();
            PopulateSalesmanGridView();
            GenerateSalesmanID();
            PopulateProductGridView();
            GenerateProductID();
            panNewManagerDashboard.BringToFront();
            this.Managername = managername;
            this.lblShowManagerName.Text = managername;

            string grandTotalSql = "SELECT SUM(GrandTotal) AS GrandTotall FROM NewSoldDetails";
            DataSet dsGrandTotal = this.Da.ExecuteQuery(grandTotalSql);

            if (dsGrandTotal.Tables[0].Rows.Count == 1)
            {
                if (dsGrandTotal.Tables[0].Rows[0]["GrandTotall"].ToString() != "")
                {
                    grandGrandTotal = Convert.ToDouble(dsGrandTotal.Tables[0].Rows[0]["GrandTotall"].ToString());
                }
            }
            lblShowTotalSaleFromManager.Text = "Taka : " + grandGrandTotal.ToString("0.00");

            string todayTotalSql = "SELECT SUM(GrandTotal) AS TodayGrandTotall FROM NewSoldDetails WHERE CAST([Date] AS DATE) = CAST(GETDATE() AS DATE)";
            DataSet dsTodayTotal = this.Da.ExecuteQuery(todayTotalSql);

            if (dsTodayTotal.Tables[0].Rows.Count == 1)
            {
                if (dsTodayTotal.Tables[0].Rows[0]["TodayGrandTotall"].ToString() != "")
                {
                    todayGrandTotal = Convert.ToDouble(dsTodayTotal.Tables[0].Rows[0]["TodayGrandTotall"].ToString());
                }
            }
            lblShowTodaySale.Text = "Taka : " + todayGrandTotal.ToString("0.00");

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

        private void PopulateProductGridView(string sql = "select * from Product;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvProductList.AutoGenerateColumns = false;
            this.dgvProductList.DataSource = this.Ds.Tables[0];
        }

        private void PopulateSalesmanGridView(string sql = "select * from Salesman;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvSalesmanList.AutoGenerateColumns = false;
            this.dgvSalesmanList.DataSource = this.Ds.Tables[0];
        }


        private void ClearAllSalesman()
        {
            this.txtSalesmanID.Clear();
            this.txtSalesmanID.ReadOnly = true;
            this.txtSalesmanName.Clear();
            this.txtSalesmanPhone.Clear();
            this.txtSalary.Clear();
            this.txtPass.Clear();
            GenerateSalesmanID();
        }


        private void ClearAllProduct()
        {
            this.txtProductID.Clear();
            this.txtProductID.ReadOnly = true;
            this.txtProductName.Clear();
            this.txtQuantity.Clear();
            this.txtUnitPrice.Clear();
            this.cmbCategory.SelectedIndex = -1; ;
            GenerateProductID();
        }


        private void GenerateSalesmanID()
        {
            this.Sql = "select * from Salesman order by SalesmanID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string SalesmanID = Dt.Rows[0]["SalesmanID"].ToString();
            string[] str = SalesmanID.Split('-');
            int n = Convert.ToInt32(str[1]);
            string newSalesmanID = "SA-" + (++n).ToString("d4");
            this.txtSalesmanID.Text = newSalesmanID;

        }

        private void PopulateGridView(string sql = "select * from CoustomerNew;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvCoustomerList.AutoGenerateColumns = false;
            this.dgvCoustomerList.DataSource = this.Ds.Tables[0];
        }

        private void GenerateCoustomerID()
        {
            this.Sql = "select * from CoustomerNew order by CoustomerID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string CoustomerID = Dt.Rows[0]["CoustomerID"].ToString();
            string[] str = CoustomerID.Split('C');
            int n = Convert.ToInt32(str[1]);
            string newCoustomerID = "C" + (++n).ToString("d4");
            this.txtCoustomerID.Text = newCoustomerID;

        }

        private void ClearAll()
        {
            this.txtCoustomerID.Clear();
            this.txtCoustomerID.ReadOnly = true;
            this.txtCoustomerName.Clear();
            this.cmbArea.SelectedIndex = -1;
            this.txtCoustomerPhone.Clear();
            GenerateCoustomerID();
        }



        private void lblSignOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
            
        }

        private void Manager_Load(object sender, EventArgs e)
        {
           // panManagerDashboard.Show();
        }

        private void lblManagerDhashBoardd_Click(object sender, EventArgs e)
        {
            panNewManagerDashboard.Show();
            panManageCoustomers.Hide();
            panManageSalesmans.Hide();
            panProductdetails.Hide();
        }

        private void lblManageCoustomersFromManager_Click(object sender, EventArgs e)
        {
            panManageCoustomers.Show();
            panNewManagerDashboard.Hide();
            panManageSalesmans.Hide();
            panProductdetails.Hide();
        }

        private void btnAddCoustomer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "Select * from CoustomerNew where CoustomerID = '" + this.txtCoustomerID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update coustomerNew
                   set Name = '" + this.txtCoustomerName.Text + @"',
                   Area = '" + this.cmbArea.Text + @"',
                   Phone = '" + this.txtCoustomerPhone.Text + @"'
                   where CoustomerID = '" + this.txtCoustomerID.Text + "';";
                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Coustomer Updated Successfully.");
                        this.PopulateGridView();

                    }
                    else
                    {
                        MessageBox.Show("Coustomer Updation Failed.");
                    }
                }
                else
                {
                    this.Sql = @"insert into CoustomerNew
                    values('" + this.txtCoustomerID.Text + "','" + this.txtCoustomerName.Text + "','" + this.txtCoustomerPhone.Text + "','" + this.cmbArea.Text + "');";

                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Coustomer Added Successfully.");
                        this.GenerateCoustomerID();

                    }
                    else
                    {
                        MessageBox.Show("Coustomer Insertion Failed.");
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

        private void btnDeleteCoustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string coustomerID = this.dgvCoustomerList.CurrentRow.Cells["CoustomerID"].Value.ToString();
                string coustomerName = this.dgvCoustomerList.CurrentRow.Cells["colName"].Value.ToString();

                this.Sql = @"delete from CoustomerNew where CoustomerID = '" + coustomerID + "';";
                int count = this.Da.ExecuteUpdate(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Coustomer " + coustomerName + " Deleted Successfully.");

                }
                else
                {
                    MessageBox.Show("Coustomer Deletion Failed.");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void dgvCoustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCoustomerList.CurrentRow != null)
            {
                try
                {
                    this.txtCoustomerID.ReadOnly = true;
                    this.txtCoustomerID.Text = dgvCoustomerList.CurrentRow.Cells["CoustomerID"].Value?.ToString();
                    this.txtCoustomerName.Text = dgvCoustomerList.CurrentRow.Cells["colName"].Value?.ToString();
                    this.txtCoustomerPhone.Text = dgvCoustomerList.CurrentRow.Cells["Phone"].Value?.ToString();
                    this.cmbArea.Text = dgvCoustomerList.CurrentRow.Cells["Area"].Value?.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Coustomer details:" + ex.Message);
                }
            }
        }

        private void lblManageManagers_Click(object sender, EventArgs e)
        {
            panManageSalesmans.Show();
            panNewManagerDashboard.Hide();
            panManageCoustomers.Hide();
            panProductdetails.Hide();
        }

        private void lblSalesmanDetails_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteSalesman_Click(object sender, EventArgs e)
        {
            try
            {
                string salesmanID = this.dgvSalesmanList.CurrentRow.Cells["SalesmanID"].Value.ToString();
                string salesmanName = this.dgvSalesmanList.CurrentRow.Cells["SalesmanName"].Value.ToString();

                this.Sql = @"delete from Salesman where SalesmanID = '" + salesmanID + "';";
                int count = this.Da.ExecuteUpdate(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Salesman " + salesmanName + " Deleted Successfully.");

                }
                else
                {
                    MessageBox.Show("Salesman Deletion Failed.");
                }
                this.PopulateSalesmanGridView();
                this.ClearAllSalesman();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private void BtnAddSalesman_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "Select * from Salesman where SalesmanID = '" + this.txtSalesmanID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update Salesman
                   set Name = '" + this.txtSalesmanName.Text + @"',
                   Phone = '" + this.txtSalesmanPhone.Text + @"',
                   Salay = '" + this.txtSalary.Text + @"',
                   Password = '" + this.txtPass.Text + @"'
                   where SalesmanID = '" + this.txtSalesmanID.Text + "';";
                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Salesman Updated Successfully.");
                        this.PopulateSalesmanGridView();

                    }
                    else
                    {
                        MessageBox.Show("Salesman Updation Failed.");
                    }
                }
                else
                {
                    this.Sql = @"insert into Salesman
                    values('" + this.txtSalesmanID.Text + "','" + this.txtSalesmanName.Text + "','" + this.txtSalesmanPhone.Text + "','" + this.txtSalary.Text + "','" + this.txtPass.Text + "');";

                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Salesman Added Successfully.");
                        this.GenerateSalesmanID();

                    }
                    else
                    {
                        MessageBox.Show("Salesman Insertion Failed.");
                    }

                    this.PopulateSalesmanGridView();
                    this.ClearAllSalesman();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private void btnClearSalesmanDetails_Click(object sender, EventArgs e)
        {
            this.ClearAllSalesman();
        }

        private void dgvSalesmanList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSalesmanList.CurrentRow != null)
            {
                try
                {
                    this.txtSalesmanID.ReadOnly = true;
                    this.txtSalesmanID.Text = dgvSalesmanList.CurrentRow.Cells["SalesmanID"].Value?.ToString();
                    this.txtSalesmanName.Text = dgvSalesmanList.CurrentRow.Cells["SalesmanName"].Value?.ToString();
                    this.txtSalesmanPhone.Text = dgvSalesmanList.CurrentRow.Cells["SalesmanPhone"].Value?.ToString();
                    this.txtSalary.Text = dgvSalesmanList.CurrentRow.Cells["Salary"].Value?.ToString();
                    this.txtPass.Text = dgvSalesmanList.CurrentRow.Cells["Password"].Value?.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Manager details:" + ex.Message);
                }
            }
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
                        this.PopulateProductGridView();
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

                    this.PopulateProductGridView();
                    this.ClearAllProduct();
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
                this.PopulateProductGridView();
                this.ClearAllProduct();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
        }

        private void btnClearProductDetails_Click(object sender, EventArgs e)
        {
            this.ClearAllProduct();
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

        

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProductDetailsFromManager_Click(object sender, EventArgs e)
        {
            panProductdetails.Show();
            panNewManagerDashboard.Hide();
            panManageCoustomers.Hide();
            panManageSalesmans.Hide();
        }

        private void lblSignOut_Click_1(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            SellingHistoryManager shm = new SellingHistoryManager(Managername);
            this.Hide();
            shm.Show();
        }

        private void lblShowTotalSaleFromManager_Click(object sender, EventArgs e)
        {

        }
    }
}
