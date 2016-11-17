using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration13.Models
{
    public class Superhero
    {
        public Abilities Ability { get; set; }
        public string Name { get; set; }
        public int Sidekicks { get; set; }

        public enum Abilities
        {
            Flight = 1,
            Agility,
            Invincibility,
            Invisibility,
            Strength
        }

        public static string SuperheroParameters()
        {
            return String.Format("{0,-25}{1,-25}{2,-25}", "Name", "Nr of Sidekicks", "Special Ability");
        }

        public string SuperheroDescription()
        {
            return String.Format("{0,-25}{1,-25}{2,-25}", Name, Sidekicks, Ability);
        }
    }
}
