using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration6
{
    class Game
    {

        Player player = new Player();

        public void Start()
        {
            player.Name = UI.PlayerName();

            var enumList = Enum.GetValues(typeof(Player.Houses))
                .Cast<string>()
                .ToArray();

            foreach (var enumm in enumList)
            {
                Console.WriteLine(enumm);
            }

            Console.ReadKey();

        }
    }
}
