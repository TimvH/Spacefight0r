using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Spaceship
    {
        protected int engines;
        protected int fuel;

        Wallet wallet = new Wallet();
        public Spaceship()
        {
            engines = 4;
            fuel = 100;
        }

        public Spaceship(int engines, int fuel)
        {
            this.engines = engines;
            this.fuel = fuel;
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
    }
}
