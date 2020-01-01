using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class MyCalc : Form
    {
        double FirstNumber;
        string Operation;
        public MyCalc()
        {

            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "6";
            }
            else
            {
                numbox.Text = numbox.Text + "6";
            }
        }

        private void No0_Click(object sender, EventArgs e)
        {

            {
                numbox.Text = numbox.Text + "0";
            }
        }

        private void No1_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "1";
            }
            else
            {
                numbox.Text = numbox.Text + "1";
            }
        }

        private void No2_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "2";
            }
            else
            {
                numbox.Text = numbox.Text + "2";
            }
        }

        private void No3_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "3";
            }
            else
            {
                numbox.Text = numbox.Text + "3";
            }
        }

        private void No4_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "4";
            }
            else
            {
                numbox.Text = numbox.Text + "4";
            }
        }

        private void No5_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "5";
            }
            else
            {
                numbox.Text = numbox.Text + "5";
            }
        }

        private void No7_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "7";
            }
            else
            {
                numbox.Text = numbox.Text + "7";
            }
        }

        private void No8_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "8";
            }
            else
            {
                numbox.Text = numbox.Text + "8";
            }
        }

        private void No9_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "0" && numbox.Text != null)
            {
                numbox.Text = "9";
            }
            else
            {
                numbox.Text = numbox.Text + "9";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(numbox.Text);
            numbox.Text = "0";
            Operation = "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(numbox.Text);
            numbox.Text = "0";
            Operation = "-";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(numbox.Text);
            numbox.Text = "0";
            Operation = "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(numbox.Text);
            numbox.Text = "0";
            Operation = "/";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            numbox.Text = numbox.Text + ".";
        }


        private void Equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(numbox.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                numbox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                numbox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                numbox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    numbox.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    numbox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            numbox.Text = String.Empty;

        }
    }
   
}

