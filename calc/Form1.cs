using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class FormCalc : Form
    {
        double num1, num2, resultado;
        bool operacao = true;
        string calcular;
        
        public FormCalc()
        {
            InitializeComponent();
        }
        private void Btncle_Click(object sender, EventArgs e)
        {
            txtbox2.Clear();
            txtbox2.Text = btn0.Text;
        }
        private void Btnbac_Click(object sender, EventArgs e)
        {
            int x = txtbox2.Text.Length - 1;
            if(x >= 0)
            {
                txtbox2.Text = txtbox2.Text.Substring(0, x);
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if(operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn1.Text;
                operacao = false;
            }
            else if (txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn1.Text;
            }
            else if(txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn1.Text;
            }
        }        
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn2.Text;
                operacao = false;
            }
            else if (txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn2.Text;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn2.Text;
            }
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn3.Text;
                operacao = false;
            }
            else if (txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn3.Text;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn3.Text;
            }
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            if (operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn4.Text;
                operacao = false;
            }
            else if (txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn4.Text;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn4.Text;
            }
        }        
        private void Btn5_Click(object sender, EventArgs e)
        {
            if (operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn5.Text;
                operacao = false;
            }
            else if (txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn5.Text;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn5.Text;
            }
        }        
        private void Btn6_Click(object sender, EventArgs e)
        {
            if (operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn6.Text;
                operacao = false;
            }
            else if (txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn6.Text;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn6.Text;
            }
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            if (operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn7.Text;
                operacao = false;
            }
            else if (txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn7.Text;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn7.Text;
            }
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            if (operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn8.Text;
                operacao = false;
            }
            else if (txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn8.Text;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn8.Text;
            }
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            if (operacao && txtbox2.Text.Length <= 8)
            {
                txtbox2.Text = btn9.Text;
                operacao = false;
            }
            else if(txtbox2.Text == "0")
            {
                txtbox2.Clear();
                txtbox2.Text += btn9.Text;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn9.Text;
            }
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            if(txtbox2.Text == "0")
            {
                return;
            }
            else if(txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btn0.Text;
            }
        }
        private void Btnvirg_Click(object sender, EventArgs e)
        {
            if(txtbox2.Text == "")
            {
                return;
            }
            else if (txtbox2.Text.Contains(","))
            {
                return;
            }
            else if (txtbox2.Text.Length <= 7)
            {
                txtbox2.Text += btnvirg.Text;
            }
        }
        private void Btnadi_Click(object sender, EventArgs e)
        {
            if(calcular == "*" || calcular == "-" || calcular == "/")
            {
                calcular = "+";
            }
            else if (txtbox2.Text == "")
            {
                return;
            }
            else
            {
                num1 += double.Parse(txtbox2.Text);
                txtbox1.Text = txtbox2.Text;
                txtbox3.Text = "+";
                txtbox2.Text = "";
                calcular = "+";
            }
        }
        private void Btnsub_Click(object sender, EventArgs e)
        {
            if (calcular == "*" || calcular == "+" || calcular == "/")
            {
                calcular = "-";
            }
            else if(txtbox2.Text == "")
            {
                return;
            }
            else
            {
                num1 += double.Parse(txtbox2.Text);
                txtbox1.Text = txtbox2.Text;
                txtbox3.Text = "-";
                txtbox2.Text = "";
                calcular = "-";
            }
        }
        private void Btnmult_Click(object sender, EventArgs e)
        {
            if (calcular == "-" || calcular == "+" || calcular == "/")
            {
                calcular = "*";
            }
            else if (txtbox2.Text == "")
            {
                return;
            }
            else
            {
                num1 += double.Parse(txtbox2.Text);
                txtbox1.Text = txtbox2.Text;
                txtbox3.Text = "x";
                txtbox2.Text = "";
                calcular = "*";
            }
        }
        private void Btndiv_Click(object sender, EventArgs e)
        {
            if (calcular == "-" || calcular == "+" || calcular == "*")
            {
                calcular = "/";
            }
            else if (txtbox2.Text == "")
            {
                return;
            }
            else
            {
                num1 += double.Parse(txtbox2.Text);
                txtbox1.Text = txtbox2.Text;
                txtbox3.Text = "÷";
                txtbox2.Text = "";
                calcular = "/";
            }
        }
        private void Btnig_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtbox1.Text);
            num2 = Convert.ToDouble(txtbox2.Text);
            operacao = true;
            switch (calcular)
            {
                case "+":
                    {
                        resultado = num1 + num2;
                        txtbox1.Clear();
                        txtbox3.Clear();
                        txtbox2.Text = resultado.ToString();
                        break;
                    }
                case "-":
                    {
                        resultado = num1 - num2;
                        txtbox1.Clear();
                        txtbox3.Clear();
                        txtbox2.Text = resultado.ToString();
                        break;
                    }
                case "*":
                    {
                        resultado = num1 * num2;
                        txtbox1.Clear();
                        txtbox3.Clear();
                        txtbox2.Text = resultado.ToString();
                        break;
                    }
                case "/":
                    {
                        if(double.Parse(txtbox2.Text) != 0)
                        {
                            resultado = num1 / num2;
                            txtbox1.Clear();
                            txtbox3.Clear();
                            txtbox2.Text = resultado.ToString();
                            break;
                        }
                        else
                        {
                            txtbox2.Text = "0";
                            break;
                        }
                    }
            }
        }
    }
}
