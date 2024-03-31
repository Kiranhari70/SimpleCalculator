using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        string CalcTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn5.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn1.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void btnMultply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(Display.Text);
            if(option.Equals("+"))
                result = num1 +num2;
            if(option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if(option.Equals("/"))
                result = num1 / num2;

            Display.Text = result + "";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            Display.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
