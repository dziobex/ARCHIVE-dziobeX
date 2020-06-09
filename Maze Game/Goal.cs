using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGame2
{
    class Goal
    {
        private int posX;
        private int posY;
        private int goalWidth;
        private int goalHeight;
        Player player;
        PictureBox picOfGoal;

        public Goal(int posX, int posY, int goalWidth, int goalHeight, Player player, PictureBox picOfGoal)
        {
            this.posX = posX;
            this.posY = posY;
            this.goalWidth = goalWidth;
            this.goalHeight = goalHeight;
            this.player = player;
            this.picOfGoal = picOfGoal;
        }

        public bool GoalAchived()
        {
            Point playerLocation = new Point(player.CorX, player.CorY);
            if (picOfGoal.Bounds.Contains(playerLocation))
                return true;
            else
                return false;
        }
    }
}
