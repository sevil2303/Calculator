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
       
        private void plusminusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Text != "")
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
                else
                {
                    throw new Exception("You have to write number before operator");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                if (infoLbl.Text == "")
                {
                textBtn.Text += "0.";
                infoLbl.Text += "0.";
                }
                else
                {
                    textBtn.Text += '.';
                    infoLbl.Text += '.';
                }
            }

        }
  
        private void sqrtBtn_Click(object sender, EventArgs e)
        {
                if (infoLbl.Text != "")
                {
                    clickCounter = 0;
                    double myvalue = double.Parse(textBtn.Text);
                    var myanswer = Math.Sqrt(myvalue);
                    textBtn.Text = myanswer.ToString();
                    infoLbl.Text = myanswer.ToString();
                }
                else
                {
                clickCounter = 0;
                textBtn.Text = "0";
                double myvalue = double.Parse(textBtn.Text);
                var myanswer = Math.Sqrt(myvalue);
                textBtn.Text = myanswer.ToString();
                infoLbl.Text = myanswer.ToString();
            }
        }

        private void equalityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Text != "")
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
                else
                {
                    throw new Exception("You have to write number before operator");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBtn.Text = null;
            infoLbl.Text = null;
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            if (infoLbl.Text != "")
            {
                infoLbl.Text = $"sqr({textBtn.Text})";
                textBtn.Text = (double.Parse(textBtn.Text) * double.Parse(textBtn.Text)).ToString();
            }
            else
            {
                textBtn.Text = "0";
                infoLbl.Text = $"sqr({textBtn.Text})";
                textBtn.Text = (double.Parse(textBtn.Text) * double.Parse(textBtn.Text)).ToString();
            }
        }

        private void dividebyxBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Text != "")
                {
                    infoLbl.Text = $"1/{textBtn.Text}";
                    textBtn.Text = (1 / double.Parse(textBtn.Text)).ToString();
                }
                else
                {
                    throw new Exception("You have to write number before operator");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cubeBtn_Click(object sender, EventArgs e)
        {
            if (infoLbl.Text != "")
            {
                infoLbl.Text = $"cube({textBtn.Text})";
                textBtn.Text = (double.Parse(textBtn.Text) * double.Parse(textBtn.Text) * double.Parse(textBtn.Text)).ToString();
            }
            else
            {
                textBtn.Text = "0";
                infoLbl.Text = $"cube({textBtn.Text})";
                textBtn.Text = (double.Parse(textBtn.Text) * double.Parse(textBtn.Text)).ToString();
            }
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (infoLbl.Text != "")
            {
                infoLbl.Text = $"percent({textBtn.Text})";
                textBtn.Text = (double.Parse(textBtn.Text) / 100).ToString();
            }
            else
            {
                textBtn.Text = "0";
                infoLbl.Text = $"percent({textBtn.Text})";
                textBtn.Text = (double.Parse(textBtn.Text) / 100).ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (textBtn.Text != "")
            {
            textBtn.Text=textBtn.Text.Remove(textBtn.Text.Length - 1, 1);
            infoLbl.Text = textBtn.Text;
            }
            else
            {
                textBtn.Text = "";
                infoLbl.Text = "";
            }
        }
    }
}
