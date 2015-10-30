using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class Monster : LivingEntity
    {
        public Monster(int i, bool boss, string monstername)
        {
            if(boss == true)
            {
                maxHP = 50;
                currHP = 50;
                ID = i;
                minDamage = 10;
                maxDamage = 25;
                GoldReward = 50;
                name = monstername;
                Console.WriteLine("Made a boss called: " + name);
            }
            else
            {
                maxHP = 25;
                currHP = 25;
                ID = i;
                minDamage = 5;
                maxDamage = 15;
                GoldReward = 10;
                name = monstername;
                Console.WriteLine("Made a minion called: " + name);
            }
        }

        ~Monster()
        {
            Console.WriteLine("Destroyed a monster");
        }
        int GoldReward { get; set; }
        string name { get; set; }
         
        public int generateDamage()
        {
            Random randomnum = new Random();

            return randomnum.Next(minDamage, maxDamage);
        }

        public bool DamageFromPlayer(int damage)
        {
            currHP = currHP - damage;
            if (currHP <= 0)
            {
                Console.WriteLine("Boss has died.");
                return true;

            }
            else
            {
                Console.WriteLine("Boss now has: " + currHP + " HP left.");
                return false;
            }
        }
     }
}
