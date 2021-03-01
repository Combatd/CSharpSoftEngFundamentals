using System;

namespace ExercisesPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditionals

            // If/else
            int x = 1;
            if (x < 100)
            {
                Console.WriteLine(x + " is less than 100");
            } else if(x == 100)
            {
                Console.WriteLine($"{x} is 100!");
            } else {
                Console.WriteLine("The x is not a non-negative number 100 or less");
            }

        }
    }
}
