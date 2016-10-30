using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V3_Laboration6
{
    public class Player
    {

        public enum Houses
        {
            Lannister = 1,
            Stark,
            Targaryen,
            GreyJoy
        }

        public Houses House { get; set; }
        public string Name { get; set; }
    }
}