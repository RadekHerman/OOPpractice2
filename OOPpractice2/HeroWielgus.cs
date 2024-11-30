using System;


namespace OOPpractice2
{
    public class HeroWielgus : Hero, IPowerHit
    {
        static private Random random = new Random();
        public HeroWielgus(string name = "Wielgus", int health = 1000, int maxAttack = 60, int maxBlock = 10, int unitHealth = 1000)
            : base(name, health, maxAttack, maxBlock, unitHealth)
        {
        }


        public int PowerHit()
        {
            int rnd = random.Next(0, MaxAttack);
            if ((rnd > 7) && (rnd < 15))
            {
                Console.WriteLine($" {this.Name} PowerHIT {rnd * 10}");
                return (rnd * 10);
            }
            else return rnd;
        }
    }
}
