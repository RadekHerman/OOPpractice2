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
            Hero_Wojownik wojownik = new Hero_Wojownik();
            
            // Hero result = Game.Fight(wielgus, zwinny);
            //Hero result = Game.Fight(wojownik, zwinny);
            Hero result = Game.Fight(wielgus, wojownik, 1, 2 );

            Console.WriteLine("Winner");
            Console.WriteLine(result.Name);
            Console.ReadLine();
        }
    }
}
