using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration6.Characters;
using V3_Laboration6.Characters.Models;
using V3_Laboration6.Items;

namespace V3_Laboration6.Environments.Models
{
    public class Outdoor : IEnvironment
    {
        public List<ICharacter> Characters { get; set; }
        public List<IItem> Items { get; set; }
        public string Location { get; set; }
        public string EnvironmentDescription { get; set; }

        public string ObserveEnvironment()
        {
            return String.Format("You observe the {0} {1}",
                Location, EnvironmentDescription);
        }
    }
}