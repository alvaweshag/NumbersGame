using System;

namespace NumbersGame
{           //Alva Westrin Haglund .NET22
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");
            // generate a random number between 1-20  
            Random rnd = new Random();
            int num = rnd.Next(1,20);

            // User inputs a number
            int amountOfTries = 0;
            int allowedTries = 5;

            while (true)
            {
            // calling on method with users input and increasing amountOfTries with 1 for each time it gets called
                int guess = GetGuess();
                amountOfTries++;

                if (guess == num)
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    break;
                }
                if (guess > num)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                if (guess < num)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                if (amountOfTries == allowedTries)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök! Talet var: " + num);
                    break;
                }
            }
        }
        // A method of users input
        private static int GetGuess()
        {
            var guess = 0;
            try
            {
                guess = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Du skrev inte ett giltigt nummer.");
                guess = GetGuess();
            }
            return guess;
        }
    }
}
