using System;


namespace OOPpractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HeroMagik magik = new HeroMagik();
            HeroWielgus wielgus = new HeroWielgus();
            HeroZwinny zwinny = new HeroZwinny();
            HeroWojownik wojownik = new HeroWojownik();

            string result;

            // fits is attacking, second defending

             result = Game.Fight(magik, zwinny, 1, 4);
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
