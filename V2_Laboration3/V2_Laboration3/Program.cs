﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration3
{
    class Program
    {

        static void Main(string[] args)
        {

            Runtime runtime = new Runtime();
            runtime.Start();

            Console.Clear();
            Console.WriteLine(Environment.NewLine + "You have reached the end of the program.");
            Console.ReadKey();
        }
    }
}
