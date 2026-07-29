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

    public partial class GenaratedBill : Form
    {
        private readonly DataAccess Da;
        private DataSet Ds;
        private readonly string Sql;
        private string salesmanId ;
        private string salesmanName;
        private string coustomerId;
        private string coustomerName;
        private string cartId;
        private string date;
        private string totalBill;
        private string discount;
        private string netTotal;
        //private string salesmanId;


        public GenaratedBill()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Sql = "SELECT TOP 1 * FROM NewSoldDetails ORDER BY CartID DESC;";
            this.Ds = this.Da.ExecuteQuery(this.Sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                if (this.Ds.Tables[0].Rows[0]["CoustomerID"].ToString() != "")
                {
                    coustomerId = Convert.ToString(this.Ds.Tables[0].Rows[0]["CoustomerID"].ToString());
                }

                if (this.Ds.Tables[0].Rows[0]["CoustomerName"].ToString() != "")
                {
                    coustomerName = Convert.ToString(this.Ds.Tables[0].Rows[0]["CoustomerName"].ToString());
                }

                if (this.Ds.Tables[0].Rows[0]["SalesmanName"].ToString() != "")
                {
                    salesmanName = Convert.ToString(this.Ds.Tables[0].Rows[0]["SalesmanName"].ToString());
                }

                if (this.Ds.Tables[0].Rows[0]["SalesmanID"].ToString() != "")
                {
                    salesmanId = Convert.ToString(this.Ds.Tables[0].Rows[0]["SalesmanID"].ToString());
                }

                if (this.Ds.Tables[0].Rows[0]["GrandTotal"].ToString() != "")
                {
                    totalBill = Convert.ToString(this.Ds.Tables[0].Rows[0]["GrandTotal"].ToString());
                }

                if (this.Ds.Tables[0].Rows[0]["Date"].ToString() != "")
                {
                    date = Convert.ToString(this.Ds.Tables[0].Rows[0]["Date"].ToString());
                }

                if (this.Ds.Tables[0].Rows[0]["CartID"].ToString() != "")
                {
                    cartId = Convert.ToString(this.Ds.Tables[0].Rows[0]["CartID"].ToString());
                }

            }
            discount = Convert.ToDouble(totalBill) * 0.05 + "";
            netTotal = Convert.ToDouble(totalBill) - Convert.ToDouble(discount) + "";
            //lblShowTotalSale.Text = "Taka : " + grandGrandTotal.ToString("0.00");
            lblShowSalesmanID.Text = salesmanId;
            lblShowCoustomerID.Text = coustomerId;
            lblShowCoustomerName.Text = coustomerName;
            lblShowDate.Text = date;
            lblShowTotalBill.Text = "Taka : " + totalBill;
            lblShowSalesmanName.Text = salesmanName;
            lblShowDiscount.Text = "Taka : " + discount;
            lblShowNetTotal.Text = "Taka : " + netTotal;
            lblShowCartID.Text = cartId;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SalesMan s = new SalesMan(salesmanName, salesmanId);
            this.Hide();
            s.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You don't have printer.Go and buy -_- .");
        }
    }
}
