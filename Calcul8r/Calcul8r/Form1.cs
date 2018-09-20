using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul8r
{
    public partial class Form1 : Form
    {

        //holding two variables for simple operations
        public double val1;
        public double val2;
        //char denoting current math operation
        public char op;
        // determines if the current var, already has a decimal, to prevent placing two
        bool decplaced = false;


        public Form1()
        {
            InitializeComponent();
        }

        /*   this region holds click events for the basic numeral buttons,
              *   and updates to numDisplay.Text
              * */
        #region numberKeys
       
        private void btn1_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numDisplay.Text = numDisplay.Text + "0";
        }
        #endregion numberKeys


     

        private void btnequals_Click(object sender, EventArgs e)
        {
            if (numDisplay.Text != "")
            {
                val2 = Double.Parse(numDisplay.Text);

                switch (op)
                {
                    case '+':
                        numDisplay.Text = "" + (val1 + val2);
                        break;
                    case '-':
                        numDisplay.Text = "" + (val1 - val2);
                        break;
                    case 'x':
                        numDisplay.Text = "" + (val1 * val2);
                        break;
                    case '/':
                        numDisplay.Text = "" + (val1 / val2);
                        break;

                }

                tbequation.Text += val2+" = ";
               op = ' ';
                val1 = val2 = 0;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            val1 = val2 = 0;
            tbequation.Text = "";
        }
        private void btndec_Click(object sender, EventArgs e)
        {
            if (!decplaced)
            {
                decplaced = true;
                numDisplay.Text = numDisplay.Text + ".";
            }
        }

        /*   this region holds click events for the operation buttons(+,-,/,x),
             *   they set char 'op' and updates to numDisplay.Text
             * */
        #region opKeys
        private void btnplus_Click(object sender, EventArgs e)
        {
            if (numDisplay.Text != "")
            {
                val1 = Double.Parse(numDisplay.Text);
                numDisplay.Text = "";
                op = '+';
                decplaced = false;
                tbequation.Text += val1 + " + ";
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (numDisplay.Text != "")
            {
                val1 = Double.Parse(numDisplay.Text);
                numDisplay.Text = "";
                op = '-';
                decplaced = false;
                tbequation.Text += val1+" - ";
            }
        }

       
        private void btntimes_Click(object sender, EventArgs e)
        {
            if (numDisplay.Text != "")
            {
                val1 = Double.Parse(numDisplay.Text);
                numDisplay.Text = "";
                op = 'x';
                decplaced = false;
                tbequation.Text += val1+" x ";
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (numDisplay.Text != "")
            {
                val1 = Double.Parse(numDisplay.Text);
                numDisplay.Text = "";
                op = '/';
                decplaced = false;
                tbequation.Text += val1+" / ";
            }
        }
        #endregion opKeys   


    }
}
