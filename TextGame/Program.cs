using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            Monster minion = new Monster(1, false, "LittleDude");
            Monster boss = new Monster(2, true, "BigDude");
            int damagetaken;
            bool monsterdead = false;
            bool playerdead = false;

            while(monsterdead == false && playerdead == false)
            {
            damagetaken = p.attack();
            Console.WriteLine("Player attacks for: " + damagetaken);
            monsterdead = boss.DamageFromPlayer(damagetaken);
            if(monsterdead == true)
            {
                Console.WriteLine("Player won");
                break;
            }
            damagetaken = boss.generateDamage();
            Console.WriteLine("Boss attack for: " + damagetaken);
            playerdead = p.takeDamage(damagetaken);
            if(playerdead == true)
            {
                Console.WriteLine("Player Lost");
                break;
            }
            System.Threading.Thread.Sleep(3000);
            }


            Console.WriteLine("Curr HP IS: " + p.currHP);

        }
    }
}
