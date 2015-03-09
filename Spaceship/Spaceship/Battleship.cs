using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Battleship
    {
        private int health;
        private int dmg;

        public Battleship()
        {
            health = 100;
            dmg = 50;
        }

        public void SetHealth(int newhealth)
        {
            health = newhealth;
        }

        public int GetHealth()
        {
            return health;
        }

        public void SetDmg(int newdmg)
        {
            dmg = newdmg;
        }
    }
}
