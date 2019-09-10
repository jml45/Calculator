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
    public partial class CalculatorFrm : Form
    {

        string calcStr;
        char theOperator = ' ';
        double number;
        bool isDecimal;
        bool isEqual = true;
        public CalculatorFrm()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e) //9 button
        {
            if (isEqual) //checks to see if equals was the last button pressed. It is set to default as true
            {
                calcLbl.Text = "";
                isEqual = false; 
            }
            calcLbl.Text = calcLbl.Text + 9;
            
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }

            calcLbl.Text = calcLbl.Text + 7;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }
            calcLbl.Text = calcLbl.Text + 3;
            
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }
            calcLbl.Text = calcLbl.Text + 8;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }
            calcLbl.Text = calcLbl.Text + 4;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }
            calcLbl.Text = calcLbl.Text + 5;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }
            calcLbl.Text = calcLbl.Text + 2;
            
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }
            calcLbl.Text = calcLbl.Text + 1;
            
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }
            calcLbl.Text = calcLbl.Text + 0;
            
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                calcLbl.Text = "";
                isEqual = false;
            }
            calcLbl.Text = calcLbl.Text + 6;
            
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if (theOperator != ' ') //checks to see if multiple operators have been called before equals eg. 2+4+6+8
            {
                equalsBtn_Click(sender, e); //sends it to the switch case if it has
            }
            number = Double.Parse(calcLbl.Text); //stores the text in the calc label as a double
            calcLbl.Text = "";
            isDecimal = false; //resets the decial checker so the next number can have a decimal
            theOperator = '/'; 
            operationLbl.Text = number + " " + theOperator.ToString(); //concats number and the operator and places it in the label above calc label
        }

        private void backSpaceBtn_Click(object sender, EventArgs e)
        {
            calcStr = calcLbl.Text; //stores the text as a string
            calcLbl.Text = "";
            for (int c = 0; c < calcStr.Length - 1; c++)
            {
                calcLbl.Text = calcLbl.Text + calcStr[c]; //loops through the string to set the label text to the string minus the last char
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            if (theOperator != ' ')
            {
                equalsBtn_Click(sender, e);
            }
            number = Double.Parse(calcLbl.Text);
            calcLbl.Text = "";
            isDecimal = false;
            theOperator = '*';
            operationLbl.Text = number + " " + theOperator.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            calcLbl.Text = " ";
            number = 0;
            //isEqual = false;
            isDecimal = false;
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            if (theOperator != ' ') //allows you to continue the same equation as before using the same numbers without hitting enter
            {
               equalsBtn_Click(sender, e);
            }
            if (calcLbl.Text != "")
            {
                number = Double.Parse(calcLbl.Text);
                calcLbl.Text = "";
                isDecimal = false;
                theOperator = '-';
                operationLbl.Text = number + " " + theOperator.ToString();
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if(theOperator != ' ') //checks to see if multiple operators have been called before equals eg. 2+4+6+8
            {
                equalsBtn_Click(sender, e); //sends it to the switch case if it has
            }
            number = Double.Parse(calcLbl.Text);
            calcLbl.Text = "";
            isDecimal = false;
            theOperator = '+';
            operationLbl.Text = number + " " + theOperator.ToString();
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            switch(theOperator)
            {
                case '+':
                    calcLbl.Text = (number + Double.Parse(calcLbl.Text)).ToString();
                    break;
                case '-':
                    calcLbl.Text = (number - Double.Parse(calcLbl.Text)).ToString();
                    break;
                case '*':
                    calcLbl.Text = (number * Double.Parse(calcLbl.Text)).ToString();
                    break;
                case '/':
                    calcLbl.Text = (number / Double.Parse(calcLbl.Text)).ToString();
                    break;
                default:
                    break;

            }
            theOperator = ' ';
            operationLbl.Text = theOperator.ToString();
            isDecimal = false;
            isEqual = true;
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            if (!isDecimal)
            {
                if (isEqual)
                {
                    calcLbl.Text = "";
                    isEqual = false;
                }
                calcLbl.Text = calcLbl.Text + ".";
            }
            isDecimal = true;
        }

        private void operationLbl_Click(object sender, EventArgs e)
        {
        }

        private void CalculatorFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
