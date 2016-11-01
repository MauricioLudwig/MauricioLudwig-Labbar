using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration6.Items.Models
{
    class Item : IItem
    {
        public string ItemName { get; set; }
        public bool Retrievable { get; set; }
        public string ItemInfo { get; set; }

        public string Description()
        {
            return String.Format("The {0} {1}.", ItemName, ItemInfo);
        }

        public string Retrieve()
        {
            return String.Format("You have picked up the {0}!", ItemName);
        }
    }
}
