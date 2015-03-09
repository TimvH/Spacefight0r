using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    // hai
    class Spaceship
    {
        Wallet wallet = new Wallet(1000);

        protected int engines;
        protected int fuel;
        protected bool isDocked;
        protected int fuelTankSize;

        public Spaceship()
        {
            engines = 4;
            fuel = 100;
            fuelTankSize = 100;
        }

        public Spaceship(int engines, int fuel, int fuelTankSize)
        {
            this.engines = engines;
            this.fuel = fuel;
            this.fuelTankSize = fuelTankSize;
        }

        public void Move()
        {
            fuel -= engines;
        }

        public int GetEngines()
        {
            return engines;
        }

        public void SetEngines(int engines)
        {
            this.engines = engines;
        }

        public int GetFuel()
        {
            return fuel;
        }

        public void SetFuel(int fuel)
        {
            this.fuel = fuel;
        }

        public void Dock()
        {
            isDocked = true;
        }

        public void Undock()
        {
            isDocked = false;
        }

        public void RefillFuel(Fuelstation station)
        {
            if (station.fueldepot > 0 && fuel < fuelTankSize)
            {
                fuel += 10;
                station.fueldepot -= 10;
            }
        }
    }
}
