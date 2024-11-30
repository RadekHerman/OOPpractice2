using System;
using System.Runtime.CompilerServices;



namespace OOPpractice2
{
    public class Game
    {
        public static string Fight(Hero heroAttack, Hero heroDefence, int heroAttackQty = 1, int heroDefenceQty = 1)
        {
            Random random = new Random();
            heroAttack.Health = heroAttack.UnitHealth * heroAttackQty;   // na razie grupuję bohatareów we wspólną ilośc health
            heroDefence.Health = heroDefence.UnitHealth * heroDefenceQty; // na razie grupuję bohatareów we wspólną ilośc health
            int round = 1;
            while (true)
            {
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine($"XXXXXXXXXXX ROUND {round} XXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("XXXXX HERO ATTACKING XXXXXXXXXXXXXXXXXXXXXx");
                for (int i = 1; i <= heroAttackQty; i++)
                {
                    //Console.WriteLine($"Attack: {i}");
                    if (Combat(heroAttack, heroDefence))
                        return $"{heroAttack.Name} after {round} rounds";

                    if (IsExtraTurn(random.Next(2, 10)))
                    {
                        Console.WriteLine($"{heroAttack.Name} gest bonus attack turn");
                        i--;
                    }

                }

                decimal heroDefenceHealthAndQtyCheck = ((decimal)heroDefence.Health / heroDefence.UnitHealth) + 0.99m;
                heroDefenceQty = (int)heroDefenceHealthAndQtyCheck;

                Console.WriteLine(">>>>>>>>>>>");
                Console.WriteLine($"second qty: {heroDefenceQty}, second all health {heroDefence.Health}");

                Console.WriteLine("XXXXX HERO DEFENDING XXXXXXXXXXXXXXXXXXXXXx");
                for (int i = 1; i <= heroDefenceQty; i++)
                {
                    Console.WriteLine($"Attack: {i}");
                    if (Combat(heroDefence, heroAttack))
                        return $"{heroDefence.Name} after {round} rounds";
                }
                
                decimal heroAttckHealthandQtyCheck = ((decimal)heroAttack.Health / heroAttack.UnitHealth) + 0.99m;
                heroAttackQty = (int)heroAttckHealthandQtyCheck;

                Console.WriteLine(">>>>>>>>>>>");
                Console.WriteLine($"first qty: {heroAttackQty}, first all health {heroAttack.Health}");
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

        public static bool Combat(Hero heroA, Hero heroB)
        {
            int attack = 0;
            int block = 0;
            int damage = 0;

            attack = heroA.AttackStrength(heroB);
            block = heroB.BlockStrength();
            Console.WriteLine($"{heroA.Name}  attack: {attack} // {heroB.Name} block {block}");

            if (attack == 666)  // case of Magik instant death spell
            {
                damage = heroB.UnitHealth;
                heroB.Health = heroB.Health - damage;
            }
            else
            {
                damage = attack - block;
                damage = damage < 0 ? 0 : damage;
            }

            heroB.Health = heroB.Health - damage;

            Console.WriteLine($"{heroA.Name} did {damage} damage to {heroB.Name}");
            Console.WriteLine($"Bronicy się full status: {heroB}");

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx");
                if (heroB.Health < 0) 
                    return true;
                else return false;
        }


        private static bool IsWinner(Hero hero)
        {
            if (hero.Health < 0)
                return true;
            return false;
        }
    }
}
