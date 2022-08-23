using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        float num1, num2, result;
        char operation;
        bool dec = false;

        private void changeLabel(int numPressed) 
        {
            if (dec==true)
            {
                int decimalCount = 0;
                foreach (char c in labelDisplay.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    labelDisplay.Text = labelDisplay.Text + ".";
                }
                dec = false;
            }
            else 
            {
                if (labelDisplay.Text.Equals("O") ==true && labelDisplay.Text != null) 
                {
                    labelDisplay.Text = numPressed.ToString();
                }
                else if (labelDisplay.Text.Equals("-0"))
                {
                    labelDisplay.Text = "-" + numPressed.ToString();
                }
                else { labelDisplay.Text = labelDisplay.Text + numPressed.ToString(); }
            }
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            int stringLength = labelDisplay.Text.Length;
            num1 = float.Parse(labelDisplay.Text);
            if (num1 > 0)
                labelDisplay.Text = "-" + labelDisplay.Text;
            else labelDisplay.Text = labelDisplay.Text.Substring(1, stringLength-1);
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void buttonSquareroot_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(labelDisplay.Text);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                labelDisplay.Text = sqrt.ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            int stringLength = labelDisplay.Text.Length;
            if (stringLength > 1)
            {
                labelDisplay.Text = labelDisplay.Text.Substring(0, stringLength - 1);
            }
            else labelDisplay.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(labelDisplay.Text);
            operation = '/';
            labelDisplay.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(labelDisplay.Text);
            operation = '*';
            labelDisplay.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(labelDisplay.Text);
            operation = '-';
            labelDisplay.Text = "";
        }

        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    buttonEquals.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.NumPad0:
                    buttonZero.PerformClick();
                    break;
                case Keys.D0:
                    buttonZero.PerformClick();
                    break;
                case Keys.NumPad1:
                    buttonOne.PerformClick();
                    break;
                case Keys.D1:
                    buttonOne.PerformClick();
                    break;
                case Keys.NumPad2:
                    buttonTwo.PerformClick();
                    break;
                case Keys.D2:
                    buttonTwo.PerformClick();
                    break;
                case Keys.NumPad3:
                    buttonThree.PerformClick();
                    break;
                case Keys.D3:
                    buttonThree.PerformClick();
                    break;
                case Keys.NumPad4:
                    buttonFour.PerformClick();
                    break;
                case Keys.D4:
                    buttonFour.PerformClick();
                    break;
                case Keys.NumPad5:
                    buttonFive.PerformClick();
                    break;
                case Keys.D5:
                    buttonFive.PerformClick();
                    break;
                case Keys.NumPad6:
                    buttonSix.PerformClick();
                    break;
                case Keys.D6:
                    buttonSix.PerformClick();
                    break;
                case Keys.NumPad7:
                    buttonSeven.PerformClick();
                    break;
                case Keys.D7:
                    buttonSeven.PerformClick();
                    break;
                case Keys.NumPad8:
                    buttonEight.PerformClick();
                    break;
                case Keys.D8:
                    buttonEight.PerformClick();
                    break;
                case Keys.NumPad9:
                    buttonNine.PerformClick();
                    break;
                case Keys.D9:
                    buttonNine.PerformClick();
                    break;
                case Keys.Divide:
                    buttonDivide.PerformClick();
                    break;
                case Keys.Subtract:
                    buttonMinus.PerformClick();
                    break;
                case Keys.Add:
                    buttonPlus.PerformClick();
                    break;
                case Keys.Multiply:
                    buttonMultiply.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(labelDisplay.Text);
            operation = '+';
            labelDisplay.Text = "";
        }


        private void buttonEquals_Click(object sender, EventArgs e)
        {
            result = 0;
            if (labelDisplay.Text.Equals("0") == false) 
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(labelDisplay.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(labelDisplay.Text);
                        result = num1 - num2;
                        break;
                    case '*':
                        num2 = float.Parse(labelDisplay.Text);
                        result = num1 * num2;
                        break;
                    case '/':
                        num2 = float.Parse(labelDisplay.Text);
                        result = num1 / num2;
                        break;
                    default:
                        break;

                }    
            }
            labelDisplay.Text = result.ToString();
        }
    }
}
