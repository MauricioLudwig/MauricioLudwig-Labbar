using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration5.DataStores.Repositories
{
    interface IMediaProperties
    {
        string UniqueID { get; set; }
        string Creator { get; set; }
        string Title { get; set; }
        string PrintAttributes();
    }
}
