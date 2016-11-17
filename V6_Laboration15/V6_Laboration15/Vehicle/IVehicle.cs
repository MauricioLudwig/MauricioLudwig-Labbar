using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V6_Laboration15
{
    public interface IVehicle
    {
        void Start();
        void Stop();
        void Lock();
        void Unlock();
    }
}