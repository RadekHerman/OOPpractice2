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
     
            Hero_Magik magik = new Hero_Magik();
            Hero_Wielgus wielgus = new Hero_Wielgus();
            Hero_Zwinny zwinny = new Hero_Zwinny();
            
            Hero result = Game.Fight(wielgus, zwinny);
            Console.WriteLine("Winner");
            Console.WriteLine(result.Name);
            Console.ReadLine();
        }
    }
}
