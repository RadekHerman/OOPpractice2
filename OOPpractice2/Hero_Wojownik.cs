﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice2
{
    public class Hero_Wojownik : Hero
    {
        public Hero_Wojownik (string name = "Wojownik", int health = 130, int maxAttack = 40, int maxBlock = 40) : 
            base (name, health, maxAttack, maxBlock )
        {

        }
    }
}