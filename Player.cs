using System;
using System.Collections.Generic;
using System.Text;

namespace NSantos_SGD111_Final
{
    public class Player
    {
        public string? Name { get; set; }
        public string? Input { get; set; }
        public Room CurrentRoom { get; set; } = Rooms.Entrance;

        public bool Crystal = false;
        public bool Note = false;
        public bool BossKey = false;
    }
}
