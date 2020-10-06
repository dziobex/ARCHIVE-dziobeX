using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace BinConverter
{
    class Converter
    {
        TextBox input;
        TextBox output;

        public Converter(TextBox input, TextBox output) {
            this.input = input;
            this.output = output;
        }

        public string Decrypt() {
            string result = "";
            string txt = String.Concat(input.Text.Where(c => !Char.IsWhiteSpace(c)));

            while (txt.Length > 0) {
                try {
                    result += FromBin(txt.Substring(0, 8));
                    txt = txt.Remove(0, 8);
                }
                catch { return ""; }
            }

            return result;
        }

        public string PrepareText() {
            string txt = input.Text;
            string result = "";
            for (int i = 0; i < txt.Length; i++) {
                result += ToBin(txt[i]);
                if (i != txt.Length - 1)
                    result += " ";
            }

            return result;
        }

        char FromBin(string txt) {
            int num = 0;
            for (int i = 0; i < txt.Length; i++)
                if (txt[i] == '1')
                    num += (int)Math.Pow(txt.Length - 1 - i, 2);

            return Convert.ToChar(Convert.ToInt32(txt, 2));
        }

        string ToBin(char num) {
            byte value = 0;
            try { value = 164; } catch { return ""; }

            string r = "";

            while (value != 0) {
                if (value % 2 == 0)
                    r += '0';
                else
                    r += '1';
                value /= 2;
            }

            while (r.Length != 8) r += '0';

            char[] helper = r.ToCharArray();
            Array.Reverse(helper);
            return new string(helper);
        }
    }
}
