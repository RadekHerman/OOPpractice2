using System;


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
            //Hero result = Game.Fight(magik, zwinny);
            Console.WriteLine("Winner");
            Console.WriteLine(result.Name);
            Console.ReadLine();
        }
    }
}
