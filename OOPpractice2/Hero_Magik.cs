using System;


namespace OOPpractice2
{
    public class Hero_Magik : Hero
    {
        public string[] Attack_spell { get; set; }
        public string[] Defence_spell { get; set; }

        private static Random random = new Random();

        // public string[] Spell {get;} = { "No Spell", "Full Block", "Power Hit", "Instant Death", "Extra Turn" };
        public Hero_Magik(string name = "Magic Warrior", int health = 75, int maxAttack = 16, int maxBlock = 6, int unitHealth = 75,
            string[] attack_spell = null, string[] defence_spell = null)
            :base(name, health, maxAttack, maxBlock, unitHealth) 
        {
            Attack_spell = attack_spell ?? new string[] { "No Spell", "Health_Suck", "Power Hit", "Instant Death" };
            Defence_spell = defence_spell ?? new string[] { "No Spell", "Full Block", "Health Plus 20"};
        }

        public override int AttackStrength(Hero hero_def)
        {
            //int count = 0; // podwója próba przy instant death ??
            string attack_spell = "Magik did not manage to sccesfully cast a spell this time";
            //string attack_spell = AtackSpellName();
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
                hero_def.Health = hero_def.Health - suck;
                Health = Health + suck;
                Console.WriteLine($"Magik cast spell: Health Suck, {hero_def.Name} losing {suck} Health.");
                Console.WriteLine($"And gets another hit");
                return 10;
            }
            else
            {
                Console.WriteLine(attack_spell);
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
