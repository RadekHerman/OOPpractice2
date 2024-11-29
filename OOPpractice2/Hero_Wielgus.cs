using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice2
{
    public class Hero_Wielgus : Hero
    {
        public Hero_Wielgus(string name = "Wielgus", int health = 1000, int maxAttack = 60, int maxBlock = 10, int unitHealth = 1000)
            :base(name, health, maxAttack, maxBlock, unitHealth)
        {
        }
    }
}
