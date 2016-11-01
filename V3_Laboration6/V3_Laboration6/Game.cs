using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using V3_Laboration6.GameEngine;
using V3_Laboration6.UI;
using V3_Laboration6.Esthetics;

namespace V3_Laboration6
{
    class Game
    {
        public static bool RiddleSolved { get; set; }

        public void Start()
        {

            InitializeGame();

            do
            {
                TextColor.Header("Choose Location");
                int option = UIScene.PrintLocations();

                switch (option)
                {
                    case 1:
                        Manager.SetScene(1);
                        Manager.EnvironmentInteraction();
                        break;
                    case 2:
                        Manager.SetScene(2);
                        Manager.EnvironmentInteraction();
                        break;
                    case 3:
                        Manager.SetScene(3);
                        Manager.EnvironmentInteraction();
                        break;
                }

                Console.Clear();

            } while (!(RiddleSolved));

            UIStory.Outro();
        }

        private void InitializeGame()
        {
            RiddleSolved = false;
            UIStory.Intro();

            // Starting game in Throne Room
            Manager.SetScene(2);
            Manager.EnvironmentInteraction();
        }

        private bool TellTheTruth()
        {
            return false;
        }

    }
}
