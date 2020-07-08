using System;

namespace Classes_Practice
{
    class Pokemon
    {
        public string name;
        public string type;
        public string weaknesses;
        public string resistance;
        public int hp;

        public void greeting() {
            Console.WriteLine(name);
        }

    }

    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Git gud");
        }

    }
}
