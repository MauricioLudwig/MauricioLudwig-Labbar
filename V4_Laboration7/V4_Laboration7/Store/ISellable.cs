using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V4_Laboration7
{
    public interface ISellable
    {
        int Price { get; set; }
        string ProductInformation { get; set; }
        string ProductName { get; set; }
        bool IsNew { get; set; }
    }
}