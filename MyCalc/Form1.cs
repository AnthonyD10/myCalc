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
            switch (vars.lastOperation) 
            {
                case constants.DIGIT:
                case constants.NO_OPERATION:
                    Entry.Text = vars.first.ToString();
                    Console.Out.WriteLine("No_Fuck");
                    break;
                case '=':
                    Entry.Text = vars.ans.ToString();
                    break;
            }
        }

        private void checkEqual()
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.first = 0;
                vars.second = 0;
                vars.ans = 0;
            }
            vars.lastOperation = constants.DIGIT;
        }

        private static void writeDigit(byte digit)
        {
            if (vars.currentOperator == constants.CALCULATION)
            {
                vars.second *= 10;
                vars.second += digit;
            }
            else
            {
                vars.first *= 10;
                vars.first += digit;
            }
        }

        private void digit0_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(0);
        }

        private void digit1_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(1);
            Console.Out.WriteLine(vars.first);
        }
        private void digit2_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(2);
        }
        private void digit3_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(3);
        }
        private void digit4_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(4);
        }
        private void digit5_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(5);
        }
        private void digit6_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(6);
        }
        private void digit7_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(7);
        }
        private void digit8_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(8);
        }
        private void digit9_Click(object sender, EventArgs e)
        {
            checkEqual();
            writeDigit(9);
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                vars.first = 0;
                vars.second = 0;
                vars.ans = 0;
            }
            else if (vars.lastOperation == constants.DIGIT)
                vars.first /= 10;
            else if (vars.currentOperator == constants.CALCULATION)
                vars.second /= 10;

        }

        private void add_Click(object sender, EventArgs e)
        {
            vars.currentOperator = '+';
            Entry.Text = Entry.Text + '+';
            vars.isFirstEqual = true;
            vars.lastOperation = constants.CALCULATION;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            vars.currentOperator = '-';
            Entry.Text = Entry.Text + '-';
            vars.isFirstEqual = true;
            vars.lastOperation = constants.CALCULATION;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            vars.currentOperator = '*';
            Entry.Text = Entry.Text + '*';
            vars.isFirstEqual = true;
            vars.lastOperation = constants.CALCULATION;
        }

        private void div_Click(object sender, EventArgs e)
        {
            vars.currentOperator = '/';
            Entry.Text = Entry.Text + '/';
            vars.isFirstEqual = true;
            vars.lastOperation = constants.CALCULATION;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            //if (vars.isFirstEqual)
            //    vars.second = int.Parse(Entry.Text.Split(vars.currentOperator)[1]);
            string ans ="";
            switch (vars.currentOperator)
            {
                case '+':
                    ans = (vars.first + vars.second).ToString();
                    break;
                case '-':
                    ans = (vars.first - vars.second).ToString();
                    break;
                case '*':
                    ans = (vars.first * vars.second).ToString();
                    break;
                case '/':
                    if (vars.second == 0)
                    {
                        Entry.Text = "You divided by Zero";
                        isOk = false;
                    }
                    else
                    {
                        ans = (vars.first / vars.second).ToString();
                    }
                    break;

                
            }
            if (isOk) {
                Entry.Text = ans;
                vars.first = vars.ans;
                //vars.second = null;
            }
            vars.isFirstEqual = false;
            vars.lastOperation = '=';
        }
    }
    public class vars
    {

        public static bool isFirstEqual = true;
        public static char currentOperator = constants.NO_OPERATOR,
            lastOperation = constants.NO_OPERATION;
        public static Int64 first = 0, second = 0, ans = 0;
    }
}
