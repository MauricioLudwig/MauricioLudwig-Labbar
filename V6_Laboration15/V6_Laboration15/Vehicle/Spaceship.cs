using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V6_Laboration15
{
    public class Spaceship : IVehicle
    {
        public void Lock()
        {
            Console.WriteLine("Lock.");
        }

        public void Start()
        {
            Console.WriteLine("Start.");
        }

        public void Stop()
        {
            Console.WriteLine("Stop.");
        }

        public void Unlock()
        {
            Console.WriteLine("Unlock.");
        }
    }
}