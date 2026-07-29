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
    public partial class ManageCoustomer : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public ManageCoustomer()
        {

            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateCoustomerID();
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



        private void ManageCoustomer_Load(object sender, EventArgs e)
        {

        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
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

       
        private void dgvCoustomerList_DoubleClick(object sender, EventArgs e)
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

        private void lblAdminDashboard_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void lblManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee ee = new ManageEmployee();
            this.Hide();
            ee.Show();
        }

        private void lblAdminDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Show();
        }
    }
}
