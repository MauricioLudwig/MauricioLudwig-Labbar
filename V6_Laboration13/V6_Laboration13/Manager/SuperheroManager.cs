using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration13.Models;

namespace V6_Laboration13.Manager
{

    class SuperheroManager
    {
        public List<Superhero> Superheroes { get; set; }
        public event ErrorMsg InvalidInput;

        public SuperheroManager()
        {
            Superheroes = new List<Superhero>()
            {
                new Superhero { Name = "Star Master",   Sidekicks = 2, Ability = Superhero.Abilities.Flight       },
                new Superhero { Name = "Black Hood",    Sidekicks = 3, Ability = Superhero.Abilities.Invisibility },
                new Superhero { Name = "Light Bringer", Sidekicks = 1, Ability = Superhero.Abilities.Strength     }
            };
        }

        public void PrintSuperheroes()
        {
            Console.WriteLine(Superhero.SuperheroParameters() + Environment.NewLine);

            foreach (var superhero in Superheroes)
            {
                Console.WriteLine(superhero.SuperheroDescription());
            }
        }

        public void AddSuperhero()
        {

            Superhero newHero = new Superhero();

            Console.Write(Environment.NewLine + "Name: ");
            string name = Console.ReadLine();

            if (!(name.Length < 2 || name.Length > 10))
                newHero.Name = name;
            else
            {
                OnInvalidInput("Name must be between 3 and 10 characters.");
                Console.WriteLine("Operation was canceled. Enter to return.");
                Console.ReadKey();
                return;
            }

            Console.Write("Number of sidekicks: ");
            int number = int.Parse(Console.ReadLine());

            if (!(number < 0))
                newHero.Sidekicks = number;
            else
            {
                OnInvalidInput("Number must be greater or equal to 0.");
                Console.WriteLine("Operation was canceled. Enter to return.");
                Console.ReadKey();
                return;
            }

            newHero.Ability = GetAbility();

            Superheroes.Add(newHero);

            Console.WriteLine(Environment.NewLine + "New hero {0} created.", newHero.Name);
            Console.ReadKey();
        }

        private Superhero.Abilities GetAbility()
        {

            Console.WriteLine(Environment.NewLine + "Abilities" + Environment.NewLine);

            foreach (var ability in Enum.GetValues(typeof(Superhero.Abilities)))
            {
                Console.WriteLine("{0} - {1}", (int)ability, ability);
            }

            Console.Write(Environment.NewLine + "Choice: ");
            int input = int.Parse(Console.ReadLine());

            return (Superhero.Abilities)input;
        }

        public void FilterBy(Filter filter)
        {
            if (filter != null)
            {
                foreach (var superhero in Superheroes)
                {
                    if (filter(superhero))
                        Console.WriteLine(superhero.SuperheroDescription());
                }
            }
            else
                Console.WriteLine("Nothing found.");
        }

        protected virtual void OnInvalidInput(string message)
        {
            InvalidInput?.Invoke(message);
        }
    }
}
