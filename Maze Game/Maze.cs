using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGame2
{
    class Maze
    {
        List<Label> listOfBorders = new List<Label>();
        Player player;

        public Maze(List<Label> listOfBorders, Player player)
        {
            this.listOfBorders = listOfBorders;
            this.player = player;
        }

        public bool Borders()
        {
            int minus = 0;
            foreach (Label lbl in listOfBorders)
            {
                int minX = lbl.Location.X;
                int minY = lbl.Location.Y;
                int maxX = minX + lbl.Width;
                int maxY = minY + lbl.Height;

                if (lbl.Width > lbl.Height)
                    minus = lbl.Height/2;
                else
                    minus = lbl.Width/2;

                if (player.PlayerHeight > lbl.Height)
                {
                    if ((player.CorX <= maxX && minX <= player.CorX && player.CorY <= minY && (player.CorY + player.PlayerHeight - minus) >= maxY)
                        || ((player.CorX + player.PlayerWidth - minus) <= maxX && minX <= (player.CorX + player.PlayerWidth - minus) && player.CorY <= minY && (player.CorY + player.PlayerHeight - minus) >= maxY))
                        return true;
                }

                if (player.PlayerWidth > lbl.Width)
                {
                    if (player.CorY <= maxY && player.CorY >= minY && minX >= player.CorX && (player.CorX + player.PlayerWidth) >= maxX)
                        return true;
                }

                if ((player.CorX >= minX && player.CorX <= maxX && (player.CorY + player.PlayerHeight - minus) >= minY && (player.CorY + player.PlayerHeight - minus) <= maxY)
                     || ((player.CorX + player.PlayerWidth - minus) >= minX && player.CorX <= maxX && (player.CorY + player.PlayerHeight - minus) >= minY && (player.CorY + player.PlayerHeight - minus) <= maxY))
                    return true;
                if ((player.CorX + player.PlayerWidth - minus) >= minX && (player.CorX + player.PlayerWidth - minus) <= maxX && player.CorY >= minY && player.CorY <= maxY
                     || (player.CorX >= minX && (player.CorX + player.PlayerWidth - minus) <= (maxX + player.PlayerWidth - minus) && player.CorY >= minY && player.CorY <= maxY))
                    return true;
            }
            return false;
        }
    }
}
