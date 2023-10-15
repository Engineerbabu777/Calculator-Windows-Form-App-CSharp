using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "1";
            }
            else
            {
                ResultField.Text = ResultField.Text + "1";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "2";
            }
            else
            {
                ResultField.Text = ResultField.Text + "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "5";
            }
            else
            {
                ResultField.Text = ResultField.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "6";
            }
            else
            {
                ResultField.Text = ResultField.Text + "6";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "7";
            }
            else
            {
                ResultField.Text = ResultField.Text + "7";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "8";
            }
            else
            {
                ResultField.Text = ResultField.Text + "8";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "9";
            }
            else
            {
                ResultField.Text = ResultField.Text + "9";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
                ResultField.Text = ResultField.Text + "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "3";
            }
            else
            {
                ResultField.Text = ResultField.Text + "3";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ResultField.Text == "0" && ResultField.Text != null)
            {
                ResultField.Text = "4";
            }
            else
            {
                ResultField.Text = ResultField.Text + "4";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(ResultField.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                ResultField.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                ResultField.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                ResultField.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    ResultField.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    ResultField.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(ResultField.Text);
            ResultField.Text = "0";
            Operation = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(ResultField.Text);
            ResultField.Text = "0";
            Operation = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(ResultField.Text);
            ResultField.Text = "0";
            Operation = "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(ResultField.Text);
            ResultField.Text = "0";
            Operation = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ResultField.Text = "0";
        }
    }
}
