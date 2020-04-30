using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1; //ms
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (Vars.lastOperation) 
            {
                case constants.NO_OPERATION:
                    Entry.Text = "";
                    break;
                case constants.DIGIT:
                    if (Vars.currentOperator == constants.NO_OPERATOR)
                        Entry.Text = Vars.first.ToString();
                    else
                        Entry.Text = Vars.first.ToString() + Vars.currentOperator + Vars.second.ToString();
                    break;
                case constants.CALCULATION:
                    Entry.Text = Vars.first.ToString() + Vars.currentOperator;
                    break;
                case '=':
                    Entry.Text = Vars.ans.ToString();
                    break;
            }
        }

        private void checkEqual()
        {
            if (Vars.lastOperation == '=')
            {
                Entry.Text = "";
                Vars.first = 0;
                Vars.second = 0;
                Vars.ans = 0;
                Vars.currentOperator = constants.NO_OPERATOR;
            }
            Vars.lastOperation = constants.DIGIT;
        }

        private static void writeDigit(byte digit)
        {
            if (Vars.currentOperator == constants.NO_OPERATOR)
            {
                Vars.first *= 10;
                Vars.first += digit;
            }
            else
            {
                Vars.second *= 10;
                Vars.second += digit;
            }
        }

        private void inputDigit(byte digit)
        {
            checkEqual();
            writeDigit(digit);
        }


        private void digit0_Click(object sender, EventArgs e)
        {
            inputDigit(0);
        }

        private void digit1_Click(object sender, EventArgs e)
        {
            inputDigit(1);
        }
        private void digit2_Click(object sender, EventArgs e)
        {
            inputDigit(2);
        }
        private void digit3_Click(object sender, EventArgs e)
        {
            inputDigit(3);
        }
        private void digit4_Click(object sender, EventArgs e)
        {
            inputDigit(4);
        }
        private void digit5_Click(object sender, EventArgs e)
        {
            inputDigit(5);
        }
        private void digit6_Click(object sender, EventArgs e)
        {
            inputDigit(6);
        }
        private void digit7_Click(object sender, EventArgs e)
        {
            inputDigit(7);
        }
        private void digit8_Click(object sender, EventArgs e)
        {
            inputDigit(8);
        }
        private void digit9_Click(object sender, EventArgs e)
        {
            inputDigit(9);
        }

        private void nullNumbersVars()
        {
            Vars.first = 0;
            Vars.second = 0;
            Vars.ans = 0;
        }
        private void nullAllVars()
        {
            nullNumbersVars();
            Vars.lastOperation = constants.NO_OPERATION;
            Vars.currentOperator = constants.NO_OPERATOR;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (Vars.lastOperation == '=')
            {
                nullNumbersVars();
            }
            else if (Vars.lastOperation == constants.DIGIT)
                Vars.first /= 10;
            else if (Vars.currentOperator == constants.CALCULATION)
                Vars.second /= 10;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            nullAllVars();
        }

        private static void calculation(char Operator)
        {
            Vars.currentOperator = Operator;
            Vars.lastOperation = constants.CALCULATION;
            Vars.second = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            calculation('+');
        }

        private void sub_Click(object sender, EventArgs e)
        {
            calculation('-');
        }

        private void mult_Click(object sender, EventArgs e)
        {
            calculation('*');
        }

        private void div_Click(object sender, EventArgs e)
        {
            calculation('/');
        }

        private void equal_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            switch (Vars.currentOperator)
            {
                case '+':
                    Vars.ans = Vars.first + Vars.second;
                    break;
                case '-':
                    Vars.ans = Vars.first - Vars.second;
                    break;
                case '*':
                    Vars.ans = Vars.first * Vars.second;
                    break;
                case '/':
                    if (Vars.second == 0)
                    {
                        Entry.Text = "You divided by Zero";
                        isOk = false;
                    }
                    else
                    {
                        Vars.ans = Vars.first / Vars.second;
                    }
                    break;

                
            }
            if (isOk) {
                Vars.first = Vars.ans;
                Vars.lastOperation = '=';
            }
            else
            {
                nullAllVars();
            }
        }
        
    }
}
