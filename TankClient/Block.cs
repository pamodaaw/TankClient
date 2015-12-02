using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankClient
{
    class Block
    {
        private int positionX;
        private int positionY;

        public void setPostion(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }
    }
}
