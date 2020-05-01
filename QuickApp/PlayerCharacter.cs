using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickApp
{
    public class PlayerCharacter
    {
        public string Name { get; private set; }

        public bool IsNoob { get; set; }

        public string NickName { get; set; }

        public int Health { get; set; }

        public List<string> Weapons { get; set; }

        public PlayerCharacter()
        {
            Name = GenerateName();

            IsNoob = true;

            CreateStartingWeapons();
        }

        public void CreateStartingWeapons()
        {
            Weapons = new List<string>()
            {
                "Lil-J",
                "Bob",
                "Foo"
            }; 
        }

        public string GenerateName()
        {
            var names = new[]
            {
                "Diari",
                "Moussa",
                "Aboubacr",
                "Fatima", 
                "Khadidia"
            };

            return names[new Random().Next(0, names.Length)];
        }
    }
}
