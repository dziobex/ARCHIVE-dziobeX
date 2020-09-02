using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace test_vir
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice device;
        byte num;

        void playSound()
        {
            Stream s = Properties.Resources.trololo;
            SoundPlayer sound = new SoundPlayer(s);
            sound.PlayLooping();
        }
        public Form1()
        {
            InitializeComponent();
            playSound();
            num = 0;
            cap = true;
        }

        private void takePhotoBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
            Wallpaper.Set((Bitmap)pictureBox2.Image.Clone());
        }

        bool cap;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    comboBox1.Items.Add(filterInfo.Name);
                comboBox1.SelectedIndex = 0;
                device = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
                device.Start();
                device.NewFrame += Device_NewFrame;
            }
            catch
            {
                pictureBox2.Image = (Bitmap)Properties.Resources.trololoo;
                Wallpaper.Set((Bitmap)pictureBox2.Image.Clone());
            }
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (cap)
            {
                Wallpaper.Set((Bitmap)eventArgs.Frame.Clone());
                cap = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device != null) if (device.IsRunning) device.Stop();
            e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            if (num == 1)
                Display.Rotate(1, Display.Orientations.DEGREES_0);
            else if (num == 2)
                Display.Rotate(1, Display.Orientations.DEGREES_180);
            else if (num == 3)
                Display.Rotate(1, Display.Orientations.DEGREES_270);
            else if (num == 4)
                Display.Rotate(1, Display.Orientations.DEGREES_90);
            else num = 0;
        }
    }
}
