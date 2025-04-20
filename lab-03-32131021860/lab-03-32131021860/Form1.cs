using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03_32131021860
{
    public partial class CaculatorForm : Form
    {
        public CaculatorForm()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                resultLabel.Text += button.Text;
            }
        }

        private void Operater_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {

                resultLabel.Text += button.Text;
            }


        }

        public bool isNumber<T>(T s)
        {
            int result = 0;
            if (int.TryParse(s.ToString(), out result))
            {
                return true;
            }
            else return false;
        }

        public double Caculate()
        {
            List<string> output = new List<string>();
            Stack<string > stack = new Stack<string>();
            string tem = "";
           

            for(int i = 0;i<resultLabel.Text.Length; i++)
            {
                if (i==0 && !isNumber(resultLabel.Text[i]))
                {
                    if (resultLabel.Text[i].ToString() == "-" || resultLabel.Text[i].ToString() == "+")
                        tem += resultLabel.Text[i];
                    else
                    {
                        continue;
                    }
                }
                else if (isNumber(resultLabel.Text[i]))
                {
                    tem += resultLabel.Text[i];
                }
                else
                {
                    stack.Push(resultLabel.Text[i].ToString());
                    output.Add(tem);
                    tem = "";
                }
            }
            output.Add(tem);


            while (stack.Count != 0)
            {
                output.Add(stack.Pop());
            }


            foreach(string s in output)
            {
                Console.Write(s);
            }


            Stack<double> ressult = new Stack<double>();

            double final = 0;
            foreach (string s in output)
            {
                if (isNumber(s))
                {
                    ressult.Push(double.Parse(s));
                }
                else
                {
                    double a = ressult.Pop();
                    double b = ressult.Pop();
                    if (s == "+")
                    {
                        final = a + b;
                    }
                    else if (s == "-")
                    {
                        final = b - a;
                    }
                    else if (s == "*")
                    {
                        final = a * b;
                    }
                    else if (s == "/")
                    {
                        final = b / a;
                    }
                    ressult.Push(final);
                }
            }
            final = ressult.Pop();
            return final;

        }

        private void Others_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Text == "CE" && resultLabel.Text != "")
                {

                    /*resultLabel.Text.Remove(resultLabel.Text[resultLabel.Text.Length]);*/
                    resultLabel.Text = resultLabel.Text.Remove(resultLabel.Text.Length - 1);
                }
                else if (button.Text == "C")
                {
                    resultLabel.Text = "";
                }
                else if (button.Text == "=")
                {
                    resultLabel.Text = Caculate().ToString();
                    
                }
            }
        }


    }
}
