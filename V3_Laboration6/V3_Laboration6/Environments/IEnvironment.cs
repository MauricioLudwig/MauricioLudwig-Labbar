using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V3_Laboration6.Characters;
using V3_Laboration6.Items;

namespace V3_Laboration6
{
    public interface IEnvironment
    {
        List<ICharacter> Characters { get; set; }
        List<IItem> Items { get; set; }
        string Location { get; set; }
        string EnvironmentDescription { get; set; }

        string ObserveEnvironment();
    }
}