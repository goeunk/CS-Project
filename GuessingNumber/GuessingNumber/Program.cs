using System;

namespace GuessingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            string input;
            int convertedInput;
            bool win = false;

            do
            {
                Console.WriteLine("Please guess an integer number between 1 and 99.");
                input = Console.ReadLine();
                bool isParsable = Int32.TryParse(input, out convertedInput);

                if(convertedInput > 99)
                {
                    Console.WriteLine("The number you entered is out of range.");
                }
                else
                {
                    if (convertedInput > number)
                    {
                        Console.WriteLine("Too high. Guess low.");
                    }
                    else if (convertedInput < number)
                    {
                        Console.WriteLine("Too low. Guess high.");
                    }
                    else
                    {
                        Console.WriteLine("You Win!");
                        win = true;
                    }
                }
                
            } while (win == false);
  
        }
    }
}
