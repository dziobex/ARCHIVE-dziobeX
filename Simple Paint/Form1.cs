using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p, s;
        int x = -1;
        int y = -1;
        bool move = false;
        Color previousColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            p = new Pen(Color.Black, 2);
            s = new Pen(Color.Black, 2);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move & x != -1 & y != -1)
            {
                g.DrawEllipse(p, x, y, trackBar1.Value, trackBar1.Value);
                x = e.X;
                y = e.Y;
            }
        }

        Rectangle c, r;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            r = new Rectangle (-12, -12, 1, 1);
            move = false;
            x = -1;
            y = -1;
            if (readyCircle)
            {
                cXE = e.X;
                cYE = e.Y;
                if (cYE > cY)
                    c = new Rectangle(cX, cY, cXE - cX, Math.Abs(cYE - cY));
                else
                    c = new Rectangle(cXE, cYE, Math.Abs(cXE - cX), cY - cYE);
                s.Color = colorDialog1.Color;
                s.Width = trackBar1.Value;
                g.DrawEllipse(s, c);
            }
            if (readyRect)
            {
                p.Color = Color.Transparent;
                cRXE = e.X;
                cRYE = e.Y;
                if (cRYE > cRY)
                {
                    if (cRX < cRXE)
                        r = new Rectangle(cRX, cRY, Math.Abs(cRXE - cRX), Math.Abs(cRYE - cRY));
                    else
                        r = new Rectangle(cRXE, cRY, Math.Abs(cRX - cRXE), Math.Abs(cRY - cRYE));
                }
                else
                {
                    if (cRXE < cRX)
                        r = new Rectangle(cRXE, cRYE, Math.Abs(cRXE - cRX), Math.Abs(cRY - cRYE));
                    else
                        r = new Rectangle(cRX, cRYE, Math.Abs(cRXE - cRX), Math.Abs(cRY - cRYE));
                }

                s.Color = colorDialog1.Color;
                s.Width = trackBar1.Value;
                g.DrawRectangle(s, r);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!textBox.Visible)
            {
                move = true;
                x = e.X;
                y = e.Y;
            }
            else
            {
                x = e.X;
                y = e.Y;
                SolidBrush b = new SolidBrush(p.Color);
                //FontFamily f = new FontFamily("Arial");
                System.Drawing.Font ff = fontDialog1.Font;
                g.DrawString(textBox.Text, ff, b, x, y);
            }
            if (readyCircle)
            {
                p.Color = Color.Transparent;
                cX = e.X;
                cY = e.Y;
            }
            if (readyRect)
            {
                p.Color = Color.Transparent;
                cRX = e.X;
                cRY = e.Y;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(this.Location.X + panel1.Location.X + 15, this.Location.Y + (panel1.Location.Y + 31), panel1.Width-8, panel1.Height-1);
            using (Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb))
            {
                Graphics g = Graphics.FromImage(bmp);
                g.CopyFromScreen(rect.Left, rect.Top, 0, 0, panel1.Size, CopyPixelOperation.SourceCopy);
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Mapa bitowa (*.bmp)|*.bmp|"
                    + "Plik png (*.png)|*.png|"
                    + "Plik JPEG (*.JPEG)|*.JPEG";
                saveFileDialog1.InitialDirectory = @"c:/";
                DialogResult r = saveFileDialog1.ShowDialog();
                if (r == DialogResult.OK)
                {
                    bmp.Save(Path.Combine(saveFileDialog1.InitialDirectory, saveFileDialog1.FileName));
                    MessageBox.Show("Plik został zapisany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            p.Color = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            p.Width = trackBar1.Value;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            readyCircle = false;
            readyRect = false;
            textLabel.Visible = false;
            textBox.Visible = false;
            toolStripButton4.Enabled = false;
            previousColor = p.Color;
            p.Color = Color.White;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            readyCircle = false;
            readyRect = false;
            p.Color = previousColor;
            textLabel.Visible = false;
            textBox.Visible = false;
            toolStripButton4.Enabled = true;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            textLabel.Visible = false;
            textBox.Visible = false;
            panel1.Invalidate();
        }

        private void textBtn_Click(object sender, EventArgs e)
        {
            readyCircle = false;
            readyRect = false;
            p.Color = previousColor;
            textLabel.Visible = true;
            textBox.Visible = true;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Mapa bitowa (*.bmp)|*.bmp|"
                    + "Plik png (*.png)|*.png|"
                    + "Plik JPEG (*.JPEG)|*.JPEG";
            openFileDialog1.InitialDirectory = @"c:/";
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                panel1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.BackgroundImage = null;
        }

        bool readyCircle = false;
        int cX = -1, cY = -1, cXE = -1, cYE = -1;

        bool readyRect = false;
        int cRX = -1, cRY = -1, cRXE = -1, cRYE = -1;
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            readyCircle = false;
            readyRect = true;
            textLabel.Visible = false;
            textBox.Visible = false;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            readyRect = false;
            readyCircle = true;
            textLabel.Visible = false;
            textBox.Visible = false;
        }
    }
}
