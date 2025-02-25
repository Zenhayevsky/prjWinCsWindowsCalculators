﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        bool adittion, substraction, multiplication, division, porcentage, secondNumberActive, resultActive;

        bool firstNumberActive = true;
        string number;
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

        private void operationToMake(String operation)
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
                lblOperation.Text = firstNumber.ToString() + operation;
            }
            //  Case: we have first numebr setted and second number watting to be filled
            else if (firstNumberActive && secondNumber == 0)
            {
                firstNumberActive = false;
                secondNumberActive = true;
                lblVisor.Text = "0";
                lblOperation.Text = firstNumber.ToString() + operation;
            }
            // Case: we want to some*** more than just 2 numbers.
            // *** additioning or subtracting or multiplication or division, etc...
            else if (secondNumberActive && firstNumber != 0)
            {

                if (adittion)
                {
                    firstNumber = firstNumber + secondNumber;
                }
                else if (substraction)
                {
                    firstNumber = firstNumber - secondNumber;
                }
                else if (multiplication)
                {
                    firstNumber = firstNumber * secondNumber;
                }
                if (division)
                {
                    firstNumber = firstNumber / secondNumber;
                }

                lblVisor.Text = "0";
                secondNumber = 0;
                lblOperation.Text = firstNumber.ToString() + operation;

            }
        }

        private void btnAdition_Click(object sender, EventArgs e)
        {
            //setting the visor and preparing the program to recive the second number
            operationToMake(" + ");
            //setting the opperation to make when pressed the equal button
            adittion = true;
            //making sure all the others booleans that indicate opperations, are turned into False
            substraction = multiplication = division = porcentage = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //chosing the operation to make
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

            lblVisor.Text = result.ToString();
            secondNumberActive = false;
            firstNumberActive = true;
            lblOperation.Text = lblOperation.Text + secondNumber.ToString();

        }

        private void lblOperation_Click(object sender, EventArgs e)
        {

        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            operationToMake(" - ");
            substraction = true;
            adittion = multiplication = division = porcentage = false;

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operationToMake(" * ");
            multiplication = true;
            adittion = substraction = division = porcentage = false;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operationToMake(" / ");
            division = true;
            adittion = substraction = multiplication = false;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (firstNumberActive)
            {
                firstNumber = Math.Sqrt(firstNumber);
                lblOperation.Text = lblOperation.Text + firstNumber.ToString();
                lblVisor.Text = firstNumber.ToString();

            }
            if (secondNumberActive)
            {
                secondNumber = Math.Sqrt(firstNumber);
                lblOperation.Text = lblOperation.Text + secondNumber.ToString();
                lblVisor.Text = secondNumber.ToString();

            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {

            if (firstNumberActive)
            {
                firstNumber = firstNumber * firstNumber;
                lblOperation.Text = lblOperation.Text + firstNumber.ToString();
                lblVisor.Text = firstNumber.ToString();

            }
            if (secondNumberActive)
            {
                secondNumber = secondNumber * secondNumber;
                lblOperation.Text = lblOperation.Text + secondNumber.ToString();
                lblVisor.Text = secondNumber.ToString();

            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            if (firstNumberActive)
            {
                firstNumber = 1 / firstNumber;
                lblOperation.Text = lblOperation.Text + firstNumber.ToString();
                lblVisor.Text = firstNumber.ToString();

            }
            if (secondNumberActive)
            {
                secondNumber = 1 / secondNumber;
                lblOperation.Text = lblOperation.Text + secondNumber.ToString();
                lblVisor.Text = secondNumber.ToString();

            }
        }

        private void btnC_Rese_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            secondNumberActive = false;
            firstNumberActive = true;
            result = 0;
            number = "0";
            adittion = substraction = multiplication = porcentage = false;
            lblVisor.Text = "0";
            lblOperation.Text = "";
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

        private void btnClearLastCE_Click(object sender, EventArgs e)
        {
            if (firstNumberActive)
            {
                firstNumber = 0;
                lblVisor.Text = "0";
            }
            else
            {
                secondNumber = 0;
                lblVisor.Text = "0";
            }
        }

        private void frmSimpleCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnPlusToMinus_Click(object sender, EventArgs e)
        {
            if (firstNumberActive)
            {
                firstNumber = firstNumber * (-1);
                lblVisor.Text = firstNumber.ToString();

            }
            if (secondNumberActive)
            {
                secondNumber = secondNumber * (-1);
                lblVisor.Text = secondNumber.ToString();

            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (firstNumberActive && !lblVisor.Text.Contains("."))
            {
                lblVisor.Text = firstNumber.ToString() + ".";
            }
            else if (secondNumberActive && !lblVisor.Text.Contains("."))
            {
                lblVisor.Text = secondNumber.ToString() + ".";
            }
        }

        private void insertNumber(string numberToAdd)
        {
            //Case: time to insert first number and no number has been inserted before.
            if (firstNumberActive && double.Parse(lblVisor.Text) == 0)
            {
                firstNumber = double.Parse(numberToAdd);
                lblVisor.Text = numberToAdd;

            }
            //Case: time to insert the firstnumber but there is already a firstnumber started
            else if (firstNumberActive && double.Parse(lblVisor.Text) != 0)
            {
                if (lblVisor.Text.Contains("."))
                {
                    number = firstNumber.ToString() + "." + numberToAdd;
                    firstNumber = double.Parse(number);
                    lblVisor.Text = number;

                }
                else
                {
                    number = firstNumber.ToString() + numberToAdd;
                    firstNumber = double.Parse(number);
                    lblVisor.Text = number;
                }

            }
            //Time to insert second number and no number has been inserted to start it
            else if (secondNumberActive && double.Parse(lblVisor.Text) == 0)
            {
                secondNumber = double.Parse(numberToAdd);
                lblVisor.Text = numberToAdd;
            }
            //Case: time to insert the firstnumber but there is already a firstnumber started
            else if (secondNumberActive && double.Parse(lblVisor.Text) != 0)
            {
                if (lblVisor.Text.Contains("."))
                {
                    number = secondNumber.ToString() + "." + numberToAdd;
                    secondNumber = double.Parse(number);
                    lblVisor.Text = number;

                }
                else
                {
                    number = secondNumber.ToString() + numberToAdd;
                    secondNumber = double.Parse(number);
                    lblVisor.Text = number;
                }
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
            if (firstNumberActive)
            {
                firstNumber = 0;
                lblVisor.Text = "0";
                lblOperation.Text = "0";

            }
            else if (secondNumberActive && (adittion || substraction))
            {
                secondNumber = firstNumber * secondNumber / 100;
                lblVisor.Text = secondNumber.ToString();
            }
            else if(secondNumberActive && (division || multiplication))
            {
                secondNumber = secondNumber/100;
                lblVisor.Text = secondNumber.ToString();
            }
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
