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
        int clickCounter = 0;
        int operatorCounter = 0;
        double myanswer = 0;
        char myoperator = ' ';
        double first = 0;
        double second = 0;
        int addCounter = 0;
        int subCounter = 0;
        int multCounter = 0;
        int divCounter = 0;
        int zeroCounter = 0;
        char before = ' ';
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            if (before == '+')
            {
                myanswer = first + second;
            }
            else if (before == '-')
            {
                myanswer = first - second;
            }
            else if (before == 'x')
            {
                if (second == 0)
                {
                    second++;
                }
                myanswer = first * second;
            }
            else if (before == '/')
            {
                if (second == 0)
                {
                    second++;
                }
                myanswer = first / second;
            }
        }
        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text == "" || textBtn.Text=="0")
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

        private void plusminusBtn_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                clickCounter = 0;
                textBtn.Text += '.';
                if (textBtn.Text.StartsWith("-"))
                {
                    textBtn.Text = textBtn.Text.Trim('-');
                }
                else
                {
                    textBtn.Text = "-" + textBtn.Text;
                }
            }
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                textBtn.Text += '.';
                infoLbl.Text += '.';
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addCounter++;
            if (addCounter == 1)
            {
                infoLbl.Text += '+';
                if (myoperator != ' ')
                {
                    before = myoperator;
                    myoperator = '+';
                }
                else
                {
                    before = '+';
                    myoperator = '+';
                }
                clickCounter = 0;
                zeroCounter = 0;

                if (operatorCounter == 0)
                {
                    first = double.Parse(textBtn.Text);
                    Calculate();
                }
                else
                {
                    first = myanswer;
                    second = double.Parse(textBtn.Text);
                    Calculate();
                }
                operatorCounter++;
            }
            textBtn.Text = "";
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            subCounter++;
            if (subCounter == 1)
            {
                infoLbl.Text += '-';
                if (myoperator != ' ')
                {
                    before = myoperator;
                    myoperator = '-';
                }
                else
                {
                    before = '-';
                    myoperator = '-';
                }
                clickCounter = 0;
                zeroCounter = 0;

                if (operatorCounter == 0)
                {
                    first = double.Parse(textBtn.Text);
                    Calculate();
                }
                else
                {
                    first = myanswer;
                    second = double.Parse(textBtn.Text);
                    Calculate();
                }
                operatorCounter++;
            }
            textBtn.Text = "";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            multCounter++;           
            if (multCounter == 1)
            {
                infoLbl.Text += 'x';
                if (myoperator != ' ')
                {
                    before = myoperator;
                    myoperator = 'x';
                }
                else
                {
                    before = 'x';
                    myoperator = 'x';
                }
                clickCounter = 0;
                zeroCounter = 0;
                if (operatorCounter == 0)
                {
                    first = double.Parse(textBtn.Text);
                    Calculate();
                }
                else
                {
                    first = myanswer;
                    second = double.Parse(textBtn.Text);
                    Calculate();
                }
                operatorCounter++;
            }
            textBtn.Text = "";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            divCounter++;
            if (divCounter == 1)
            {
                infoLbl.Text += '/';
                if (myoperator != ' ')
                {
                    before = myoperator;
                    myoperator = '/';
                }
                else
                {
                    before = '/';
                    myoperator = '/';
                }

                clickCounter = 0;
                zeroCounter = 0;

                if (operatorCounter == 0)
                {
                    first = double.Parse(textBtn.Text);
                    Calculate();
                }
                else
                {
                    first = myanswer;
                    second = double.Parse(textBtn.Text);
                    Calculate();
                }
                operatorCounter++;
            }
            textBtn.Text = "";
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            clickCounter = 0;
            double myvalue = double.Parse(textBtn.Text);
            var myanswer = Math.Sqrt(myvalue);
            textBtn.Text = myanswer.ToString();
            infoLbl.Text = myanswer.ToString();
        }

        private void equalityBtn_Click(object sender, EventArgs e)
        {
            before = myoperator;
            myoperator = '=';
            clickCounter = 0;
            if (operatorCounter == 1)
            {
                second = double.Parse(textBtn.Text);
                Calculate();
            }
            else
            {
                first = myanswer;
                second = double.Parse(textBtn.Text);
                Calculate();

            }
            operatorCounter = 0;
            textBtn.Text = myanswer.ToString();
            infoLbl.Text = myanswer.ToString();
            myanswer = 0;
            second = 0;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBtn.Text = null;
            infoLbl.Text = null;
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            infoLbl.Text = $"sqr({textBtn.Text})";
            textBtn.Text = (double.Parse(textBtn.Text) * double.Parse(textBtn.Text)).ToString();
        }

        private void dividebyxBtn_Click(object sender, EventArgs e)
        {
            infoLbl.Text = $"1/{textBtn.Text}";
            textBtn.Text = (1 / double.Parse(textBtn.Text)).ToString();
        }

        private void cubeBtn_Click(object sender, EventArgs e)
        {
            infoLbl.Text = $"cube({textBtn.Text})";
            textBtn.Text = (double.Parse(textBtn.Text) * double.Parse(textBtn.Text) * double.Parse(textBtn.Text)).ToString();
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            infoLbl.Text = $"percent({textBtn.Text})";
            textBtn.Text = (double.Parse(textBtn.Text) / 100).ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            textBtn.Text=textBtn.Text.Remove(textBtn.Text.Length - 1, 1);
            infoLbl.Text = textBtn.Text;
        }
    }
}
