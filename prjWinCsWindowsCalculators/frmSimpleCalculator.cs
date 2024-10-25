using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsWindowsCalculators
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        double firstNumber, secondNumber, result;
        bool adittion, substraction, multiplication, division, porcentage, square, squareRoot, inverse, secondNumberActive, resultActive;

        private void btntwo_Click(object sender, EventArgs e)
        {
            insertNumber("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            insertNumber("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            insertNumber("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            insertNumber("5");
        }

        private void btnEigth_Click(object sender, EventArgs e)
        {
            insertNumber("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            insertNumber("9");
        }

        private void operationToMake (String operation)
        {
            //Case: We already operated an operation before (pressed btnResult) so, seconNumber is filled and now, we want to continue the
            //operation *** additioning or subtracting or multiplication or division, etc...*** 
            // and make que last result the firstnumber and the next numbers to insert be the sencond number for the operation.
            if (firstNumberActive && secondNumber != 0)
            {
                firstNumber = result;
                result = 0;
                secondNumber = 0;
                firstNumberActive = false;
                secondNumberActive = true;
                lblVisor.Text = "0";
                lblOperation.Text = operation + result.ToString();
            }
            //  Case: we have first numebr setted and second number watting to be filled
            else if (firstNumberActive && secondNumber == 0)
            {
                firstNumberActive = false;
                secondNumberActive = true;
                lblVisor.Text = "0";

            }
            // Case: we want to some*** more than just 2 numbers.
            // *** additioning or subtracting or multiplication or division, etc...
            else if (secondNumberActive && firstNumber != 0)
            {
                firstNumber = firstNumber + secondNumber;
                secondNumber = 0;
                lblVisor.Text = "0";
            }
        }

        private void btnAdition_Click(object sender, EventArgs e)
        {
            operationToMake(" + ");
            adittion = true;
            substraction = multiplication = division = porcentage = square = squareRoot = inverse = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            if (adittion)
            {
                result = firstNumber + secondNumber;
            }
            else if (substraction)
            {
                result = firstNumber - secondNumber;
            }
            else if (multiplication)
            {
                result = firstNumber * secondNumber;
            }
            else if (division)
            {
                result = firstNumber / secondNumber;
            }
            /*else if (square)
            {
                result = firstName^2;
            }
            else if (squareRoot)
            {
                result = firstNumer^(1/2);
            }
            else if (inverse)
            {
                result = 1 / firstNumber;
            }*/

            lblVisor.Text = result.ToString();
            secondNumberActive = false;
            firstNumberActive = true;

        }

        private void lblOperation_Click(object sender, EventArgs e)
        {

        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            operationToMake(" - ");
            substraction = true;
            adittion = multiplication = division = porcentage = square = squareRoot = inverse = false;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operationToMake(" * ");
            multiplication = true;
            adittion = substraction = division = porcentage = square = squareRoot = inverse = false;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operationToMake(" / ");
            division = true;
            adittion = substraction = multiplication = porcentage = square = squareRoot = inverse = false;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            operationToMake(" ²√ ");
            squareRoot = true;
            adittion = substraction = multiplication = porcentage = square = division = inverse = false;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            operationToMake(" x² ");
            square = true;
            adittion = substraction = multiplication = porcentage = squareRoot = division = inverse = false;
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            operationToMake(" 1/ ");
            inverse = true;
            adittion = substraction = multiplication = porcentage = squareRoot = division = square = false;
        }

        private void btnC_Rese_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            secondNumberActive = false;
            firstNumberActive = true;
            result = 0;
            number = "0";
            adittion = substraction = multiplication = porcentage = squareRoot = division = square = inverse = false;
            lblVisor.Text = "0";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            insertNumber("0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            if (resultActive && firstNumberActive)
            {
                return;
            }
            else if (double.Parse(lblVisor.Text) == firstNumber && firstNumberActive)
            {
                int totalSize = firstNumber.ToString().Length;

                if (totalSize > 1)
                {
                    number = firstNumber.ToString().Substring(0, totalSize - 1);
                    firstNumber = double.Parse(number);
                    lblVisor.Text = number.ToString();
                }
                else
                {
                    firstNumber = 0;
                    lblVisor.Text = "0";
                }
            }
            else if (double.Parse(lblVisor.Text) == secondNumber && secondNumberActive)
            {
                int totalSize = secondNumber.ToString().Length;

                if (totalSize > 1)
                {
                    number = secondNumber.ToString().Substring(0, totalSize - 1);
                    secondNumber = double.Parse(number);
                    lblVisor.Text = number.ToString();
                }
                else
                {
                    secondNumber = 0;
                    lblVisor.Text = "0";
                }
            }

        }

        bool firstNumberActive = true;
        string number;

        private void insertNumber(string numberToAdd)
        {
            if (firstNumberActive && double.Parse(lblVisor.Text) == 0)
            {
                firstNumber = double.Parse(numberToAdd);
                lblVisor.Text = numberToAdd;

            }
            else if (firstNumberActive && double.Parse(lblVisor.Text) != 0)
            {
                number = firstNumber.ToString() + numberToAdd;
                firstNumber = double.Parse(number);
                lblVisor.Text = number;

            }
            else if (secondNumberActive && double.Parse(lblVisor.Text) == 0)
            {
                secondNumber = double.Parse(numberToAdd);
                lblVisor.Text = numberToAdd;
            }
            else if (secondNumberActive && double.Parse(lblVisor.Text) != 0)
            {
                number = secondNumber.ToString() + numberToAdd;
                secondNumber = double.Parse(number);
                lblVisor.Text = number;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            insertNumber("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //made all borders of buttons size 0. You can se the code in the file frmSimpleCalculator.Designer.cs
            //website font :https://www.reddit.com/r/csharp/comments/kfw7op/how_to_change_the_border_style_in_c_forms_with/?tl=pt-br
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            insertNumber("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertNumber("6");
        }
    }
}
