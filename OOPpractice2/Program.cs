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
            Warrior warrior1 = new Warrior("Agiduz");
            Warrior warrior2 = new Warrior("Betalus");
            Warrior result = Game.Fight(warrior1, warrior2);
            Console.WriteLine("Winner");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
