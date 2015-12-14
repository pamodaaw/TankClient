using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankClient
{
    class Coinpack:Block
    {

        int time_to_disappear;
        int amount;

        public Coinpack()
        {

        }

        public void setTime(int time)
        {
            this.time_to_disappear = time;
        }
        public void setAmount(int amount)
        {
            this.amount = amount;
        }

    }
}
