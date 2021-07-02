using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    class OperatorsClass 
    {
        private float Num_Input1;
        private float Result_Output;
        private string CalcDisp;
        private byte Op_Symbol = 0;


        public float Num_Inp { get => Num_Input1; set => Num_Input1 = value; }
        public float Result_Output1 { get => Result_Output; set => Result_Output = value; }
        public byte Op_Symbol1 { get => Op_Symbol; set => Op_Symbol = value; }
        public string CalcDisp1 { get => CalcDisp; set => CalcDisp = value; }

        public string NumberDisp_Func(string NumVal)
        {
            if (CalcDisp1 == "")
            {
                CalcDisp1 = NumVal;
                string DisplayNum = CalcDisp1;
                return DisplayNum;
            }
            else
            {
                CalcDisp1 += NumVal;
                string DisplayNum = CalcDisp1;
                return DisplayNum;
            }

        }

        public void ComputeInput(int Op_Symbol)
        {
            switch (Op_Symbol)
            {
                case 1:
                    Result_Output1 = Num_Inp + float.Parse(CalcDisp1);
                    CalcDisp1 = Result_Output1.ToString();
                    break;

                case 2:
                    Result_Output1 = Num_Inp - float.Parse(CalcDisp1);
                    CalcDisp1 = Result_Output1.ToString();
                    break;
                case 3:
                    Result_Output1 = Num_Inp / float.Parse(CalcDisp1);
                    CalcDisp1 = Result_Output1.ToString();
                    break;
                case 4:
                    Result_Output1 = Num_Inp * float.Parse(CalcDisp1);
                    CalcDisp1 = Result_Output1.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
