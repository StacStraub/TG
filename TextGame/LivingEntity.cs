using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class LivingEntity
    {
        
        public int ID { get; set; }
        public int currHP {get; set; }
        public int maxHP { get; set; }
        public int minDamage { get; set; }
        public int maxDamage { get; set; }

    }
}
