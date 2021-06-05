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


        private void Button_0_Click(object sender, EventArgs e)
        {
            string NumVal = "0";
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
        private void Button_Dot_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = CalculatorDisplay.Text + ".";
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            
        }
        private void Button_Subtract_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = CalculatorDisplay.Text + "-";
        }
        private void Button_Divide_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = CalculatorDisplay.Text + "/";
        }
        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = CalculatorDisplay.Text + "x";
        }
        private void Button_ClearEntry_Click(object sender, EventArgs e)
        {

        }
        private void Button_EmptySelection_Click(object sender, EventArgs e)
        {

        }
        private void Button_DeleteInp_Click(object sender, EventArgs e)
        {

        }
        private void Button_Equals_Click(object sender, EventArgs e)
        {

        }

        private string NumberDisp_Func(string NumVal)
        {
            if(CalculatorDisplay.Text == "" && CalculatorDisplay.Text != null)
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
