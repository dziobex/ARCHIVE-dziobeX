using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame2
{
    class Player
    {
        private int corX;
        private int corY;
        private int playerWidth;
        private int playerHeight;

        public Player(int playerX, int playerY, int playerWidth, int playerHeight)
        {
            this.corX = playerX;
            this.corY = playerY;
            this.playerWidth = playerWidth;
            this.playerHeight = playerHeight;
        }

        public int CorX { get { return corX; } set { corX = value; } }
        public int CorY { get { return corY; } set { corY = value; } }

        public int PlayerWidth { get { return playerWidth; } }
        public int PlayerHeight { get { return playerHeight; } }
    }
}
