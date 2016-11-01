using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration6.Esthetics
{
    class TextColor
    {

        public static void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(Environment.NewLine + text + Environment.NewLine + Environment.NewLine);
            Console.ResetColor();
        }

        public static void SubHeader(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(text + Environment.NewLine + Environment.NewLine);
            Console.ResetColor();
        }

        public static void LineBreak()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        public static void Red(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void Green(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void Yellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}