using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class Room
    {

        public int id {get; set;}
        public string RoomName { get; set; }
        public string Description { get; set; }
        public string otherItems { get; set; }
        public int northid { get; set; }
        public int southid { get; set; }
        public int eastid { get; set; }
        public int westid { get; set; }

       
    }
}
