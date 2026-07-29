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
    public partial class ManageEmployee : Form
    {

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public ManageEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateManagerID();
        }

        private void PopulateGridView(string sql = "select * from Manager;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvManagerrList.AutoGenerateColumns = false;
            this.dgvManagerrList.DataSource = this.Ds.Tables[0];
        }

        private void GenerateManagerID()
        {
            this.Sql = "select * from Manager order by ManagerID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            string ManagerID = Dt.Rows[0]["ManagerID"].ToString();
            string[] str = ManagerID.Split('-');
            int n = Convert.ToInt32(str[1]);
            string newManagerID = "MA-" + (++n).ToString("d4");
            this.txtManagerrID.Text = newManagerID;

        }

        private void ClearAll()
        {
            this.txtManagerrID.Clear();
            this.txtManagerrID.ReadOnly = true;
            this.txtManagerrName.Clear();
            this.txtManagerrPhone.Clear();
            this.txtSalary.Clear();
            this.txtPass.Clear();
            GenerateManagerID();
        }


        private void ManageEmployee_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddMoustomer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "Select * from Manager where ManagerID = '" + this.txtManagerrID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update Manager
                   set Name = '" + this.txtManagerrName.Text + @"',
                   Phone = '" + this.txtManagerrPhone.Text + @"',
                   Salary = '" + this.txtSalary.Text + @"',
                   Password = '" + this.txtPass.Text + @"'
                   where ManagerID = '" + this.txtManagerrID.Text + "';";
                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Manager Updated Successfully.");
                        this.PopulateGridView();

                    }
                    else
                    {
                        MessageBox.Show("Manager Updation Failed.");
                    }
                }
                else
                {
                    this.Sql = @"insert into Manager
                    values('" + this.txtManagerrID.Text + "','" + this.txtManagerrName.Text + "','" + this.txtManagerrPhone.Text + "','" + this.txtSalary.Text + "','" + this.txtPass.Text + "');";

                    int count = this.Da.ExecuteUpdate(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Manager Added Successfully.");
                        this.GenerateManagerID();

                    }
                    else
                    {
                        MessageBox.Show("Manager Insertion Failed.");
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

        private void BtnDeleteManagerr_Click(object sender, EventArgs e)
        {
            try
            {
                string managerID = this.dgvManagerrList.CurrentRow.Cells["ManagerID"].Value.ToString();
                string managerName = this.dgvManagerrList.CurrentRow.Cells["ManagerName"].Value.ToString();

                this.Sql = @"delete from Manager where ManagerID = '" + managerID + "';";
                int count = this.Da.ExecuteUpdate(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Manager " + managerName + " Deleted Successfully.");

                }
                else
                {
                    MessageBox.Show("Manager Deletion Failed.");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured. " + exc.Message);
            }

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

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void dgvManagerrList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManagerrList.CurrentRow != null)
            {
                try
                {
                    this.txtManagerrID.ReadOnly = true;
                    this.txtManagerrID.Text = dgvManagerrList.CurrentRow.Cells["ManagerID"].Value?.ToString();
                    this.txtManagerrName.Text = dgvManagerrList.CurrentRow.Cells["ManagerName"].Value?.ToString();
                    this.txtManagerrPhone.Text = dgvManagerrList.CurrentRow.Cells["ManagerPhone"].Value?.ToString();
                    this.txtSalary.Text = dgvManagerrList.CurrentRow.Cells["ManagerSalary"].Value?.ToString();
                    this.txtPass.Text = dgvManagerrList.CurrentRow.Cells["Password"].Value?.ToString();
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

        private void lblManageSalesmans_Click(object sender, EventArgs e)
        {
            ManageSalesman s = new ManageSalesman();
            this.Hide();
            s.Show();
        }
    }
}
