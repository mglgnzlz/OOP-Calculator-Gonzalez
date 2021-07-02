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
    public partial class Calculator : Form
    {
        OperatorsClass OpClass = new OperatorsClass();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "0";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_00_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "00";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "1";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_2_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "2";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_3_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "3";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_4_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "4";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_5_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "5";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_6_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "6";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_7_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "7";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_8_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "8";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }
        private void Button_9_Click(object sender, EventArgs e)
        {
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            string NumVal = "9";
            OpClass.NumberDisp_Func(NumVal);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            OpClass.Num_Inp = float.Parse(CalculatorDisplay.Text);
            OpClass.Op_Symbol1 = 1;
            CalculatorDisplay.Clear();
        }
        private void Button_Subtract_Click(object sender, EventArgs e)
        {
            OpClass.Num_Inp = float.Parse(CalculatorDisplay.Text);
            OpClass.Op_Symbol1 = 2;
            CalculatorDisplay.Clear();
        }
        private void Button_Divide_Click(object sender, EventArgs e)
        {
            OpClass.Num_Inp = float.Parse(CalculatorDisplay.Text);
            OpClass.Op_Symbol1 = 3;
            CalculatorDisplay.Clear();
        }
        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            OpClass.Num_Inp = float.Parse(CalculatorDisplay.Text);
            OpClass.Op_Symbol1 = 4;
            CalculatorDisplay.Clear();
        }
        private void Button_ClearEntry_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Clear();
            OpClass.Num_Inp = 0;
            OpClass.Op_Symbol1 = 0;
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
            OpClass.CalcDisp1 = CalculatorDisplay.Text;
            OpClass.ComputeInput(OpClass.Op_Symbol1);
            CalculatorDisplay.Text = OpClass.CalcDisp1;
        }

    }
}
