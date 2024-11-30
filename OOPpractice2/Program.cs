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

            string result;

            // fits is attacking, second defending

            // result = Game.Fight(magik, zwinny, 1, 4);
            // result = Game.Fight(magik, wojownik, 1, 1);
            // result = Game.Fight(magik, wielgus, 1, 1);


            // result = Game.Fight(zwinny, wojownik, 2, 1);
            // result = Game.Fight(zwinny, magik, 1, 1);
            // result = Game.Fight(zwinny, wielkus, 1,1);

            // result = Game.Fight(wielgus, zwinny, 1 , 2);
            // result = Game.Fight(wielgus, wojownik, 1, 1);
            // result = Game.Fight(wielgus, magik, 1, 1);
            // result = Game.Fight(wielgus, wielgus, 1, 1);

            // result = Game.Fight(wojownik, zwinny, 1 , 1);
            // result = Game.Fight(wojownik, magik, 1, 1);
            // result = Game.Fight(wojownik, wielgus, 1, 1);

            Console.WriteLine("Winner");
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
