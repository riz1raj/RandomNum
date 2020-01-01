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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int icount = 0;
        

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

       

        private void Button1_Click_1(object sender, EventArgs e)
        {


            
            String b = textBox1.Text.ToString();

            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            b = randomNumber.ToString();
            if (b == textBox1.Text)
            {

               label5.Text = "Yes ....!!!! The Number is " + b + " You Win";


                {
                    icount = icount + 5;


                    label4.Text = "Your Point's :" + icount.ToString();



                }

                

            }
            else
            {
                label5.Text = "NO ....!!!! The Number is " + b + " You Lost";
                {
                    icount = icount - 2;


                    label4.Text = "Your Point's :" + icount.ToString();



                }
               
            }
            


        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
