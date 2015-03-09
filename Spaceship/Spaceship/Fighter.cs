using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Fighter : Spaceship
    {
        private int ammo;

        public Fighter()
        {
            engines = 2;
            fuel = 50;
            ammo = 250;
        }

        public Fighter(int ammo, int engines, int fuel)
        {
            this.engines = engines;
            this.fuel = fuel;
            this.ammo = ammo;
        }

        public void Shoot()
        {
            ammo -= 1;
        }
    }
}
