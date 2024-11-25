using System;

namespace OOPpractice2
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public int MaxAttack { get; set; }
        public int MaxBlock { get; set; }
        public string SpecialSkill { get; set; }

        static private Random random = new Random();

        public Warrior(string name = "Warrior", int health = 100, int maxAttack = 10, int maxBlock = 5, string specialSkill = "")
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
            SpecialSkill = specialSkill;
        }

        public override string ToString()
        {
            return $"Warrior: {Name}\tHealth: {Health}\tMax Attack: {MaxAttack}\tMAx Block {MaxBlock}";
        }

        public int AttackStrength()
        {
            //Random random = new Random();
            return random.Next(1, MaxAttack);
        }

        public int BlockStrength()
        {
            //Random random = new Random();
            return random.Next(0, MaxBlock);
        }
    }
}
