using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Location
    {
        public int playerX;
        public int playerY;
        public void Travel(int X, int Y)
        {
            playerX = X;
            playerY = Y;
        }
    }
}
