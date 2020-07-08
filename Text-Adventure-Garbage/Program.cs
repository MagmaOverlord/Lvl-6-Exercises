using System;

namespace Text_Adventure_Garbage
{
    class Program
    {

        //Include an switch, array, method, loop, and conditional in this thing
        //already done: switch, method

        static void Main(string[] args)
        {
            gameTitle();
        }
        public static string choice;
        public static void gameTitle() {
            Console.WriteLine("Welcome to the, 'I had to do this for class when we were supposed to do Unity' Text Adventure!");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first() {
            Console.WriteLine("You wake up. You're super happy because you're going to finally be learning Unity today!");
            Console.WriteLine("You've been waiting for this for several months, since your teacher mentioned it at the end of a class.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Stay in bed and watch Youtube");
            Console.WriteLine("2. Get up and eat breakfast");
            
            choice = Console.ReadLine();
            Console.Clear();

            switch(choice) {
                case "1":
                    Console.WriteLine("You waste an hour in bed watching something completely random.");
                    break;
                case "2": 
                    Console.WriteLine("You go downstairs and eat some food. It tastes pretty good.");
                    break;
                default: 
                    Console.WriteLine("That's not the right way to choose...");
                    break;
            }
        }
    }
}
