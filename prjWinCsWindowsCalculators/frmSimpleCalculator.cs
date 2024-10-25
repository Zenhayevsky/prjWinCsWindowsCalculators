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
        bool adittion, substraction, multiplication, divisiion, porcentage, square, squareRoot, inverse, secondNumberActive;

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
