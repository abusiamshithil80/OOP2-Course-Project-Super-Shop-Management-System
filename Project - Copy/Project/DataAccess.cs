using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    internal class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-JLUK7DQ\SQLEXPRESS;Initial Catalog=Project;Persist Security Info=True;User ID=sa;Password=134160");
            this.Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message); // Show the error
                return null;
            }
        }

        public DataTable ExecuteQueryTable (string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        public int ExecuteUpdate(string sql)
        {
            this.QueryText(sql);
            int u = this.sqlcom.ExecuteNonQuery();
            return u;
        }
    }    
}
