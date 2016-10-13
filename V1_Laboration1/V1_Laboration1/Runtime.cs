using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration1
{
    class Runtime
    {

        public void Start()
        {

            int menuChoice;
            bool continueLoop = true;

            List<Dog> dogs = new List<Dog>()
            {
                new Dog { Name = "Snoop", Age = 5, Breed = "Rottweiler" },
                new Dog { Name = "Max", Age = 10, Breed = "German Shepherd" },
                new Dog { Name = "Hasselhoff", Age = 50, Breed = "Golden Retriever" }
            };

            #region Simple Initiation
            //Dog dog1 = new Dog
            //{
            //    Name = "Snoop",
            //    Age = 5,
            //    Breed = "Rottweiler"
            //};

            //Dog dog2 = new Dog
            //{
            //    Name = "Max",
            //    Age = 10,
            //    Breed = "German Shepherd"
            //};

            //Dog dog3 = new Dog
            //{
            //    Name = "Hasselhoff",
            //    Age = 50,
            //    Breed = "Golden Retriever"
            //};
            #endregion

            #region Simple Print
            //Console.WriteLine("My dog {0} is {1} years old and is a {2}", dog1.Name, dog1.Age, dog1.Breed);
            //Console.WriteLine("My dog {0} is {1} years old and is a {2}", dog2.Name, dog2.Age, dog2.Breed);
            //Console.WriteLine("My dog {0} is {1} years old and is a {2}", dog3.Name, dog3.Age, dog3.Breed);
            #endregion

            do
            {

                Menus.Menu();
                menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    // Add
                    case 1:
                        Console.Clear();
                        string name, breed;
                        int age;
                        AddDog(out name, out age, out breed);
                        dogs.Add(new Dog { Name = name, Age = age, Breed = breed });
                        TextColor.Green("Succesfully added new dog!" + Environment.NewLine);
                        break;
                    // Remove
                    case 2:
                        int index = 1;
                        Console.Clear();
                        foreach (var dog in dogs)
                        {
                            Console.Write(index++);
                            Console.WriteLine(" " + dog.Name);
                        }
                        Console.Write(Environment.NewLine + "Select dog to remove: ");
                        int removeIndex = int.Parse(Console.ReadLine());
                        dogs.RemoveAt(--removeIndex);
                        TextColor.Green("Successfully removed dog!" + Environment.NewLine);
                        break;
                    // Show
                    case 3:
                        Console.Clear();
                        Console.WriteLine("{0,-15} {1,-15} {2}\n", "Name", "Age", "Breed");
                        foreach (var dog in dogs)
                        {
                            Console.WriteLine(dog.ShowInfo());
                        }
                        break;
                    // Exit
                    case 4:
                        Console.WriteLine(Environment.NewLine + "Goodbye!");
                        continueLoop = false;
                        break;
                    default:
                        Console.Clear();
                        TextColor.Red("Invalid input, try again." + Environment.NewLine);
                        break;
                }

            } while (continueLoop == true);

        }

        private static void AddDog(out string name, out int age, out string breed)
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Breed: ");
            breed = Console.ReadLine();
        }
    }
}
