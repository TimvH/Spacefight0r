using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Fuelstation : Spacestation
    {
        public int fueldepot;

        public Fuelstation()
        {
            fueldepot = 10000;
        }

        public Fuelstation(int fueldepot)
        {
            this.fueldepot = fueldepot;
        }

        
    }
}
