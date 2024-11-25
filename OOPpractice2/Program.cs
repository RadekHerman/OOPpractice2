using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Warrior warrior1 = new Warrior("Agiduz", health: 100, maxAttack: 25, maxBlock: 40);
            //Warrior warrior2 = new Warrior("Betalus", health: 100, maxAttack: 50, maxBlock: 10);

            Warrior warrior1 = new Warrior("Agiduz", health: 100, maxAttack: 25, maxBlock: 200);
            Warrior warrior2 = new Warrior("Betalus", health: 1000, maxAttack: 50, maxBlock: 0);
            //Warrior warrior1 = new Warrior("Agiduz");
            //Warrior warrior2 = new Warrior("Betalus");
            Warrior result = Game.Fight(warrior1, warrior2);
            Console.WriteLine("Winner");
            Console.WriteLine(result.Name);
            Console.ReadLine();
        }
    }
}
