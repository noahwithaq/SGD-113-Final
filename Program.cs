namespace NSantos_SGD111_Final
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player currentPlayer = new Player();

            bool playing = true;

            StartScreen.StartGame(currentPlayer);

            Rooms.BuildMap();


            while (playing)
            {
                //check the world state
                Rooms.UpdateMap(currentPlayer);

                //display the scene
                Console.WriteLine(currentPlayer.CurrentRoom.Name);
                Console.WriteLine(currentPlayer.CurrentRoom.Text);

                Console.WriteLine("\nWhat do you do?");
                currentPlayer.Input = Console.ReadLine().Trim().ToLower();
                Console.Clear();

                switch (currentPlayer.Input)
                {
                    //check if they quit
                    case "exit":
                    case "quit":
                        playing = false; 
                        break;

                    //check if they move
                    case "north":
                    case "go north":
                        if (currentPlayer.CurrentRoom.North != null)
                            currentPlayer.CurrentRoom = currentPlayer.CurrentRoom.North;
                        else
                            Console.WriteLine("You cannot travel in that direction.\n");
                        break;

                    case "east":
                    case "go east":
                        if (currentPlayer.CurrentRoom.East != null)
                            currentPlayer.CurrentRoom = currentPlayer.CurrentRoom.East;
                        else
                            Console.WriteLine("You cannot travel in that direction.\n");
                        break;

                    case "south":
                    case "go south":
                        if (currentPlayer.CurrentRoom.South != null)
                            currentPlayer.CurrentRoom = currentPlayer.CurrentRoom.South;
                        else
                            Console.WriteLine("You cannot travel in that direction.\n");
                        break;

                    case "west":
                    case "go west":
                        if (currentPlayer.CurrentRoom.West != null)
                            currentPlayer.CurrentRoom = currentPlayer.CurrentRoom.West;
                        else
                            Console.WriteLine("You cannot travel in that direction.\n");
                        break;

                    //check if they interact
                    case "explore":
                    case "search":
                    case "look around":
                        if (currentPlayer.CurrentRoom.Explore != null)
                            Console.WriteLine(currentPlayer.CurrentRoom.Explore);
                        else
                            Console.WriteLine("There is nothing to find.\n");
                        break;

                    case "abra kadabra":
                    case "open sesame":
                        break;

                    default:
                        Console.WriteLine("Invalid command.\n");
                        break;
                }

                //check if they won
                if (currentPlayer.CurrentRoom == Rooms.End)
                {
                    break;
                }
            }

            if (playing)
            {
                Console.WriteLine("|| Top Floor ||\n");
                Console.WriteLine("Ascending the staircase, you're filled with a sense of dread. What could possibly await" +
                    "\nyou at the top of these stairs? After what feels like minutes of climbing, you" +
                    "\nreach the top. You steel yourself and enter the final door.");
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey(true);
                Console.Clear();

                Console.WriteLine("|| Top Floor ||\n");
                Console.WriteLine("What you find beyond the door leaves you sorely disappointed. You see a disheveled boy," +
                    "\nperhaps 19 or 20, sitting awkwardly in a chair. He is hunched over a black slate" +
                    "\ncovered in buttons, tapping away at it as letters show up on another slate in front" +
                    "\nof him.");
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey(true);
                Console.Clear();

                Console.WriteLine("|| Top Floor ||\n");
                Console.WriteLine("'Oh okay... no, wait, hold on... okay, so- Oh! I get it... damn, no I don't..." +
                    "\nOr, hmm... Oh god, I'm stupid, I can just use a switch statement... and press F5..." +
                    "\nI'm a genius!'" +
                    "\n\nHe has yet to notice your presence and there is no one else in the room." +
                    "\nYou decide it's best to leave this sociopath to his own devices.");
                Console.WriteLine("\nPress any key to leave this sociopath to his own devices.");
                Console.ReadKey(true);
                Console.Clear();

                Console.WriteLine("Thanks for playing this janky mess!");
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
