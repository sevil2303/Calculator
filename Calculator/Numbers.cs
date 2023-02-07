using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class Form1
    {
        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "" || textBtn.Text == "0")
            {
                zeroCounter++;
                if (zeroCounter == 1)
                {
                    textBtn.Text += 0;
                    infoLbl.Text += 0;
                }

            }
            else
            {
                textBtn.Text += 0;
                infoLbl.Text += 0;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "0")
            {
                textBtn.Text = "1";
                infoLbl.Text = "1";
            }
            else
            {
                textBtn.Text += 1;
                infoLbl.Text += 1;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "0")
            {
                textBtn.Text = "2";
                infoLbl.Text = "2";
            }
            else
            {
                textBtn.Text += 2;
                infoLbl.Text += 2;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "0")
            {
                textBtn.Text = "3";
                infoLbl.Text = "3";
            }
            else
            {
                textBtn.Text += 3;
                infoLbl.Text += 3;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "0")
            {
                textBtn.Text = "4";
                infoLbl.Text = "4";
            }
            else
            {
                textBtn.Text += 4;
                infoLbl.Text += 4;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {

            if (textBtn.Text == "0")
            {
                textBtn.Text = "5";
                infoLbl.Text = "5";

            }
            else
            {
                textBtn.Text += 5;
                infoLbl.Text += 5;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "0")
            {
                textBtn.Text = "6";
                infoLbl.Text = "6";
            }
            else
            {
                textBtn.Text += 6;
                infoLbl.Text += 6;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "0")
            {
                textBtn.Text = "7";
                infoLbl.Text = "7";
            }
            else
            {
                textBtn.Text += 7;
                infoLbl.Text += 7;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "0")
            {
                textBtn.Text = "8";
                infoLbl.Text = "8";
            }
            else
            {
                textBtn.Text += 8;
                infoLbl.Text += 8;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "0")
            {
                textBtn.Text = "9";
                infoLbl.Text = "9";
            }
            else
            {
                textBtn.Text += 9;
                infoLbl.Text += 9;
            }
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
    }
}
