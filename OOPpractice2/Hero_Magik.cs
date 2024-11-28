using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOPpractice2
{
    public class Hero_Magik : Hero
    {
        public string[] Attack_spell { get; set; }
        public string[] Defence_spell { get; set; }

        private static Random random = new Random();

        // public string[] Spell {get;} = { "No Spell", "Full Block", "Power Hit", "Instant Death", "Extra Turn" };
        public Hero_Magik(string name = "Magic Warrior", int health = 75, int maxAttack = 10, int maxBlock = 5, 
            string[] attack_spell = null, string[] defence_spell = null)
            :base(name, health, maxAttack, maxBlock) 
        {
            Attack_spell = attack_spell ?? new string[] { "No Spell", "Health_Suck", "Power Hit", "Instant Death", "Extra Turn" };
            Defence_spell = defence_spell ?? new string[] { "No Spell", "Full Block", "Health Plus 20"};
        }

        public override int AttackStrength(Hero hero_def)
        {
            string attack_spell = AtackSpellName();
            return 10;
        }

        private static string AtackSpellName()
        {
            int count = 0; // for instant death need to choose once again
            string attack_spell = "No Spell";
            int choice = random.Next(0, 10);
            switch(choice)
            {
                case 0:
                case 1:
                case 7:
                    attack_spell = "No Spell";
                    break;
                case 2:
                case 3:
                    attack_spell = "Health_Suck";
                    break;
                case 4:
                case 5:
                     attack_spell = "Power Hit";
                    break;

                case 6:
                    if (count == 0)
                    {
                        count++;
                        AtackSpellName();
                    }
                    
                    attack_spell = "Power Hit";
                    break;
                    
                case 8:
                    break;



            }
            return attack_spell;
        }
    }
}
