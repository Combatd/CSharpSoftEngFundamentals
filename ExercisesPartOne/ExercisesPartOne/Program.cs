using System;

namespace ExercisesPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Comments
            // Single Line Comment
            /* 
             Multi Line Comment
             */
            // **********
            /// <summary>
            ///
            /// </summary>
            ///
            /// <example>
            /// XML Comment
            /// </example>
            // **********

            // Variables
            bool exerciseBool = true;
            double exerciseDouble = 1.25;
            char exerciseChar = 'A';
            string exerciseString = "Gawr Gura";

            Console.WriteLine($"{exerciseBool} {exerciseDouble} {exerciseChar} {exerciseString}");

            // Min / Max values

            int maxInt = int.MaxValue;
            Console.WriteLine(maxInt);
            maxInt++; // increment maxValue by 1
            Console.WriteLine(maxInt); // goes back to lowest number minimum int

            // Implicit Types
            var newBool = false;
            var newInt = 12;
            var newChar = 'C';
            var newString = "This should resolve to a string type";
            Console.WriteLine(newChar + newInt + newString);
            Console.WriteLine(newBool);

            // Operators
            //int x = 1;
            //Console.WriteLine(x);
            //int y = 2;
            //Console.WriteLine(y);
            //int z1 = x++;
            //Console.WriteLine(z1);
            //int z2 = ++y;
            //Console.WriteLine(z2);

            // Math
            int x = 1;
            int y = 2;
            int z = 3;

            int a = x + y;
            int b = y - x;
            int c = z / x + y;

            int notEven = 3 % 2;
            bool isExpressionEven = notEven == 0;

            double threeDecimalDouble = Math.Round(10.23456 / 10, 3);

            Console.WriteLine(isExpressionEven);
            Console.WriteLine(threeDecimalDouble);
        }
    }
}
