using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using V3_Laboration6.Environments.Models;
using V3_Laboration6.UI;
using V3_Laboration6.Esthetics;

namespace V3_Laboration6.GameEngine
{
    public class Manager
    {
        public static IEnvironment GameScene { get; set; }
        public static bool FirstClueSolved { get; set; }

        public static void SetScene(int environment)
        {
            GameScene = Data.SetEnvironment(environment);
        }

        public static void EnvironmentInteraction()
        {

            bool menu = true;

            do
            {
                Console.Clear();

                TextColor.Header("Current Location: " + GameScene.Location);
                TextColor.SubHeader(GameScene.ObserveEnvironment());

                int option = UIScene.PrintSceneOptions();

                switch (option)
                {
                    case 1:
                        SelectCharacter();
                        break;
                    case 2:
                        SelectItem();
                        break;
                    case 3:
                        menu = false;
                        break;
                    default:
                        break;
                }
                Console.Clear();

            } while (menu);

        }

        private static void SelectCharacter()
        {
            int option;
            bool loop = true;

            do
            {
                Console.Clear();
                TextColor.Header("Interact With...");
                option = UIScene.PrintCharacters(GameScene.Characters.Count);

                if (option != GameScene.Items.Count)
                {

                    bool secondaryLoop = true;
                    do
                    {
                        Console.Clear();
                        TextColor.Header("Available Actions");
                        int action = CharacterInteraction();

                        switch (action)
                        {
                            case 1:
                                TextColor.SubHeader(Environment.NewLine + GameScene.Characters[option].Conversation());
                                if (FirstClueSolved && GameScene.Characters[option].Name == "Dregor")
                                    SolveRiddle();
                                Console.ReadKey();
                                break;
                            case 2:
                                TextColor.SubHeader(Environment.NewLine + GameScene.Characters[option].PrintAppearance());
                                Console.ReadKey();
                                break;
                            case 3:
                                secondaryLoop = false;
                                break;
                        }
                    } while (secondaryLoop);
                }
                else
                    loop = false;

            } while (loop);
        }

        private static int CharacterInteraction()
        {
            return UIScene.PrintCharacterActions();
        }

        private static void SelectItem()
        {
            int option;
            bool loop = true;

            do
            {
                Console.Clear();
                TextColor.Header("Examine...");
                option = UI.UIScene.PrintItems(GameScene.Items.Count);

                if (option != GameScene.Items.Count)
                {
                    Console.Clear();
                    TextColor.Header(GameScene.Items[option].ItemName);
                    TextColor.SubHeader(GameScene.Items[option].Description());

                    if (GameScene.Items[option].Retrievable)
                    {
                        TextColor.Green(GameScene.Items[option].Retrieve());
                        Data.Yard.Items.RemoveAt(1);
                        FirstClueSolved = true;
                    }

                    Console.ReadKey();
                }
                else
                    loop = false;

            } while (loop);
        }

        private static void SolveRiddle()
        {
            UIStory.AssassinStory();
            Game.RiddleSolved = true;
        }

    }
}
