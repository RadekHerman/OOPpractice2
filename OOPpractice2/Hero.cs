using System;

namespace OOPpractice2
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public int MaxAttack { get; set; }
        public int MaxBlock { get; set; }

        static private Random random = new Random();

        public Hero(string name = "Hero", int health = 0, int maxAttack = 0, int maxBlock = 0)
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
          
        }

        public override string ToString()
        {
            return $"Warrior: {Name}\tHealth: {Health}\tMax Attack: {MaxAttack}\tMAx Block {MaxBlock}";
        }

        public virtual int AttackStrength(Hero hero_def)
        {

            return random.Next(1, MaxAttack);
        }

        public virtual int BlockStrength()
        {
            return random.Next(0, MaxBlock);
        }
    }
}
