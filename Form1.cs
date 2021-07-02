using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float Num_Input1,
              Result_Output;
        byte  Op_Symbol = 0;


        private void Button_0_Click(object sender, EventArgs e)
        {
            string NumVal = "0";
            NumberDisp_Func(NumVal);
        }
        private void Button_00_Click(object sender, EventArgs e)
        {
            string NumVal = "00";
            NumberDisp_Func(NumVal);
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            string NumVal = "1";
            NumberDisp_Func(NumVal);
        }
        private void Button_2_Click(object sender, EventArgs e)
        {
            string NumVal = "2";
            NumberDisp_Func(NumVal);
        }
        private void Button_3_Click(object sender, EventArgs e)
        {
            string NumVal = "3";
            NumberDisp_Func(NumVal);
        }
        private void Button_4_Click(object sender, EventArgs e)
        {
            string NumVal = "4";
            NumberDisp_Func(NumVal);
        }
        private void Button_5_Click(object sender, EventArgs e)
        {
            string NumVal = "5";
            NumberDisp_Func(NumVal);
        }
        private void Button_6_Click(object sender, EventArgs e)
        {
            string NumVal = "6";
            NumberDisp_Func(NumVal);
        }
        private void Button_7_Click(object sender, EventArgs e)
        {
            string NumVal = "7";
            NumberDisp_Func(NumVal);
        }
        private void Button_8_Click(object sender, EventArgs e)
        {
            string NumVal = "8";
            NumberDisp_Func(NumVal);
        }
        private void Button_9_Click(object sender, EventArgs e)
        {
            string NumVal = "9";
            NumberDisp_Func(NumVal);
            
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Num_Input1 = float.Parse(CalculatorDisplay.Text);
            Op_Symbol = 1;
            CalculatorDisplay.Clear();
        }
        private void Button_Subtract_Click(object sender, EventArgs e)
        {
            Num_Input1 = float.Parse(CalculatorDisplay.Text);
            Op_Symbol = 2;
            CalculatorDisplay.Clear();
        }
        private void Button_Divide_Click(object sender, EventArgs e)
        {
            Num_Input1 = float.Parse(CalculatorDisplay.Text);
            Op_Symbol = 3;
            CalculatorDisplay.Clear();
        }
        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            Num_Input1 = float.Parse(CalculatorDisplay.Text);
            Op_Symbol = 4;
            CalculatorDisplay.Clear();
        }
        private void Button_ClearEntry_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Clear();
            Num_Input1 = 0;
            Op_Symbol = 0;
        }
        private void Button_DeleteInp_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text.Length <= 1)
            {
                CalculatorDisplay.Text = "0";
            }
            else
            {
                CalculatorDisplay.Text = CalculatorDisplay.Text.Remove(CalculatorDisplay.Text.Length - 1);
            }
        }
        private void Button_Dot_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += ".";
        }
        private void Button_Equals_Click(object sender, EventArgs e)
        {
            ComputeInput(Op_Symbol);
        }

        ////////////// FUNCTIONS SECTION ///////////////////
  
        private void ComputeInput(int Op_Symbol)
        {
            //Switch cases based on Op_Symbol which corresponds with a value for each operation//
            switch(Op_Symbol)
            {
                //Parses the second number, then conducts operations based from the cases//
                //After addition result output is converted to a string//
                case 1:
                    Result_Output = Num_Input1 + float.Parse(CalculatorDisplay.Text);
                    CalculatorDisplay.Text = Result_Output.ToString();
                    break;
                case 2:
                    Result_Output = Num_Input1 - float.Parse(CalculatorDisplay.Text);
                    CalculatorDisplay.Text = Result_Output.ToString();
                    break;
                case 3:
                    Result_Output = Num_Input1 / float.Parse(CalculatorDisplay.Text);
                    CalculatorDisplay.Text = Result_Output.ToString();
                    break;
                case 4:
                    Result_Output = Num_Input1 * float.Parse(CalculatorDisplay.Text);
                    CalculatorDisplay.Text = Result_Output.ToString();
                    break;
                default:
                break;
            }
        }

        private string NumberDisp_Func(string NumVal)
        {
            // if the textbox is blank, the function inputs the NumVal based on the value of the button that is clicked.//
            // if the textbox is NOT blank, the function appends a value of NumVal based on the value of the button that is clicked.//
            if(CalculatorDisplay.Text == "")
            {
                CalculatorDisplay.Text = NumVal;
                string DisplayNum = CalculatorDisplay.Text;
                return DisplayNum;
            }
            else
            {
                CalculatorDisplay.Text += NumVal;
                string DisplayNum = CalculatorDisplay.Text;
                return DisplayNum;
            } 
        }
    }
}
