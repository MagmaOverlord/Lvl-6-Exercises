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

        /*public void greeting() {
            Console.WriteLine(name+"!");
        }*/
        public void greeting(int hp) {
            Console.WriteLine("Hp: "+hp);
        }

        //can be overridden by its inheritor class
        public virtual void greeting() {
            Console.WriteLine(name+"!");
            Console.WriteLine("Hp: "+hp);
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
        //overriding the old method
        public override void greeting() {
            Console.WriteLine(pokeType);
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
            squirtle.greeting(squirtle.hp);
            Console.WriteLine("Weaknesses: "+squirtle.weakness1+" and "+squirtle.weakness2);
        }

    }
}
