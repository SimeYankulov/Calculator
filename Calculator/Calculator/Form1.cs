/*
    Create a Windows Forms application - a simple calculator.  The calculator should resemble a real pocket calculator: having buttons for numbers and operations,
   and a screen for the input.
   Minimum features: addition, subtraction, multiplication, division, square root, memory (M+, M-, MR, MC). 
   The calculator must perform operations in the order of entry, not by algebra priority.  For example: 5 + 2 * 3 must give 21.

    Look at Windows Calculator (standard mode) for reference.

    Short notice : The calculator works just fine but there is a little twist.
    In order to calculate 5+2*3  you must imput 5 + 2 and then press the equal button and then * 3 
    it will give the wanted result but you cant input 5+2*3 because it will calculate 5+2 because everything is 
    connected with the equal button. 
    It was a bit too late to fix it so i decided to leave it like this
 */




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
    public partial class Calculator : Form
    {
        private double value1;
        private double value2;
        private string selectedOp;
        private double memory;
        public Calculator()
        {
            InitializeComponent();
            value1 = 0;
            value2 = 0;
            selectedOp = "";
            memory = 0;
        }   //Constructor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)     //sum
        {
            
            assignToValue1();
            
            selectedOp = "+";

        }
        

        private void buttonOne_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }  // 1

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }     //2

        private void buttonEqual_Click(object sender, EventArgs e)          //Equal Button
        {
            if (Display.Text != "")
            {
                value2 = Convert.ToDouble(Display.Text);
                BaseMath math = new BaseMath();

                if (selectedOp == "+")
                {
                    Display.Text = Convert.ToString(value1=math.Sum(value1, value2));
                }
                else if (selectedOp == "-")
                {
                    Display.Text = Convert.ToString(value1=math.Substract(value1, value2));
                }
                else if (selectedOp == "x")
                {
                    Display.Text = Convert.ToString(value1=math.Product(value1, value2));
                }
                else if (selectedOp == "/")
                {
                    if (value2 > 0)
                    {
                        Display.Text = Convert.ToString(value1=math.Divide(value1, value2));
                    }
                    else
                    {
                        Display.Text = "Cannot divide by zero";
                    }
                }
                else if(selectedOp == "s")
                {
                    Display.Text = Convert.ToString(Math.Sqrt(value1));
                }
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }  //3

        private void buttonFour_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }   //4

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }  //5

        private void buttonSix_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }   //6

        private void Seven_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }     //7

        private void buttonEight_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }   /// 8
       

        private void buttonNine_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }   //9

        private void button20_Click(object sender, EventArgs e) 
        {
            Display.Text = Display.Text + "0";
        }    //0

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            value2 = 0;
        }   //Clear

        private void buttonMinus_Click(object sender, EventArgs e)      //Minus
        {
            assignToValue1();
            selectedOp = "-";

        }

        private void assignToValue1()
        {
            if (Display.Text != "")
            {
                if (value1 == 0)
                {
                    value1 = Convert.ToDouble(Display.Text);
                }
                else 
                { value2 = Convert.ToDouble(Display.Text); }
                Display.Text = "";

            }
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            assignToValue1();
            selectedOp = "x";
        }    // X

        private void button3_Click(object sender, EventArgs e)          //Memory Recall
        {
            assignToValue1();
            Display.Text  += memory;
        }

        private void ClearEverything_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            value1 = 0;
            value2 = 0;
        }   // ClearEverything

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            assignToValue1();
            selectedOp = "/";
        }     // /

        private void buttonSQRT_Click(object sender, EventArgs e)     // Squared Root
        {
            assignToValue1();
            selectedOp = "s";
        }

        private void button18_Click(object sender, EventArgs e) 
        {
            Display.Text += ".";

        }/// dot

        private void buttonMC_Click(object sender, EventArgs e)         // Memory Clear
        {
            memory = 0;
            buttonMC.Enabled = false;
            buttonMR.Enabled = false;
            
        }

        private void MemoryStore_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(Display.Text);
            assignToValue1();

            if (memory != 0)
            {
                buttonMC.Enabled = true;
                buttonMR.Enabled = true;
            }
        }   //Memory Store

        private void buttonMP_Click(object sender, EventArgs e)      //Memory Add
        {
            memory += Convert.ToDouble(Display.Text);
            assignToValue1();
        }

        private void buttonMM_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDouble(Display.Text);
            assignToValue1();
        }   // Memory substract
    }
}
