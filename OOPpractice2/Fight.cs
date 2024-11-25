using System;



namespace OOPpractice2
{
    public class Game
    {
        public static Warrior Fight(Warrior warrior1, Warrior warrior2)
        {
            Warrior[] warriors = new Warrior[] {warrior1, warrior2};
            Random random = new Random();
            int index = random.Next(0, warriors.Length);
            //Console.WriteLine("index: "+index);
            //Console.WriteLine("length: "+warriors.Length);
            Warrior first = warriors[index];
            Warrior second = warriors[(warriors.Length - 1) - index];
            
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


        public static bool Combat(Warrior warrior_attck, Warrior warrior_def)
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


        private static bool IsWinner(Warrior warrior)
        {
            if (warrior.Health < 0)
                return true;
            return false;
        }
    }
}
