using System;
using System.Collections.Generic;
using System.Text;

namespace NSantos_SGD111_Final
{
    public class Room(string name, string text, string? explore = null)
    {
        public Room? North, East, South, West;
        public string Name = name;
        public string Text = text;
        public string? Explore = explore;
        public bool HasVisited = false;
    }
}
