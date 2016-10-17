using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class SharkManager
    {

        public List<Shark> Sharks { get; set; }

        public SharkManager()
        {

            Sharks = new List<Shark>()
            {

                new Shark()
                {
                    Age = 20,
                    Carnivorous = true,
                    Length = 6.7,
                    OceanDepth = 1200,
                    ScientificName = "Carcharodon Carcharias",
                    Species = "Great White",
                    Weight = 1000
                }
            };
        }

        public void AddShark()
        {
            Shark newShark = new Shark();

            Console.WriteLine();
            TextColors.Yellow("Age: ");
            newShark.Age = int.Parse(Console.ReadLine());
            TextColors.Yellow("Is this shark carnivorous (y/n): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
                newShark.Carnivorous = true;
            else
                newShark.Carnivorous = false;
            TextColors.Yellow("Length (m): ");
            newShark.Length = double.Parse(Console.ReadLine());
            TextColors.Yellow("Ocean depth (m): ");
            newShark.OceanDepth = double.Parse(Console.ReadLine());
            TextColors.Yellow("Scientific name: ");
            newShark.ScientificName = Console.ReadLine();
            TextColors.Yellow("Species: ");
            newShark.Species = Console.ReadLine();
            TextColors.Yellow("Weight (kg): ");
            newShark.Weight = double.Parse(Console.ReadLine());

            Sharks.Add(newShark);
        }

        public void RemoveShark()
        {
            int index = 1;
            int choice;

            foreach (var shark in Sharks)
            {
                Console.WriteLine("{0}. {1}", index++, shark.Species);
            }

            Console.Write(Environment.NewLine + "Choice: ");
            choice = int.Parse(Console.ReadLine());
            Sharks.RemoveAt(--choice);
        }

        public void ShowSharks()
        {
            foreach (var shark in Sharks)
            {
                TextColors.Blue(shark.ShortDescription() + Environment.NewLine + Environment.NewLine + shark.Habitat());
                Console.WriteLine(Environment.NewLine + Environment.NewLine + "\t----------" + Environment.NewLine);
            }
        }
    }
}
