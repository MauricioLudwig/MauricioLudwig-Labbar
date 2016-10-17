using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class AnimalManager
    {

        public List<Spider> Spiders { get; set; }
        public List<Bear> Bears { get; set; }
        public List<Shark> Sharks { get; set; }

        public AnimalManager()
        {
            // Creating an instance from each of the animal groups when you run the application
            #region First Instances
            Spiders = new List<Spider>
            {
                new Spider
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

            Sharks = new List<Shark>
            {
                new Shark
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
        #endregion

        public void AddAnimal()
        {

        }

        public void RemoveAnimal()
        {

        }

        public void ShowAnimal()
        {

        }

        public void ShowAll()
        {

        }

    }
}
