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
    public partial class HeadTail : Form
    {
        public HeadTail()
        {
            InitializeComponent();
        }
        private static int icount =0;
        private void Button1_Click(object sender, EventArgs e)
        {
           
           

            Random random = new Random();
            int randomNumber = random.Next(0, 2);
             String b = randomNumber.ToString();
            if (randomNumber == 0)
            {

                label3.Text = "Yes ....!!!! You Win";


                {
                    icount = icount + 2;


                    label4.Text = "Your Point's :" + icount.ToString();



                }

                //MessageBox.Show("Yes..!!! You Win \n " +b);

            }
            else
            {
                label3.Text = "NO ....!!!! You Lost";
                {
                    icount = icount - 1;


                    label4.Text = "Your Point's :" + icount.ToString();



                }

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            String b = randomNumber.ToString();
            if (randomNumber == 1)
            {

                label3.Text = "Yes ....!!!! You Win";


                {
                    icount = icount + 2;


                    label4.Text = "Your Point's :" + icount.ToString();



                }

                //MessageBox.Show("Yes..!!! You Win \n " +b);

            }
            else
            {
                label3.Text = "NO ....!!!! You Lost";
                {
                    icount = icount - 1;


                    label4.Text = "Your Point's :" + icount.ToString();



                }

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }
    }
}

