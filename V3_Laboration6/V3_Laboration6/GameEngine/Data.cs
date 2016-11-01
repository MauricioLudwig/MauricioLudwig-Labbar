using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration6.Environments.Models;
using V3_Laboration6.Characters;
using V3_Laboration6.Characters.Models;
using V3_Laboration6.Items;
using V3_Laboration6.Items.Models;

namespace V3_Laboration6.GameEngine
{
    public class Data
    {

        public static Room Inn { get; set; }
        public static Room ThroneRoom { get; set; }
        public static Outdoor Yard { get; set; }

        static Data()
        {
            #region Inn
            Inn = new Room
            {
                Location = "Bluestone Inn",
                EnvironmentDescription = "and find it mostly deserted. There is an inkeeper and an ominous looking fellow at one of the tables.",

                Characters = new List<ICharacter>()
                {
                    new Human()
                    {
                        Name = "Draxos",
                        Occupation = "Innkeper",
                        Appearance = "appears jovial enough. He is fat and carries a smile as broad as his mustache.",
                        Dialogue = "See that fellow over there? He used to be an assassin. I would talk to him."
                    },
                    new Human()
                    {
                        Name = "Dregor",
                        Occupation = "Mystery man",
                        Appearance = "has an unfriendly look about him. I better tread carefully around this one.",
                        Dialogue = "Yeah, I used to be an assassin but I haven't been one for many years. I do however remember to charge for my services." +
                        Environment.NewLine + Environment.NewLine + "Tell you what... bring me a proper dagger and I'll tell you how I would've done the deed" +
                        " and where I would've gone into hiding."
                    }
                },

                Items = new List<IItem>()
                {
                    new Item()
                    {
                        ItemName = "Table",
                        ItemInfo = "has splotches of wine on it. People like to drink in this city, not unlike the King.",
                        Retrievable = false
                    },
                    new Item()
                    {
                        ItemName = "Tankard",
                        ItemInfo = "contains wine.",
                        Retrievable = false
                    }
                }

            };
            #endregion

            #region Throne Room
            ThroneRoom = new Room
            {

                Location = "Throne Room",
                EnvironmentDescription = "and your gaze is immediately drawn to the pool of blood on the throne." +
                "The murderer must've stabbed the king. I better examine the corpse.",

                Characters = new List<ICharacter>()
                {
                    new Human()
                    {
                        Name = "Janos",
                        Occupation = "King's brother",
                        Appearance = "is a merchant of wine and a close friend of mine. I trust he can give me some clues.",
                        Dialogue = "This is horrible " + Player.Name + ". You must find the murderer at once." +
                        Environment.NewLine + Environment.NewLine + "There is a retired assassin at the Bluestone Inn, I bet he did it!"
                    },
                    new Human()
                    {
                        Name = "Darien",
                        Occupation = "Prince",
                        Appearance = "looks distraught. He is a better man than his father. Duty compells me to find the murderer.",
                        Dialogue = "Sorry " + Player.Name + " but I have nothing else to add. I'm in grief and pain still."                        
                    },
                },

                Items = new List<IItem>
                {
                    new Item()
                    {
                        ItemName = "Throne",
                        ItemInfo = "is covered with blood. I've warred extensively throughout my years and there's definitely something odd about that blood.",
                        Retrievable = false
                    },
                    new Item()
                    {
                        ItemName = "King's Body",
                        ItemInfo = "does not paint a pretty picture.",
                        Retrievable = false
                    }
                }

            };
            #endregion

            #region Yard
            Yard = new Outdoor()
            {

                Location = "Yard",
                EnvironmentDescription = "and find a drunk guard at his post and a stable boy close by eyeing you suspiciously.",

                Characters = new List<ICharacter>()
                {
                    new Human()
                    {
                        Name = "Timmy",
                        Occupation = "Stable Boy",
                        Appearance = "doesn't make for a very large figure. He is not the murderer. I must be missing something...",
                        Dialogue = "Yes, I've heard what happended to the king. I have been in the throne room. I do not believe however that he was stabbed."
                        + Environment.NewLine + Environment.NewLine + "I've worked with horses all my life and that blood on the throne was definitely a horse's blood."
                    },
                    new Human()
                    {
                        Name = "Axl",
                        Occupation = "Militia Guard",
                        Appearance = "has stains all over his armor. He has clearly been drinking.",
                        Dialogue = "Sorry sir, I won't be drinking no more while on duty. I swear." +
                        Environment.NewLine + Environment.NewLine + "Something I knew about the king? Only that he loved to drink an awful lot."
                    }
                },

                Items = new List<IItem>()
                {
                    new Item()
                    {
                        ItemName = "Barrel",
                        ItemInfo = "contains wine. So much wine everywhere. There's something hidden in all of this...",
                        Retrievable = false
                    },
                    new Item()
                    {
                        ItemName = "Dagger",
                        ItemInfo = "is shiny and pretty to look at. I better pick it up.",
                        Retrievable = true
                    }       
                }
            
            };
            #endregion
        }

        public static IEnvironment SetEnvironment(int environment)
        {

            switch (environment)
            {
                case 1:
                    return Inn;
                case 2:
                    return ThroneRoom;
                case 3:
                    return Yard;
            }

            return null;
        }
    }
}
