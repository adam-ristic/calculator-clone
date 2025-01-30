using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorClone
{
    public partial class Form1 : Form
    {
        // Initialize Variables
        public static double num = 0;
        public static double answer = 0;
        public static string op;
        List<double> numList = new List<double>();

        public Form1()
        {
            InitializeComponent();

            // Align the textbox's text to the right 
            calcDisplay.TextAlign = HorizontalAlignment.Right;
        }

        #region ==== OPERATION METHODS ====

        /* What's happening in all of the following operation methods is that the
         * input in the textbox is being parsed and assigned to a variable,
         * which is then appended to a list.
         * 
         * Finally, when the equals button is hit, the program performs calculations based on what operators were assigned. */

        // Percentage Button
        private void quitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        // Clearing the numbers entered as well as the display
        private void clearButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Clear(); // Clear the textbox
            numList.Clear(); // Clear the number list
            num = 0; // Reset the num variable just in case (Not sure if it's needed but it doesn't hurt to keep it)
        }

        // Clear the textbox's content one character at a time
        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (calcDisplay.TextLength > 0)
            {
                calcDisplay.Text = calcDisplay.Text.Remove(calcDisplay.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("There's nothing to erase!");
            }
        }

        // Prepare for Division
        private void divideButton_Click(object sender, EventArgs e)
        {
            try // Try parsing a double
            {
                numList.Clear(); // Clear list in case of existing numbers
                num = double.Parse(calcDisplay.Text);
                numList.Add(num);
                calcDisplay.Clear();
            }
            catch (FormatException) // Give a warning if not a double
            {
                MessageBox.Show("An invalid character was entered!");
                calcDisplay.Clear();
            }

            // Assign an operator
            op = "division";

        }

        // Prepare for Multiplication
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try // Try parsing a double
            {
                numList.Clear(); // Clear list in case of existing numbers
                num = double.Parse(calcDisplay.Text);
                numList.Add(num);
                calcDisplay.Clear();
            }
            catch (FormatException) // Give a warning if not a double
            {
                MessageBox.Show("An invalid character was entered!");
                calcDisplay.Clear();
            }

            // Assign an operator
            op = "multiplication";

        }

        // Prepare for Subtraction
        private void subtractButton_Click(object sender, EventArgs e)
        {
            try // Try parsing a double
            {
                numList.Clear(); // Clear list in case of existing numbers
                num = double.Parse(calcDisplay.Text);
                numList.Add(num);
                calcDisplay.Clear();
            }
            catch (FormatException) // Give a warning if not a double
            {
                MessageBox.Show("An invalid character was entered!");
                calcDisplay.Clear();
            }

            // Assign an operator
            op = "subtraction";

        }

        // Prepare for Addition
        private void addButton_Click(object sender, EventArgs e)
        {
            try // Try parsing a double
            {
                numList.Clear(); // Clear list in case of existing numbers
                num = double.Parse(calcDisplay.Text);
                numList.Add(num);
                calcDisplay.Clear();
            }
            catch (FormatException) // Give a warning if not a double
            {
                MessageBox.Show("An invalid character was entered!");
                calcDisplay.Clear();
            }

            // Assign an operator
            op = "addition";

        }

        // Perform the final calculations and display the answers
        private void equalsButton_Click(object sender, EventArgs e)
        {
            try // Try parsing the final number
            {
                num = double.Parse(calcDisplay.Text);
                numList.Add(num);
                calcDisplay.Clear();
            }
            catch (FormatException) // Give warning if not possible
            {
                MessageBox.Show("An invalid character was entered!");
                calcDisplay.Clear();
            }

            // Perform the calculations based on what operator was assigned earlier
            if (op == "addition")
            {
                answer = numList.Sum(); // Add the contents of the list together
                calcDisplay.Text = answer.ToString(); 

            }
            else if (op == "subtraction")
            {
                answer = numList.Aggregate((a, x) => a - x); // Subtract contents of list
                calcDisplay.Text = answer.ToString();
            }
            else if (op == "multiplication")
            {
                answer = numList.Aggregate((a, x) => a * x); // Multiply contents of list
                calcDisplay.Text = answer.ToString();
            }
            else if (op == "division")
            {
                answer = numList.Aggregate((a, x) => a / x); // Divide contents of list
                calcDisplay.Text = answer.ToString();
            }
        }

        #endregion

        #region ==== NUMBER BUTTON METHODS ====

        private void dotButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + ".";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + "9";
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
