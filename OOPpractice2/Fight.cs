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
            //Warrior winner;

            Console.WriteLine($"Warrior {first.Name} will attack first");
            Warrior winner = Result(first, second);
            
            return winner;
        }


        public static Warrior Result(Warrior first, Warrior second)
        {
            int attack = 0;
            int block = 0;
            int damage = 0;

            while (true)
            {
                //isWinner = Winner(first, second);

                attack = AttackStrength(first);

                block = BlockStrength(second);
                damage = attack - block;

                second.Health = second.Health - damage;

                Console.WriteLine($"{first.Name} did {damage} damage to {second.Name}");

                if (IsWinner(second))
                    return first;

                attack = AttackStrength(second);
                block = BlockStrength(first);

                first.Health = first.Health - damage;

                Console.WriteLine($"{second.Name} did {damage} damage to {first.Name}");

                if (IsWinner(first))
                    return second;
              
            }
        }
        public static int AttackStrength (Warrior warrior)
        {
            Random random = new Random();
            return random.Next(1, warrior.MaxAttack);
        }

        public static int BlockStrength (Warrior warrior)
        {
            Random random = new Random();
            return random.Next(0, warrior.MaxBlock);
        }

        public static bool IsWinner(Warrior warrior)
        {
            if (warrior.Health < 0)
                return true;
            return false;
        }
    }
}
