using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration6.Characters.Models
{
    class Human : ICharacter
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Appearance { get; set; }
        public string Dialogue { get; set; }

        public string PrintAppearance()
        {
            return String.Format("The {0} {1}", Occupation, Appearance);
        }

        public string Conversation()
        {
            return String.Format("My name is {0} and I'm the {1}. {2}",
                Name, Occupation, Dialogue);
        }
    }
}
