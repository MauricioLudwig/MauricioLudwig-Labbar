using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V5_Laboration8
{
    interface IProduct
    {
        int ID { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
