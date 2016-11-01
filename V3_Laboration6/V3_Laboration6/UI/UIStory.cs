using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using V3_Laboration6.ErrorHandling;
using V3_Laboration6.Esthetics;
using V3_Laboration6.GameEngine;

namespace V3_Laboration6
{
    class UIStory
    {

        public static void Intro()
        {
            TextColor.Header("Regicide and turmoil in the Kingdom of Azog!");
            Console.WriteLine("The recent murder of the King has compelled you to return from your warring in the East.");

            TextColor.LineBreak();

            Console.WriteLine("Upon entering the throne room you are promptly confronted by a guardsman who bids you haste.");
            Console.WriteLine(Environment.NewLine + "Contempt is plainly written across his sinewy face.");

            Console.WriteLine(Environment.NewLine + "Press enter to continue.");
            Console.ReadKey();

            TextColor.LineBreak();

            TextColor.Yellow("Guard: ");
            Console.WriteLine("Halt! This room is barred from visitors. Who are you?");

            Player.Name = PlayerName();

            Console.WriteLine("and I am the protector of this realm. I have come to put things right.");

            TextColor.LineBreak();

            Console.WriteLine("You are greeted by Janos, the late King's brother and prince Dariens uncle.");

            TextColor.Yellow("Janos: ");
            Console.WriteLine("Heavens! Foul things have occured in your absence {0}.", Player.Name);

            TextColor.Green("You: ");
            Console.WriteLine("So I have heard.");

            TextColor.Yellow("Janos: ");
            Console.WriteLine("Do all you must. Set matters to rest and part with this most foul of murderers!");

            TextColor.Green("You: ");
            Console.WriteLine("I will do what must be done for the good of the Kingdom. You have my word.");

            Console.ReadLine();
            Console.Clear();
        }

        public static string PlayerName()
        {
            TextColor.Green("I am ");
            return Console.ReadLine();
        }

        public static void AssassinStory()
        {
            TextColor.Green("Press enter to give him the dagger.");
            Console.ReadKey();
            TextColor.Yellow(Environment.NewLine + "Oh, such a shiny dagger!" + Environment.NewLine + Environment.NewLine);
            TextColor.Yellow("Assassin: ");
            Console.WriteLine("Well then, I'm sure you've had a good look at the throne. That blood aint from a human" + 
                Environment.NewLine + Environment.NewLine + "I bet that stable boy in the yard will tell you the same." +
                Environment.NewLine + Environment.NewLine + "I'm also sure you've noticed all the wine in the city. The King was a prodigious drinker himself." + 
                Environment.NewLine + Environment.NewLine + "How I would've killed him? Fool the King to do himself off and then stab his listless body so as to deflect any suspicions.");
            TextColor.Green(Environment.NewLine + "You: ");
            Console.WriteLine("Hmm... I better talk to the King's brother.");
        }

        public static void Outro()
        {
            TextColor.Header("Confrontation with a murderer!");
            TextColor.SubHeader("You confront Janos in the Throne Room where you find him seated upon the Crimson throne.");
            TextColor.LineBreak();
            TextColor.SubHeader("You unsheathe your sword, your strides the stampede of lions. Your voice booming in the empty chamber.");
            TextColor.LineBreak();
            TextColor.SubHeader("Your wrath prompts the truth from him, his knees buckling under the shadow you cast. With a swift stroke of the sword you end this maggot's life.");
            TextColor.LineBreak();
            Console.WriteLine("Thank you for playing. Press enter to exit.");
            Console.ReadKey();
        }

    }
}
