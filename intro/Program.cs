using System;

namespace intro
{
    
    class Question {
        private string text = "";
        private string[] answers;
        private int correct = 0;

        public Question(string text, string[] answers, int correct) {
            this.text = text;
            this.answers = answers;
            this.correct = correct;
        }

        public string getText() {
            return text;
        }

        public string[] getAnswers() {
            return answers;
        }

        public int getCorrect() {
            return correct;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i=1;i<=100;i++) {
                if (i % 15 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) {
                        Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }*/

            string[] answers = {"The Legend of Mario", "Samus", "Kirby", "Zelda"};
            Question q1 = new Question("Which game is Link from?", answers, 3);

            Console.WriteLine(q1.getText());
            string[] q1answers = q1.getAnswers();
            int q1correct = q1.getCorrect();

            for (int i = 0;i<q1answers.Length;i++) {
                Console.WriteLine("{0}: {1}", i, q1answers[i]);
            }
            Console.WriteLine("Which is the correct answer?");
            //int playerAns = Convert.ToInt32(Console.ReadLine());

            char choice = Console.ReadLine()[0];
            if (choice >= '0' && choice <= '5') {
                int numChoice = (int)Char.GetNumericValue(choice);
                Console.WriteLine(numChoice);
                if (numChoice == q1correct) {
                    Console.WriteLine("CORRECT!");
                }
                else {
                    Console.WriteLine("WRONG");
                }
            }
            else {
                Console.WriteLine("Not a valid answer!");
            }
        }
    }
}
