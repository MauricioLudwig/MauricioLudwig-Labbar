using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using V3_Laboration6.ErrorHandling;
using V3_Laboration6.Esthetics;
using V3_Laboration6.GameEngine;

namespace V3_Laboration6.UI
{
    class UIScene
    {

        public static int PrintLocations()
        {
            Console.WriteLine("1. The {0}", Data.Inn.Location);
            Console.WriteLine("2. The {0}", Data.ThroneRoom.Location);
            Console.WriteLine("3. The {0}", Data.Yard.Location);

            return ValidateInput.Integer(1, 3,Environment.NewLine + "Choice: ");
        }

        public static int PrintSceneOptions()
        {
            Console.WriteLine("1. Interact");
            Console.WriteLine("2. Examine");
            Console.WriteLine("3. Go elsewhere");

            return ValidateInput.Integer(1, 3,Environment.NewLine + "Choice: ");
        }

        public static int PrintCharacters(int index)
        {

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("{0}. The {1}", i + 1, Manager.GameScene.Characters[i].Occupation);
            }
            Console.WriteLine("{0}. Return", index + 1);

            return (ValidateInput.Integer(1, index + 1,Environment.NewLine + "Choice: ") - 1);
        }

        public static int PrintCharacterActions()
        {
            Console.WriteLine("1. Talk to Person");
            Console.WriteLine("2. Observe Person");
            Console.WriteLine("3. Return");

            return ValidateInput.Integer(1, 3,Environment.NewLine + "Choice: ");
        }

        public static int PrintItems(int index)
        {

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("{0}. The {1}", i + 1, Manager.GameScene.Items[i].ItemName);
            }
            Console.WriteLine("{0}. Return", index + 1);

            return (ValidateInput.Integer(1, index + 1,Environment.NewLine + "Choice: ") - 1);
        }

    }
}
