using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIE
{
     class Fighter
    {
        //Health
        public int health = 20;

        //Attack
        public int attack = 5;
        //Defense
        public int defense = 2;
        public int tempDefense = 0;

        public int potion = 2;



        public void TakeDamage(int damage)
        {
            damage = damage - defense - tempDefense;

            health = health - damage;

            if( damage < 0 )
            {
                damage = 0;
            }
            
            
        }   
        
        public void Heal()
        {
            
        }
            
    }

    class Enemy
    {
        public int health = 35;

        public int attack = 5;

        public void TakeDamage(int damage)
        {
            health = health - damage;
        }
    }
}
