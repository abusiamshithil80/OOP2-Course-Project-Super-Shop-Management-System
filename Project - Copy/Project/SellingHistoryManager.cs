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
    public partial class SellingHistoryManager : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public string ManagerName;

        public SellingHistoryManager(string managername)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            this.ManagerName = managername;
        }

        private void PopulateGridView(string sql = "select * from NewSoldDetails;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvSoldDetails.AutoGenerateColumns = false;
            this.dgvSoldDetails.DataSource = this.Ds.Tables[0];
        }


        private void btnBack_Click(object sender, EventArgs e)
        {

            Manager ma = new Manager(ManagerName);
            this.Hide();
            ma.Show();
        }
    }
}
