using System;
using System.Drawing;
using System.Windows.Forms;

namespace BinConverter
{
    public partial class Main : Form
    {
        bool swapped = false;
        Converter converter;

        public Main() {
            InitializeComponent();
            converter = new Converter(input, output);
        }

        private void covertBtn_Click(object sender, EventArgs e) {
            if (input.Text.Length < 1) return;
            if (!swapped) output.Text = converter.PrepareText();
            else output.Text = converter.Decrypt();
        }

        private void swapBtn_Click(object sender, EventArgs e) {
            swapped = !swapped;
            label1.Text = swapped ? "Binary numbers to convert:" : "Text to binary:";
            resetBtn_Click(this, EventArgs.Empty);
        }

        private void resetBtn_Click(object sender, EventArgs e) => input.Text = output.Text = "";
        private void copyBtn_Click(object sender, EventArgs e) => Clipboard.SetText(output.Text);
    }
}
