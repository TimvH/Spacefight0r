using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Cargoship : Spaceship
    {
        private int cargospace;

        public Cargoship()
        {
            engines = 8;
            fuel = 200;
            cargospace = 20;
        }

        public Cargoship(int cargospace, int engines, int fuel)
        {
            this.cargospace = cargospace;
            this.engines = engines;
            this.fuel = fuel;
        }

        public void LoadCargo()
        {
            cargospace -= 2;
        }

        public void UnloadCargo()
        {
            cargospace += 2;
        }
    }
}
