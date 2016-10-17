using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class SpiderManager
    {

        public List<Spider> Spiders { get; set; }

        public SpiderManager()
        {
            Spiders = new List<Spider>()
            {
                new Spider()
                {
                    Age = 2,
                    BitPeterParker = false,
                    Color = "Green",
                    NumberOfEyes = 8,
                    NumberOfLegs = 8,
                    Species = "Goliath Birdeater",
                    Weight = 0.3
                }
            };
        }

        public void AddSpider()
        {
            Spider newSpider = new Spider();

            Console.WriteLine();
            TextColors.Yellow("Age: ");
            newSpider.Age = int.Parse(Console.ReadLine());
            TextColors.Yellow("Did this particular spider bite Peter Parker (y/n): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
                newSpider.BitPeterParker = true;
            else
                newSpider.BitPeterParker = false;
            TextColors.Yellow("Color: ");
            newSpider.Color = Console.ReadLine();
            TextColors.Yellow("Number of eyes: ");
            newSpider.NumberOfEyes = int.Parse(Console.ReadLine());
            TextColors.Yellow("Number of legs: ");
            newSpider.NumberOfLegs = int.Parse(Console.ReadLine());
            TextColors.Yellow("Species: ");
            newSpider.Species = Console.ReadLine();
            TextColors.Yellow("Weight (kg): ");
            newSpider.Weight = double.Parse(Console.ReadLine());

            Spiders.Add(newSpider);
        }

        public void RemoveSpider()
        {
            int index = 1;
            int choice;

            foreach (var spider in Spiders)
            {
                Console.WriteLine("{0}. {1}", index++, spider.Species);
            }

            Console.Write(Environment.NewLine + "Choice: ");
            choice = int.Parse(Console.ReadLine());
            Spiders.RemoveAt(--choice);
        }

        public void ShowSpiders()
        {
            foreach (var spider in Spiders)
            {
                TextColors.Yellow(spider.ShortDescription() + Environment.NewLine + Environment.NewLine + spider.Habitat());
                Console.WriteLine(Environment.NewLine + Environment.NewLine + "\t----------" + Environment.NewLine);
            }
        }

    }
}
