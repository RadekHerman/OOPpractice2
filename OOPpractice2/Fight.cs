using System;



namespace OOPpractice2
{
    public class Game
    {
        public static string Fight(Hero warrior1, Hero warrior2, int warrior1_qty = 1, int warrior2_qty = 1)
        {
            Hero[] warriors = new Hero[] {warrior1, warrior2};
            int[] warriors_qty = new int[] { warrior1_qty, warrior2_qty };
            Random random = new Random();
            int index = random.Next(0, warriors.Length);
            Hero first = warriors[index];
            int first_qty = warriors_qty[index];

            Hero second = warriors[(warriors.Length - 1) - index];
            int second_qty = warriors_qty[(warriors_qty.Length - 1) - index];
           
            Console.WriteLine($"first: {first}, qty: {first_qty}");
            Console.WriteLine($"second: {second}, qty: {second_qty}");

            first.Health = first.UnitHealth * first_qty;   // na razie grupuję bohatareów we wspólną ilośc health
            second.Health = second.UnitHealth * second_qty; // na razie grupuję bohatareów we wspólną ilośc health
            int round = 1;
            while (true)
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXx");
                for (int i = 1; i <= first_qty; i++)
                {
                    Console.WriteLine($"Attack: {i}");
                    if (Combat(first, second))
                        return $"{first.Name} after {round} rounds";

                    if (IsExtraTurn(random.Next(2, 10)))
                    {
                        Console.WriteLine($"{first.Name} gest bonus attack turn");
                        i--;
                    }

                }

                decimal second_health_and_qty_check = ((decimal)second.Health / second.UnitHealth) + 0.99m;
                second_qty = (int)second_health_and_qty_check;

                Console.WriteLine(">>>>>>>>>>>");
                Console.WriteLine($"second qty: {second_qty}, second all health {second.Health}");

                for (int i = 1; i <= second_qty; i++)
                {
                    Console.WriteLine($"Attack: {i}");
                    if (Combat(second, first))
                        return $"{second.Name} after {round} rounds";
                }
                
                decimal first_health_and_qty_check = ((decimal)first.Health / first.UnitHealth) + 0.99m;
                first_qty = (int)first_health_and_qty_check;

                Console.WriteLine(">>>>>>>>>>>");
                Console.WriteLine($"first qty: {first_qty}, first all health {first.Health}");
                //Console.ReadLine();
                round ++;
            }
        }

        static bool IsExtraTurn(int random)
        {
            Console.WriteLine(random);
            if (random == 3) return true;
            else return false;
        }

        public static bool Combat(Hero hero_attack, Hero hero_def)
        {
            int attack = 0;
            int block = 0;
            int damage = 0;

            attack = hero_attack.AttackStrength(hero_def);
            block = hero_def.BlockStrength();
            Console.WriteLine($"{hero_attack.Name}  attack: {attack} // {hero_def.Name} block {block}");

            if (attack == 666)  // case of Magik instant death spell
            {
                damage = hero_def.UnitHealth;
                hero_def.Health = hero_def.Health - damage;
            }
            else
            {
                damage = attack - block;
                damage = damage < 0 ? 0 : damage;
            }

            hero_def.Health = hero_def.Health - damage;

            Console.WriteLine($"{hero_attack.Name} did {damage} damage to {hero_def.Name}");
            Console.WriteLine($"Bronicy się full status: {hero_def}");

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx");


                if (hero_def.Health < 0) 
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
