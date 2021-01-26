using System;

namespace SelectionStatements1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess the digits!");
            Console.WriteLine("See if you can guess the correct digits!");
            Console.WriteLine("Whats the biggest number I should use?");

             var upperLimit = int.Parse(Console.ReadLine());
            //    var upperLimit = int.Parse(Console.ReadLine());    could also be  "var upperLimit = Console.ReadLine();
            
            var random = new Random();
            var number = random.Next(1, upperLimit);
           
            int guess;
            do
            {
                //var number = (777);
                Console.WriteLine("What is your guess?");

                //Console.WriteLine("Guess a number between 1 and a 1,000!!!");

                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                { Console.WriteLine("Sorry Your guess is to high..."); }

                else if (guess < number)
                { Console.WriteLine("Sorry Your guess is to low..."); }

                else
                { Console.WriteLine("CONGRATULATIONS that is exactly right!!!"); }


            } while (guess != number);

           


        }
    }
}
