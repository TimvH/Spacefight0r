using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Program
    {
        Random rnd = new Random();
        static Spaceship player = new Spaceship();

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("You suck");
                player.SetHealth(0);
            } while (player.GetHealth() > 0);
            Console.ReadKey();
        }
    }
}
