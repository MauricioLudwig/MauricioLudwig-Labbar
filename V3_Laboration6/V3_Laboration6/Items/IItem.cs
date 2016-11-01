using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration6.Items
{
    public interface IItem
    {
        string ItemName { get; set; }
        bool Retrievable { get; set; }
        string ItemInfo { get; set; }
        string Description();
        string Retrieve();
    }
}