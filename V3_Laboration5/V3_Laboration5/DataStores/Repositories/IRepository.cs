using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration5
{
    interface IRepository
    {

        void AddMedia(object newObject);
        void RemoveMedia(object removeObject);
        int PrintList();
    }
}
