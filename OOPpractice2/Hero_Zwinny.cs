using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice2
{
    public class Hero_Zwinny : Hero
    {
        public Hero_Zwinny(string name = "Zwinny", int health = 100, int maxAttack = 26, int maxBlock = 151, int unitHealth = 100)
            : base(name, health, maxAttack, maxBlock, unitHealth)
        { 
        }
    }
}
