using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        Picture[] images = new Picture[16];
        string path = "C:/Users/jedno/Desktop/C#/MemoryGame/";
        int counterTimer = 0;
        int timer2Tick = 0;
        int gameCounter = 30;

        int points = 0;
        int picturesClicked = 0;
        int incorrectPairs = 0;

        string[] startPictures = new string[]
        {
            "shrimp.png", "shrimp.png", "goldfish.png", "goldfish.png",
            "nemo.png", "nemo.png", "scalar.png", "scalar.png",
            "platyfish.png", "platyfish.png", "fighter.png", "fighter.png",
            "monster.png", "monster.png", "herring.png", "herring.png"
        };

        List<string> pictures = new List<string>()
        {
            "shrimp.png", "shrimp.png", "goldfish.png", "goldfish.png",
            "nemo.png", "nemo.png", "scalar.png", "scalar.png",
            "platyfish.png", "platyfish.png", "fighter.png", "fighter.png",
            "monster.png", "monster.png", "herring.png", "herring.png"
        };

        PictureBox[] pictureBoxes;
        Picture imageSelected1, imageSelected2;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 , pictureBox7 , pictureBox8 , pictureBox9 , pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14,pictureBox15, pictureBox16 };
            UpdatePictures();
        }

        private void UpdatePictures()
        {
            int counter = 0;
            foreach (PictureBox image in pictureBoxes)
            {
                int num = randomizer.Next(pictures.Count);
                image.Image = Image.FromFile(path + pictures[num]);
                images[counter] = new Picture(pictures[num], image);
                pictures.RemoveAt(num);
                counter++;
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;
            for (int i = 0; i < 16; i++)
            {
                if (images[i].PicBox == clicked)
                {
                    if (clicked.Image == null)
                        clicked.Image = Image.FromFile(path + images[i].FileName);
                    else
                        return;
                    if (imageSelected1 == null)
                    {
                        imageSelected1 = new Picture(images[i].FileName, clicked);
                        picturesClicked++;
                    }
                    else if (imageSelected2 == null)
                    {
                        imageSelected2 = new Picture(images[i].FileName, clicked);
                        picturesClicked++;
                    }

                    if (imageSelected1 != null && imageSelected2 != null)
                    {
                        if (imageSelected1.choice(imageSelected2.FileName))
                        {
                            points++;
                            checkWinner();
                        }
                        else
                        {
                            incorrectPairs++;
                            timer2.Start();
                            turnOffEverything();
                            break;
                        }

                        imageSelected1 = null;
                        imageSelected2 = null;
                        clicked = null;
                    }
                }
            }
        }

        private void turnOffEverything()
        {
            foreach(PictureBox pic in pictureBoxes)
            {
                pic.Enabled = false;
            }
        }

        private void turnOnEverything()
        {
            foreach (PictureBox pic in pictureBoxes)
            {
                pic.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counterTimer++;
            if (counterTimer < 4)
                label1.Text = "0:" + counterTimer.ToString();

            if (counterTimer == 4)
            {
                turnOnEverything();
                foreach (PictureBox image in pictureBoxes)
                    image.Image = null;
                timer1.Stop();
                label1.Text = "0:20";
                gameTimer.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2Tick++;
            if (timer2Tick == 1)
            {
                timer2.Stop();
                timer2Tick = 0;
                imageSelected1.PicBox.Image = null;
                imageSelected2.PicBox.Image = null;
                imageSelected1 = null;
                imageSelected2 = null;
                turnOnEverything();
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liczba poprawnych par: " + points + "\nLiczba NIE poprawnych par: " + incorrectPairs + "\nLiczba kliknietych obrazkow: " + picturesClicked, "Ta gra");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i=0; i<16; i++)
                pictures.Add(startPictures[i]);
            UpdatePictures();
            label1.Text = "0:0";

            gameTimer.Stop();
            gameCounter = 30;
            counterTimer = 0;
            timer1.Start();

            points = 0;
            picturesClicked = 0;
            incorrectPairs = 0;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameCounter--;
            label1.Text = "0:" + gameCounter.ToString();
            checkWinner();
            if (gameCounter <= 0)
            {
                gameTimer.Stop();
                if (points != 8)
                    MessageBox.Show("Przegrales!", "Przegrana");
                else
                    MessageBox.Show("Gratulacje!", "Wygrana");
                turnOffEverything();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gra memory. Odkryj jak nawiecej kart, posiadajacych pary.", "O grze");
        }

        private bool checkWinner()
        {
            if (points == 8)
            {
                gameTimer.Stop();
                turnOffEverything();
                MessageBox.Show("Gratulacje!", "Wygrana");
                return true;
            }
            return false;
        }
    }
}
