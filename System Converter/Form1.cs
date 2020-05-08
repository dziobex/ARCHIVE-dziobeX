using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    
    public partial class Form1 : Form
    {
        string type = "";
        private bool IfCorrect(int num, int sys)
        {
            while (num > 0)
            {
                if (num % 10 >= sys)
                    return false;
                num /= 10;
            }
            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dec_TextChanged(object sender, EventArgs e)
        {
            if (type == "dec")
            {
                string txt = dec.Text;
                if (txt == "")
                {
                    WarningDec.Text = "Error!";
                    return;
                }

                foreach (char i in txt)
                {
                    if (i < '0' || i > '9')
                    {
                        WarningDec.Text = "Error!";
                        return;
                    }
                    else
                        WarningDec.Text = "";
                }

                int for_check = Convert.ToInt32(txt);
                int num = int.Parse(txt);
                string res = Convert.ToString(num, 2);
                bin.Text = res;
                res = Convert.ToString(num, 16);
                hex.Text = res;
                res = Convert.ToString(num, 8);
                oct.Text = res;
            }
        }

        private void bin_TextChanged(object sender, EventArgs e)
        {
            if (type == "bin")
            {
                string txt = bin.Text;
                if (txt == "")
                {
                    WarningBin.Text = "Error!";
                    return;
                }

                foreach (char i in txt)
                {
                    if (i < '0' || i > '1')
                    {
                        WarningBin.Text = "Error!";
                        return;
                    }
                    else
                        WarningBin.Text = "";
                }

                int for_check = Convert.ToInt32(bin.Text);
                double num1 = Conv.ToDec(bin.Text, 2);
                int num = Convert.ToInt32(num1);
                string res = Convert.ToString(num, 10);
                dec.Text = res;
                res = Convert.ToString(num, 16);
                hex.Text = res;
                res = Convert.ToString(num, 8);
                oct.Text = res;
            }
        }

        private void hex_TextChanged(object sender, EventArgs e)
        {
            if (type == "hex")
            {
                string txt = hex.Text;
                if (txt == "")
                {
                    WarningHex.Text = "Error!";
                    return;
                }

                foreach (char i in txt)
                {
                    if (i > '9' && i < 'a' || i > '9' && i > 'f')
                    {
                        WarningHex.Text = "Error!";
                        return;
                    }
                    else
                        WarningHex.Text = "";
                }

                double num1 = Conv.ToDec(hex.Text, 16);
                int num = Convert.ToInt32(num1);
                string res = Convert.ToString(num, 10);
                dec.Text = res;
                res = Convert.ToString(num, 2);
                bin.Text = res;
                res = Convert.ToString(num, 8);
                oct.Text = res;
            }

        }

        private void oct_TextChanged(object sender, EventArgs e)
        {
            if (type == "oct")
            {
                string txt = oct.Text;
                if (txt == "")
                {
                    WarningDec.Text = "Error!";
                    return;
                }
                foreach (char i in txt)
                {
                    if (i < '0' || i > '7')
                    {
                        WarningOct.Text = "Error!";
                        return;
                    }
                    else
                        WarningOct.Text = "";
                }
                int for_check = Convert.ToInt32(oct.Text);
                double num1 = Conv.ToDec(oct.Text, 8);
                int num = Convert.ToInt32(num1);
                string res = Convert.ToString(num, 10);
                dec.Text = res;
                res = Convert.ToString(num, 2);
                bin.Text = res;
                res = Convert.ToString(num, 16);
                hex.Text = res;
            }
        }

        private void bin_Enter(object sender, EventArgs e)
        {
            type = "bin";
            if (bin.Text == "0")
                bin.Text = "";
        }

        private void dec_Enter(object sender, EventArgs e)
        {
            type = "dec";
            if (dec.Text == "0")
                dec.Text = "";
        }

        private void hex_Enter(object sender, EventArgs e)
        {
            type = "hex";
            if (hex.Text == "0")
                hex.Text = "";
        }

        private void oct_Enter(object sender, EventArgs e)
        {
            type = "oct";
            if (oct.Text == "0")
                oct.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dec.Text = "0";
            bin.Text = "0";
            hex.Text = "0";
            oct.Text = "0";
        }
    }
    public class Conv
    {
        public static double ToDec(string num, int sys)
        {
            string numbers = "0123456789abcdef";
            double dec = 0;
            int n = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < sys; j++)
                {
                    if (num[i] == numbers[j])
                    {
                        n = j;
                        break;
                    }
                }

                dec += n * Math.Pow(sys, num.Length - 1 - i);
            }

            return dec;
        }
    }
}
