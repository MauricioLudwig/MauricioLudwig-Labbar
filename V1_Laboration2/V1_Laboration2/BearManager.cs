using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class BearManager
    {

        public List<Bear> Bears { get; set; }

        public BearManager()
        {

            Bears = new List<Bear>
            {
                new Bear
                {
                    Age = 12,
                    BiteForce = 1160,
                    Color = "Brown",
                    Diet = "Fish",
                    NumberOfTeeth = 42,
                    Species = "Grizzly Bear",
                    Weight = 350
                }
            };
        }

        public void AddBear()
        {
            Bear newBear = new Bear();

            Console.WriteLine();
            TextColors.Yellow("Age: ");
            newBear.Age = int.Parse(Console.ReadLine());
            TextColors.Yellow("Biteforce (BFQ): ");
            newBear.BiteForce = double.Parse(Console.ReadLine());
            TextColors.Yellow("Color: ");
            newBear.Color = Console.ReadLine();
            TextColors.Yellow("Diet: ");
            newBear.Diet = Console.ReadLine();
            TextColors.Yellow("Number of teeth: ");
            newBear.NumberOfTeeth = int.Parse(Console.ReadLine());
            TextColors.Yellow("Species: ");
            newBear.Species = Console.ReadLine();
            TextColors.Yellow("Weight (kg): ");
            newBear.Weight = double.Parse(Console.ReadLine());

            Bears.Add(newBear);
        }

        public void RemoveBear()
        {
            int index = 1;
            int choice;

            foreach (var bear in Bears)
            {
                Console.WriteLine("{0}. {1}", index++, bear.Species);
            }

            Console.Write(Environment.NewLine + "Choice: ");
            choice = int.Parse(Console.ReadLine());
            Bears.RemoveAt(--choice);
        }

        public void ShowBears()
        {
            foreach (var bear in Bears)
            {
                TextColors.Cyan(bear.ShortDescription() + Environment.NewLine + Environment.NewLine + bear.Habitat());
                Console.WriteLine(Environment.NewLine + Environment.NewLine + "\t----------" + Environment.NewLine);
            }
        }

    }
}
