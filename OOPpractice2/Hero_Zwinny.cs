using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice2
{
    public class Hero_Zwinny : Hero
    {
        public Hero_Zwinny(string name = "Zwinny", int health = 100, int maxAttack = 25, int maxBlock = 150)
            : base(name, health, maxAttack, maxBlock)
        { 
        }
    }
}
