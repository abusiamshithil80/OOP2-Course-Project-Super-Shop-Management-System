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
    public partial class Dashboard : Form
    {
        private readonly DataAccess Da;
        private DataSet Ds;
        private readonly string Sql;
        private double grandGrandTotal = 0;
        private double todayGrandTotal = 0;

        public Dashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            
            string grandTotalSql = "SELECT SUM(GrandTotal) AS GrandTotall FROM NewSoldDetails";
            DataSet dsGrandTotal = this.Da.ExecuteQuery(grandTotalSql);

            if (dsGrandTotal.Tables[0].Rows.Count == 1)
            {
                if (dsGrandTotal.Tables[0].Rows[0]["GrandTotall"].ToString() != "")
                {
                    grandGrandTotal = Convert.ToDouble(dsGrandTotal.Tables[0].Rows[0]["GrandTotall"].ToString());
                }
            }
            lblShowTotalSale.Text = "Taka : " + grandGrandTotal.ToString("0.00");

            
            string todayTotalSql = "SELECT SUM(GrandTotal) AS TodayGrandTotall FROM NewSoldDetails WHERE CAST([Date] AS DATE) = CAST(GETDATE() AS DATE)";
            DataSet dsTodayTotal = this.Da.ExecuteQuery(todayTotalSql);

            if (dsTodayTotal.Tables[0].Rows.Count == 1)
            {
                if (dsTodayTotal.Tables[0].Rows[0]["TodayGrandTotall"].ToString() != "")
                {
                    todayGrandTotal = Convert.ToDouble(dsTodayTotal.Tables[0].Rows[0]["TodayGrandTotall"].ToString());
                }
            }
            lblShowTodayGrandTotal.Text = "Taka : " + todayGrandTotal.ToString("0.00");
        }

        

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void panLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblManageCoustomer_Click(object sender, EventArgs e)
        {
            ManageCoustomer m = new ManageCoustomer();
            this.Hide();
            m.Show();
        }

        private void lblManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee E = new ManageEmployee();
            this.Hide();
            E.Show();
        }

        private void lblManageSalesman_Click(object sender, EventArgs e)
        {
            ManageSalesman s = new ManageSalesman();
            this.Hide();
            s.Show();

        }

        private void panProductDetails_Paint(object sender, PaintEventArgs e)
        {
            //ProductDetails p = new ProductDetails();
            //this.Hide();
            //p.Show();
        }

        private void lblProductDetails_Click(object sender, EventArgs e)
        {
            ProductDetails p = new ProductDetails();
            this.Hide();
            p.Show();
        }

        private void lblTotalSale_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            SellingHistory sh = new SellingHistory();
            this.Hide();
            sh.Show();
        }

        private void lblShowTotalSale_Click(object sender, EventArgs e)
        {

        }
    }
}
