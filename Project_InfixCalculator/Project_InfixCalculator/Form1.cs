using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_InfixCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            TextBox.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            TextBox.Text += "1";
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            TextBox.Text += "2";
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            TextBox.Text += "3";
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            TextBox.Text += "8";
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            TextBox.Text += "7";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            TextBox.Text += "6";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            TextBox.Text += "5";
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            TextBox.Text += "9";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            TextBox.Text += "0";
        }

        private void Button_LeftBrace_Click(object sender, EventArgs e)
        {
            TextBox.Text += "(";
        }

        private void Button_RightBrace_Click(object sender, EventArgs e)
        {
            TextBox.Text += ")";
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            TextBox.Text += "+";
        }

        private void Button_Sub_Click(object sender, EventArgs e)
        {
            TextBox.Text += "-";
        }

        private void Button_Mul_Click(object sender, EventArgs e)
        {
            TextBox.Text += "*";
        }

        private void Button_Div_Click(object sender, EventArgs e)
        {
            TextBox.Text += "/";
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            if (TextBox.TextLength > 0)
            {
                string Temp = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
                TextBox.Text = Temp;
            }
        }

        private void Button_Equal_Click(object sender, EventArgs e)
        {
            string Temp = TextBox.Text;
            int result = EvaluateInfixExpressionClass.evaluate(Temp);
            TextBox.Text = result.ToString();
        }
    }
}
