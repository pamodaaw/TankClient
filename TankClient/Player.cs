using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankClient
{
    class Player
    {
        private String name;
        private bool isAlive;
        private int positionX;
        private int positionY;
        private int health;
        private int coins;
        private int points;

        public Player(String name)
        {
            this.name = name;
            isAlive = true;
            health = 0;
            coins = 0;
            points = 0;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setLife(bool isAlive)
        {
            this.isAlive = isAlive;
        }

        public void setPoints(int points)
        {
            this.points = points;

        }
        public void setHealth(int health)
        {
            this.health = health;

        }
        public void setCoins(int coins)
        {
            this.coins = coins;

        }

        public void setPosition(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }
    }
}
