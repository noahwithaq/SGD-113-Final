using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NSantos_SGD111_Final
{
    public class StartScreen
    {
        public static void StartGame(Player currentPlayer)
        {
            Console.WriteLine("|| Tower of Arcanum ||\n");
            Console.WriteLine("Please enter your name:");
            currentPlayer.Name = Console.ReadLine();
            Console.Clear();

            if (currentPlayer.Name == "")
            {
                do
                {
                    Console.WriteLine("|| Tower of Arcanum ||\n");
                    Console.WriteLine("Please enter a valid name:");
                    currentPlayer.Name = Console.ReadLine();
                    Console.Clear();
                } while (currentPlayer.Name == "");
            }

            //intro scene
            Console.WriteLine("|| Intro ||\n");
            Console.WriteLine("As the stagecoach wends its way betwixt the arbor of the Mistveil Valley, your mind is" +
                "\nelsewhere. Five days of nigh constant travel has taken its toll on you, hero though you" +
                "\nmay be. Lulling somewhere between wakefulness and sleep, you recall the missive which set" +
                "\nyou down this road in the first place:" +
                "\n\n       Dearest Saer, would that this letter find you well. You are" +
                "\n       formally invited to attend a night of revelry, graciously" +
                "\n       hosted by Count Razamoth at his abode...");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("|| Intro ||\n");
            Console.WriteLine("The rest of the letter detailed the minutia of decorum expected of attendees - you can" +
                "\nhardly remember, posh drivel that it was. No, the memorable part of the letter was its" +
                "\nvery sending. Count Razamoth, the Mage of a Thousand Lives, a man ubiquitous with secrecy" +
                "\nitself, invited you to his home. Such a summons would have (and has) turned monarchs soft" +
                "\nat the notion. Why you?");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("|| Intro ||\n");
            Console.WriteLine("You didnt' have an answer five days ago and don't have one now. You begin to drift off..." +
                $"\n\n'We have arrived, Master {currentPlayer.Name}.' Your driver gently jostles you awake. You disembark " +
                "\nand take in the environs." +
                "\n\nA massive obsidian spire stretches beyond the fog of this place, seeming impossibly tall." +
                "\nYou take one last look around, and enter.");
            Console.WriteLine("\nPress any key to begin the game.");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
