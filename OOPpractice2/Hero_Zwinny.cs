using System;


namespace OOPpractice2
{
    
    public class Hero_Zwinny : Hero, IPowerHit 
    {
        static private Random random = new Random();
        public Hero_Zwinny(string name = "Zwinny", int health = 100, int maxAttack = 26, int maxBlock = 201, int unitHealth = 100)
            : base(name, health, maxAttack, maxBlock, unitHealth)
        { 
        }

        public int PowerHit()
        {
            int rnd = random.Next(0, MaxAttack);
            if ((rnd > 9) && (rnd < 16))
            {
                Console.WriteLine($" {this.Name} PowerHIT {rnd * 4}");
                return (rnd * 4);
            }
            else return rnd;
        }

    }
}
