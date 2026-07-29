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
    public partial class ManageSalesman : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public ManageSalesman()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateSalesmanID();
        }

        private void PopulateGridView(string sql = "select * from Salesman;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvSalesmanList.AutoGenerateColumns = false;
            this.dgvSalesmanList.DataSource = this.Ds.Tables[0];
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

        private void ClearAll()
        {
            this.txtSalesmanID.Clear();
            this.txtSalesmanID.ReadOnly = true;
            this.txtSalesmanName.Clear();
            this.txtSalesmanPhone.Clear();
            this.txtSalary.Clear();
            this.txtPass.Clear();
            GenerateSalesmanID();
        }

        private void ManageSalesman_Load(object sender, EventArgs e)
        {

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
                        this.PopulateGridView();
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

                    this.PopulateGridView();
                    this.ClearAll();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
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
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void LblAdminDhashBoardd_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }

        private void lblManageCoustomers_Click(object sender, EventArgs e)
        {
            ManageCoustomer c = new ManageCoustomer();
            this.Hide();
            c.Show();
        }

        private void lblManageManagers_Click(object sender, EventArgs e)
        {
            ManageEmployee E = new ManageEmployee();
            this.Hide();
            E.Show();
        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }
    }
}
