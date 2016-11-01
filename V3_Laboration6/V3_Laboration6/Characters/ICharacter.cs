using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration6.Characters
{
    public interface ICharacter
    {
        string Name { get; set; }
        string Occupation { get; set; }
        string Appearance { get; set; }
        string Dialogue { get; set; }
        string PrintAppearance();
        string Conversation();
    }
}