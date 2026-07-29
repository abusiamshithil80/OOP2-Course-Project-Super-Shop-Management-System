using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string op ;
        private double num1, num2, result;
        public Form1()
        {
            InitializeComponent();

         

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }   

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2"; 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "00";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
            if (op == "+") 
            { 
            result = num1 + num2;
            txtDisplay.Text = result.ToString();
            }

            else if (op == "-")
            {
                result = num1 - num2;
                txtDisplay.Text = result.ToString();
            }

            else if (op == "/")
            {
                result = num1 / num2;
                txtDisplay.Text = result.ToString();
            }

            else if (op == "*")
            {
                result = num1 * num2;
                txtDisplay.Text = result.ToString();
            }

            else if( op == "%")
            {
                //num2 = 1;
                result = num1 * (num2 / 100);
                txtDisplay.Text = result.ToString();
            }




        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            
            op = "-";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnParcent_Click(object sender, EventArgs e)
        {
            op = "%";
            num1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }
        
        public void Clalulation()
        {
            if (op == "+")
            {
               
            }
        }
        


    }


}
