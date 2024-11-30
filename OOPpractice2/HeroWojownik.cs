
using System;

namespace OOPpractice2
{
    public class HeroWojownik : Hero,IPowerHit, IPowerBlock
    {
        static private Random random = new Random();
        public HeroWojownik (string name = "Wojownik", int health = 150, int maxAttack = 51, int maxBlock = 41, int unitHealth = 150) : 
            base (name, health, maxAttack, maxBlock, unitHealth )
        {

        }

        public int PowerHit()
        {
            int rnd = random.Next(0, MaxAttack);
            if ((rnd % 3 == 0) && (rnd > 25))
            {
                Console.WriteLine($" {this.Name} PowerHIT {rnd * 4}");
                return (rnd * 4);
            }
            else return rnd;
        }

   
        public int PowerBlock()
        {
            int rnd = random.Next(0, MaxBlock);
            if ((rnd > 20) && (rnd < 30))
            {
                Console.WriteLine($" {this.Name} PowerBlock 1000 ");
                return 1000;
            }
            else return rnd;

        }
    }

}
