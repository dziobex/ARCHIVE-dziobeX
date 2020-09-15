using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LGen02
{
    public partial class Form1 : Form
    {
        byte[] headPoss = new byte[] { 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 8, 6, 3, 1, 2, 4, 2, 1, 1, 2, 2, 2, 1, 2, 1, 1, 3 };
        byte[] eyesPoss = new byte[] { 3, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3 };

        public Form1()
        {
            InitializeComponent();
            headBox.SelectedIndex = eyesBox.SelectedIndex = mouthBox.SelectedIndex = 0;
        }

        private void sth_Changed(object sender, EventArgs e)
        {
            byte n0, n1;
            if (headBox.SelectedIndex != -1)
            {
                resultBox.Text = "";
                if (headBool.Checked) n0 = headPoss[headBox.SelectedIndex]; else n0 = 0;
                if (eyesBool.Checked) n1 = eyesPoss[eyesBox.SelectedIndex]; else n1 = 0;

                if (headBool.Checked)
                    resultBox.Text = $"{headBox.Text}";
                if (eyesBool.Checked & headBox.SelectedIndex != -1)
                    resultBox.Text = resultBox.Text.Insert(n0, eyesBox.Text);
                else if (eyesBool.Checked & headBox.SelectedIndex == -1)
                    resultBox.Text = eyesBox.Text;
                if (mouthBool.Checked & headBox.SelectedIndex != -1 & eyesBox.SelectedIndex != -1)
                    resultBox.Text = resultBox.Text.Insert(n0 + n1, mouthBox.Text);
            }
        }

        private void resultBox_Click(object sender, EventArgs e) => Clipboard.SetText((sender as TextBox).Text);
        private void option_CheckedChanged(object sender, EventArgs e) => sth_Changed(sender, e);

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
