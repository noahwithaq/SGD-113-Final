using System;
using System.Collections.Generic;
using System.Text;

namespace NSantos_SGD111_Final
{
    public static class Rooms //i probably definitely could've used an array here but i was having issues with
                              //certain unique interactions
    {
        public static Room Entrance = new Room("|| Entrance Hall ||\n",
            "Long shadows are cast upon the walls in the flickering torchlight. Portraits on either wall" +
            "\nstare at you as you slowly tread through the hall. No one comes to greet you.",
            "As your eyes adjust to the dark, you see a faint glow to the north.\n");
        public static Room Atrium = new Room("|| Atrium ||\n",
            "The atrium is lit by phantom moonlight. You see no windows but feel an icy lunar gaze" +
            "\nchill your spine just the same. Tapestries flutter gently on phantom winds. There is" +
            "\nno one here.",
            "There are doors to your east and west, and a large art piece to the north.\n");
        public static Room AtriumNorth = new Room("|| Atrium - North ||\n",
            "What at a distance appeared to be a mosaic is now clearly revealed to be a set of massive" +
            "\nstone doors. Sanguine crystal tendrils decorate each one.", 
            "The seams of the doors are incredibly obvious but there is no obvious way of actually" +
            "\nopening them, having neither lock nor handle.\n");
        public static Room DiningHall = new Room("|| Dining Hall ||\n",
            "A room what could easily host a tenscore of guests, completely empty. There is one table" +
            "\nspanning the entire length of the room, yet only three places set at the far end.",
            "There's some food scattered about the table. Nothing looks particularly edible.\n");
        public static Room Stairwell = new Room("|| Stairwell ||\n",
            "This room is starkly empty save for a staircase against the west wall leading to the" +
            "\nsecond floor.",
            "Who builds a staircase in its own dedicated room?\n");
        public static Room Dungeon = new Room("|| Dungeon ||\n",
            "You know you made a mistake the moment your foot connects with the first step. Or rather," +
            "\nthe fact it doesn't. You slip through the illusory staircase and land with a thud." +
            "\n\nSlowly rising, you find yourself in a dank corridor. A liquid you can only hope to is" +
            "\nwater drips through the ceiling.",
            "Though dark, you can see doors to the north and south, and an intersecting hall coming" +
            "\nfrom the west.\n");
        public static Room ExperimentRoom = new Room("|| Experiment Room ||\n",
            "Manacled chains hang from a low ceiling. Various implements hang on the wall above a crude" +
            "\nworkstation, none of their uses readily apparent at a mere glance. There is a table" +
            "\ndirectly in the middle of the room, its wood darkened and depressed in a disturbingly" +
            "\nhumanoid silhouette.",
            "In the drawers of the work station, you find a document that appears to be half-report," +
            "\nhalf-manifesto. The author details various ways in which he means to 'evissurate' whoever" +
            "\ncomes between him and his work.\n");
        public static Room Kennels = new Room("|| Kennel ||\n",
            "Though the sign on the door says 'Kennel', the cages lining this place seem slightly too" +
            "\nlarge for a beast. As you're about to leave, you hear a rustling coming from one of" +
            "\nthe cages.",
            "Approaching the sound, you find only a skeleton clutching a note: 'Their words are their power.'\n");
        public static Room GuardsRoom = new Room("|| Guards' Room ||\n",
            "Compared to the rest of this place, the room is oddly cozy. A well-made wooden table hosts" +
            "\na half-played game of cards. The floors are mostly carpeted with various pelts, and a" +
            "\nhearth embers softly in one corner.",
            "There are doors to the east and west.\n");
        public static Room GuardsRoomBookshelf = new Room("|| Guards' Room - Bookshelf ||\n",
            "Seeming like a door in the dim light, what you find is actually a bookshelf. None of them appear" +
            "\nparticularly well-loved.",
            "It seems even prison guards enjoy risque literature.\n");
        public static Room WarpRoom = new Room("|| Warp Room ||\n",
            "While it's true you're currently in the basement of a wizard's tower, this room feels" +
            "\nespecially arcane.",
            "An intricate illustration of shapes and runes adorn the eastern wall.\n");
        public static Room Balcony = new Room("|| Balcony ||\n",
            "A balcony overlooking the atrium. There was no indication of its existence from the first floor" +
            "\ndespite the fact it plainly overlooks the place.",
            "There are doors to the north, east, and west.\n");
        public static Room WizardsQuarters = new Room("|| Wizard's Quarters ||\n",
            "This room can only be described as a 'den of iniquity.' Merely standing in the threshold makes" +
            "\nyour skin crawl.",
            "Some curiosities are better left unsated.\n");
        public static Room EnchantRoom = new Room("|| Enchantment Room ||\n",
            "Rows upon rows of books and tomes line the walls of this room. In the center, an altar. Besides" +
            "\nthe literature, you see countless glass baubles of various ilk stored here as well.",
            "The developer of this game mismanaged his time, so there's nothing to see here.\n");
        public static Room PuzzleDoor = new Room("|| Locked Door ||\n",
            "Another impass. This time, approaching the door causes a message to appear directly in your head:" +
            "\n\n'What are the magic words?'",
            "Surely the answer can't be that obvious...\n");
        public static Room End = new Room("", ""); //end of loop in Main checks if they're here; breaks loop if yes, repeats if no


        public static void BuildMap() //mapping (this feels like an incredibly stupid way to do this lol)
        {
            //mapping (note that this is assuming all keys are obtained)
            Rooms.Entrance.North = Rooms.Atrium;

            Rooms.Atrium.North = Rooms.AtriumNorth;
            Rooms.Atrium.East = Rooms.DiningHall;
            Rooms.Atrium.South = Rooms.Entrance;
            Rooms.Atrium.West = Rooms.Stairwell;

            Rooms.AtriumNorth.North = Rooms.Balcony;
            Rooms.AtriumNorth.South = Rooms.Atrium;
            
            Rooms.DiningHall.West = Rooms.Atrium;

            Rooms.Stairwell.East = Rooms.Atrium;
            Rooms.Stairwell.West = Rooms.Dungeon;

            Rooms.Dungeon.North = Rooms.ExperimentRoom;
            Rooms.Dungeon.South = Rooms.GuardsRoom;
            Rooms.Dungeon.West = Rooms.Kennels;

            Rooms.ExperimentRoom.South = Rooms.Dungeon;

            Rooms.Kennels.East = Rooms.Dungeon;

            Rooms.GuardsRoom.North = Rooms.Dungeon;
            Rooms.GuardsRoom.East = Rooms.WarpRoom;
            Rooms.GuardsRoom.West = Rooms.GuardsRoomBookshelf;

            Rooms.GuardsRoomBookshelf.East = Rooms.GuardsRoom;

            Rooms.WarpRoom.East = Rooms.Atrium;
            Rooms.WarpRoom.West = Rooms.GuardsRoom;

            Rooms.Balcony.North = Rooms.PuzzleDoor;
            Rooms.Balcony.East = Rooms.WizardsQuarters;
            Rooms.Balcony.South = Rooms.AtriumNorth;
            Rooms.Balcony.West = Rooms.EnchantRoom;

            Rooms.WizardsQuarters.West = Rooms.Balcony;

            Rooms.EnchantRoom.East = Rooms.Balcony;

            Rooms.PuzzleDoor.South = Rooms.Balcony;
        }

        public static void UpdateMap(Player currentPlayer) //should probably separate these into two functions, this one and a new one Interactions()
        {
            if (Rooms.Dungeon.HasVisited == false) //possibly redundant
            {
                Rooms.Stairwell.West = Rooms.Dungeon;
            }
            else 
            {
                Rooms.Stairwell.West = null;
                Rooms.Stairwell.Text = "There was a hole here. It's gone now.";

                Rooms.Dungeon.Text = "A dank stone corridor. It is very cold, and something is dripping from the ceiling.";
            }

            if (currentPlayer.CurrentRoom == Rooms.Dungeon)
            {
                Rooms.Dungeon.HasVisited = true;
            }

            if (currentPlayer.CurrentRoom == Rooms.Kennels &&
                (currentPlayer.Input == "explore" || currentPlayer.Input == "look around" || currentPlayer.Input == "search"))
            {
                currentPlayer.Note = true;
            }

            if (currentPlayer.Note == true)
            {
                Rooms.GuardsRoomBookshelf.Explore = "'Their words are their power...' was more literal than you thought; a crystal" +
                    "\nflies of the bookshelf and into the warp room.\n";
            }

            if (currentPlayer.CurrentRoom == Rooms.GuardsRoomBookshelf &&
                (currentPlayer.Note == true) &&
                (currentPlayer.Input == "explore" || currentPlayer.Input == "look around" || currentPlayer.Input == "search"))
            {
                currentPlayer.Crystal = true;
            }

                if (currentPlayer.Crystal == false)
            {
                Rooms.AtriumNorth.North = null;
                Rooms.WarpRoom.East = null;
            }
            else 
            {
                Rooms.AtriumNorth.North = Rooms.Balcony; 
                Rooms.AtriumNorth.Text = "The crystal you just obtained glows red in your hand as the door slowly opens. This\n" +
                    "all feels like lazy game design to you.";

                Rooms.WarpRoom.East = Rooms.Atrium;
                Rooms.WarpRoom.Text = "A portal has opened on the eastern wall.";
            }

            if (currentPlayer.CurrentRoom == Rooms.PuzzleDoor &&
                (currentPlayer.Input == "abra kadabra" || currentPlayer.Input == "open sesame"))
            {
                currentPlayer.BossKey = true;
            }

            if (currentPlayer.BossKey == false)
            {
                Rooms.PuzzleDoor.North = null;
            }
            else
            {
                Rooms.PuzzleDoor.North = Rooms.End;
                Rooms.PuzzleDoor.Text = "You step back and watch the door slowly evaporate before your eyes. One final" +
                    "\nstaircase lays ahead of you.";
            }
        }
    }
}
