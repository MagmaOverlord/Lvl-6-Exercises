using System;

namespace Classes_Practice
{
    class Pokemon
    {
        public string name;
        public string pokeType;
        public string weaknesses;
        public string resistance;
        public int hp;

        public void greeting() {
            Console.WriteLine(name+"!");
        }

    }

    class Water: Pokemon {
        public string weakness1;
        public string weakness2;

        public Water () {
            pokeType = "water";
            weakness1 = "grass";
            weakness2 = "electric";
        }
    }

    class Pokedex {
        static void Main(string[] args)
        {
            Water squirtle = new Water();
            squirtle.name = "Squirtle";
            squirtle.hp = 20;

            Console.WriteLine("Name: "+squirtle.name);
            Console.WriteLine("Type: "+squirtle.pokeType);
            Console.Write("Greeting: ");
            squirtle.greeting();
            Console.WriteLine("Weaknesses: "+squirtle.weakness1+" and "+squirtle.weakness2);
        }

    }
}
