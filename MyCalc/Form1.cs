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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void digit0_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '0';
        }
        private void digit1_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '1';
        }
        private void digit2_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '2';
        }
        private void digit3_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '3';
        }
        private void digit4_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '4';
        }
        private void digit5_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '5';
        }
        private void digit6_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '6';
        }
        private void digit7_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '7';
        }
        private void digit8_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '8';
        }
        private void digit9_Click(object sender, EventArgs e)
        {
            if (vars.lastOperation == '=')
            {
                Entry.Text = "";
                vars.lastOperation = 'd';
            }
            Entry.Text = Entry.Text + '9';
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (Entry.Text != "")
                Entry.Text = Entry.Text.Remove(Entry.Text.Length - 1);
        }

        private void add_Click(object sender, EventArgs e)
        {
            vars.first = int.Parse(Entry.Text);
            vars.operand = '+';
            Entry.Text = Entry.Text + '+';
            vars.isFirstEqual = true;
            vars.lastOperation = '+';
        }

        private void sub_Click(object sender, EventArgs e)
        {
            vars.first = int.Parse(Entry.Text);
            vars.operand = '-';
            Entry.Text = Entry.Text + '-';
            vars.isFirstEqual = true;
            vars.lastOperation = '-';
        }

        private void mult_Click(object sender, EventArgs e)
        {
            vars.first = int.Parse(Entry.Text);
            vars.operand = '*';
            Entry.Text = Entry.Text + '*';
            vars.isFirstEqual = true;
            vars.lastOperation = '*';
        }

        private void div_Click(object sender, EventArgs e)
        {
            vars.first = int.Parse(Entry.Text);
            vars.operand = '/';
            Entry.Text = Entry.Text + '/';
            vars.isFirstEqual = true;
            vars.lastOperation = '/';
        }

        private void equal_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            if (vars.isFirstEqual)
                vars.second = int.Parse(Entry.Text.Split(vars.operand)[1]);
            string ans ="";
            switch (vars.operand)
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

                default:
                    ans = "oops";
                    break;
            }
            if (isOk) {
                Entry.Text = ans;
                //vars.operand = (char)0;
                vars.first = int.Parse(ans);
                //vars.second = null;
            }
            vars.isFirstEqual = false;
            vars.lastOperation = '=';
        }
    }
    public class vars
    {

        public static bool isFirstEqual = true;
        public static char operand = (char)0,
            lastOperation = (char)0;
        public static int? first = null, second = null;
    }
}
