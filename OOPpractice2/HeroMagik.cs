using System;


namespace OOPpractice2
{
    public class HeroMagik : Hero
    {
        public string[] AttackSpell { get; set; }
        public string[] DefenceSpell { get; set; }

        private static Random random = new Random();

        public HeroMagik(string name = "Magic Warrior", int health = 75, int maxAttack = 16, int maxBlock = 6, int unitHealth = 75,
            string[] attackSpell = null, string[] defenceSpell = null)
            :base(name, health, maxAttack, maxBlock, unitHealth) 
        {
            AttackSpell = attackSpell ?? new string[] { "No Spell", "Health_Suck", "Power Hit", "Instant Death" };
            DefenceSpell = defenceSpell ?? new string[] { "No Spell", "Full Block", "Health Plus 20"};
        }

        public override int AttackStrength(Hero heroDefence)
        {
            string attackSpell = "Magik did not manage to sccesfully cast a spell this time";
            int choice = random.Next(0, 10);
            if ((choice == 9) || (choice == 6))
            {
                Console.WriteLine("Magik cast spell: Power HIT");
                return (random.Next(2, MaxAttack) * 10);
            }
            else if (choice == 5)
            {
                if (random.Next(0, 2) == 0)
                {
                    Console.WriteLine("Magik cast spell: Instant Death");
                    return 666;
                }
                else
                {
                    return choice * 10;
                }
            }
            else if ((choice == 1) || (choice == 2) || (choice == 4))
            {
                int suck = random.Next(10, 40);
                heroDefence.Health = heroDefence.Health - suck;
                Health = Health + suck;
                Console.WriteLine($"Magik cast spell: Health Suck, {heroDefence.Name} losing {suck} Health.");
                Console.WriteLine($"And gets another hit");
                return 10;
            }
            else
            {
                Console.WriteLine(attackSpell);
                return random.Next(0, MaxAttack);
            }
            
        }

        public override int BlockStrength()
        {
            int choice = random.Next(0, MaxBlock);

            if (choice < 3)
            {
                Console.WriteLine("Magik cast spell: Power Block");
                return 1000;
            }
            else if ((choice == 7)) 
            {
                Console.WriteLine("Magik cast spell: Health Plus, and gets 50% health");
                Health = Health * (int)1.5m;
                return choice;
            }

            else
            {
                return choice;
            }
            
        }

    }
}
