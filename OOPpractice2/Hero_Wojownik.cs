using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice2
{
    public class Hero_Wojownik : Hero
    {
        public Hero_Wojownik (string name = "Wojownik", int health = 150, int maxAttack = 41, int maxBlock = 41, int unitHealth = 150) : 
            base (name, health, maxAttack, maxBlock, unitHealth )
        {

        }
    }
}
