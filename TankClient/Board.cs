using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankClient
{

    class Board
    {

        public Player[] players;
        public Block[,] blocks;

        public Board()
        {
            players = new Player[5];
            blocks = new Block[10, 10];

        }

    }
}
