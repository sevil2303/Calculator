using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class Form1
    {
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Text != "")
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

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Text != "")
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

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Text != "")
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
                else
                {
                    throw new Exception("You have to write number before operator");
                }
            }
            catch
            {

            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Text != "")
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
    }
}
