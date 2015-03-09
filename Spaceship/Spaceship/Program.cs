using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Program
    {
        static Random rnd = new Random();
        static Spaceship[] space = new Spaceship[10];

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to shipflyer V1.0");

            Console.WriteLine("Initializing 10 ships.");
            InitShip();
            for (int i = 0; i < 10; i++)
            {
                space[i].Move();
                Console.WriteLine("Moved spaceship {0}", i);
                Console.WriteLine("Spaceship {0} now has {1} fuel.", i, space[i].GetFuel());
            }

            Console.ReadKey();
        }

        public static void InitShip()
        {
            for(int i = 0; i < 10; i++)
            {
                space[i] = new Spaceship(4, rnd.Next(51, 200));
            }
        }
    }
}
