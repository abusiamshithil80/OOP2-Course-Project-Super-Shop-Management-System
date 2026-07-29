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
    public partial class Form1 : Form
    {
        public string salesmanName;
        public string salesmanId;
        public string managerName;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDurShwapno_Click(object sender, EventArgs e)
        {

        }

        private void lblUserId_Click(object sender, EventArgs e)
        {

        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You forgot, that's your fault. Try to remember '_'");
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == false)
            {
                guna2TxtPass.UseSystemPasswordChar = true;
            }
            else
            {
                guna2TxtPass.UseSystemPasswordChar = false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (guna2TxtUserId.Text == "")
            {
                MessageBox.Show("User ID can't be empty");
                return;
            }

            bool loginSuccess = false;

            
            string sql = @"select * from SignUp where UserID = '" + this.guna2TxtUserId.Text + "' and Password = '" + this.guna2TxtPass.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
            {
                Dashboard d = new Dashboard();
                this.Hide();
                d.Show();
                loginSuccess = true;
                return;
            }

            
            sql = @"select * from Salesman where SalesmanID = '" + this.guna2TxtUserId.Text + "' and Password = '" + this.guna2TxtPass.Text + "';";
            ds = da.ExecuteQuery(sql);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
            {
                if (ds.Tables[0].Rows[0]["Name"].ToString() != "")
                {
                    salesmanName = Convert.ToString(ds.Tables[0].Rows[0]["Name"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SalesmanID"].ToString() != "")
                {
                    salesmanId = Convert.ToString(ds.Tables[0].Rows[0]["SalesmanID"].ToString());
                }

                SalesMan s = new SalesMan(salesmanName, salesmanId);
                this.Hide();
                s.Show();
                loginSuccess = true;
                return;
            }

            
            sql = @"select * from Manager where ManagerID = '" + this.guna2TxtUserId.Text + "' and Password = '" + this.guna2TxtPass.Text + "';";
            ds = da.ExecuteQuery(sql);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
            {
                if (ds.Tables[0].Rows[0]["Name"].ToString() != "")
                {
                    managerName = Convert.ToString(ds.Tables[0].Rows[0]["Name"].ToString());
                }
                // Manager m = new Manager(managerName);
                NewManger m = new NewManger(managerName);
                this.Hide();
                m.Show();
                loginSuccess = true;
                return;
            }

            
            if (!loginSuccess)
            {
                MessageBox.Show("Invalid User ID or Password");
            }
        }

        
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
