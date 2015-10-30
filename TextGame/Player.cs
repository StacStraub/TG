using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class Player : LivingEntity
    {
        public Player()
        {
            ID = 1;
            maxHP = 100;
            currHP = 100;
            currGold = 0;
            level = 1;
            currXP = 0;
            minDamage = 5;
            maxDamage = 15;
            Console.WriteLine("Created a Player with max HP of: " + maxHP);
        }
        ~Player()
        {
            Console.WriteLine("Deleting Player");
        }

        public bool takeDamage(int damage)
        {
            currHP = currHP - damage;
            if (currHP <= 0)
            {
                Console.WriteLine("Player has died.");
                return true;
            }
            else
            {

                Console.WriteLine("Player now has: " + currHP + " HP left.");
                return false;
            }
        }

        public int attack()
        {
            Random rand = new Random();

           return  rand.Next(minDamage, maxDamage);
        }

        public int currGold { get; set; }
        public int level { get; set;}
        public int currXP { get; set; }
    }
}
