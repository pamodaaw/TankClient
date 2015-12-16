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

        public Block(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }

        public Block() { }

        public void setPostion(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }
        public int[] getPosition()
        {
            int[] position = { this.positionX, this.positionY };
            return position;
        }
    }
}
