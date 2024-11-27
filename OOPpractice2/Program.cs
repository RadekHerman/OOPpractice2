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
            result = Game.Fight(wielgus, zwinny, 1 , 3);
            //result = Game.Fight(wojownik, zwinny, 1, 1);
            //result = Game.Fight(wielgus, wojownik, 1, 3);


            //result = Game.Fight(wielgus, wojownik, 50, 110);
            // result = Game.Fight(wielgus, zwinny, 50, 50);

            Console.WriteLine("Winner");
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
