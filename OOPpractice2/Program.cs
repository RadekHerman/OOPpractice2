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
            Warrior warrior1 = new Warrior("V");
            Warrior warrior2 = new Warrior("X");
            string result = Game.Fight(warrior1, warrior2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
