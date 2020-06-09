using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame2
{
    public partial class Level3 : Form
    {
        int playerX = 27;
        int playerY = 42;
        Positions pos;
        Player player;
        Maze maze;
        Goal goal;

        bool goalAchived = false;
        bool everythingEnabled = true;

        int gameCounter = 150;

        public Level3()
        {
            InitializeComponent();
            pos = Positions.down;
            player = new Player(playerX, playerY, pictureBox2.Width, pictureBox2.Height);
            maze = new Maze(prepareListOfLabels(), player);
            goal = new Goal(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height, player, pictureBox1);
        }

        private List<Label> prepareListOfLabels()
        {
            List<Label> result = new List<Label>();
            foreach (Label lbl in this.Controls.OfType<Label>())
                if (lbl.Name != "label57")
                    result.Add(lbl);
            result.Reverse();
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (everythingEnabled)
            {
                if (pos == Positions.up)
                {
                    playerY -= 6;
                    player.CorY = playerY;
                    if (maze.Borders())
                    {
                        playerY += 6;
                        player.CorY = playerY;
                    }
                    if (goal.GoalAchived())
                    {
                        goalAchived = true;
                    }
                    pos = Positions.not;
                }
                else if (pos == Positions.down)
                {
                    playerY += 6;
                    player.CorY = playerY;
                    if (maze.Borders())
                    {
                        playerY -= 6;
                        player.CorY = playerY;
                    }
                    if (goal.GoalAchived())
                    {
                        goalAchived = true;
                    }
                    pos = Positions.not;
                }
                else if (pos == Positions.left)
                {
                    playerX -= 6;
                    player.CorX = playerX;
                    if (maze.Borders())
                    {
                        playerX += 6;
                        player.CorX = playerX;
                    }
                    if (goal.GoalAchived())
                    {
                        goalAchived = true;
                    }
                    pos = Positions.not;
                }
                else if (pos == Positions.right)
                {
                    playerX += 6;
                    player.CorX = playerX;
                    if (maze.Borders())
                    {
                        playerX -= 6;
                        player.CorX = playerX;
                    }
                    if (goal.GoalAchived())
                    {
                        goalAchived = true;
                    }
                    pos = Positions.not;
                }
            }

            if (goalAchived)
            {
                everythingEnabled = false;
                goalAchived = false;
                gameTimer.Enabled = false;
                MessageBox.Show("Thanks a lot!", "Shrimpy says...");
            }
            Invalidate();
        }

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                pos = Positions.up;
            else if (e.KeyCode == Keys.Down)
                pos = Positions.down;
            else if (e.KeyCode == Keys.Left)
                pos = Positions.left;
            else if (e.KeyCode == Keys.Right)
                pos = Positions.right;
        }

        private void Level3_Paint(object sender, PaintEventArgs e)
        {
            pictureBox2.Location = new Point(playerX, playerY);
            player.CorX = playerX;
            player.CorY = playerY;
        }

        private void activateEverything()
        {
            playerX = 27;
            playerY = 42;
            gameCounter = 150;
            label81.BackColor = Color.Transparent;
            label81.Text = "150 sec";
            everythingEnabled = true;
            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameCounter--;
            if (gameCounter <= 10)
                label81.BackColor = Color.Red;

            label81.Text = gameCounter.ToString() + " sec";

            if (gameCounter <= 0 && everythingEnabled)
            {
                gameTimer.Enabled = false;
                everythingEnabled = false;
                MessageBox.Show("Time is up!");
                gameCounter = 0;
            }
        }

        private void renewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateEverything();
        }

        private void Level3_Load(object sender, EventArgs e)
        {
            activateEverything();
        }
    }
}
