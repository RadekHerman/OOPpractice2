using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice2
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public int MaxAttack { get; set; }
        public int MaxBlock { get; set; }
        public string SpecialSkill { get; set; }

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
    }
}
