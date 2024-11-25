using System;



namespace OOPpractice2
{
    public class Game
    {
        public static Hero Fight(Hero warrior1, Hero warrior2)
        {
            Hero[] warriors = new Hero[] {warrior1, warrior2};
            Random random = new Random();
            int index = random.Next(0, warriors.Length);
            //Console.WriteLine("index: "+index);
            //Console.WriteLine("length: "+warriors.Length);
            Hero first = warriors[index];
            Hero second = warriors[(warriors.Length - 1) - index];
            
            Console.WriteLine("firts:\n" + first);
            Console.WriteLine("second:\n" + second);

            while (true)
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXx");
                if (Combat(first, second))
                    return first;

                if (Combat(second, first))
                    return second;

            }
        }


        public static bool Combat(Hero warrior_attck, Hero warrior_def)
        {
            int attack = 0;
            int block = 0;
            int damage = 0;

                attack = warrior_attck.AttackStrength();
                block = warrior_def.BlockStrength();    
                Console.WriteLine($"attack {attack} block {block}");
                damage = attack - block;
                damage = damage < 0 ? 0 : damage;

                warrior_def.Health = warrior_def.Health - damage;

                Console.WriteLine($"{warrior_attck.Name} did {damage} damage to {warrior_def.Name}");   
                Console.WriteLine($"Bronicy się: {warrior_def}");


                if (warrior_def.Health < 0) 
                    return true;
                else return false;
        }


        private static bool IsWinner(Hero warrior)
        {
            if (warrior.Health < 0)
                return true;
            return false;
        }
    }
}
