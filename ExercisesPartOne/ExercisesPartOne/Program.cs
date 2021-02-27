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
            //bool exerciseBool = true;
            //double exerciseDouble = 1.25;
            //char exerciseChar = 'A';
            //string exerciseString = "Gawr Gura";

            //Console.WriteLine($"{exerciseBool} {exerciseDouble} {exerciseChar} {exerciseString}");

            //// Min / Max values

            ////int maxInt = int.MaxValue;
            ////Console.WriteLine(maxInt);
            ////maxInt++; // increment maxValue by 1
            ////Console.WriteLine(maxInt); // goes back to lowest number minimum int

            ////// Implicit Types
            ////var newBool = false;
            ////var newInt = 12;
            ////var newChar = 'C';
            ////var newString = "This should resolve to a string type";
            ////Console.WriteLine(newChar + newInt + newString);
            ////Console.WriteLine(newBool);

            ////// Operators
            //////int x = 1;
            //////Console.WriteLine(x);
            //////int y = 2;
            //////Console.WriteLine(y);
            //////int z1 = x++;
            //////Console.WriteLine(z1);
            //////int z2 = ++y;
            //////Console.WriteLine(z2);

            ////// Math
            ////int x = 1;
            ////int y = 2;
            ////int z = 3;

            ////int a = x + y;
            ////int b = y - x;
            ////int c = z / x + y;

            ////int notEven = 3 % 2;
            ////bool isExpressionEven = notEven == 0;

            ////double threeDecimalDouble = Math.Round(10.23456 / 10, 3);

            ////Console.WriteLine(isExpressionEven);
            ////Console.WriteLine(threeDecimalDouble);

            //// Type Conversions
            //int x = 1;
            //int y = 2;
            //int z = 3;

            //double a = 1.2;
            //double b = 2.2;
            //double c = 3.2;

            //int oldX = x;
            //int oldY = y;
            //int oldZ = z;

            //x = (int)a;
            //y = (int)b;
            //z = (int)c;

            //a = (double)oldX;
            //b = (double)oldY;
            //c = (double)oldZ;

            //Console.WriteLine(x); // becomes int
            //Console.WriteLine(a); // becomes double with no decimal

            //// Strings

            //string escapeSeqStr = "Hello..\\ \n ..World!";
            //Console.WriteLine(escapeSeqStr);
            //string literalStr = $"This is a string literal - {escapeSeqStr}";
            //Console.WriteLine(literalStr);
            //Console.WriteLine(escapeSeqStr + $"length is {escapeSeqStr.Length}");

            //// Index
            //string burger = "Burger!";
            //Console.WriteLine(burger[0].ToString() + burger[burger.Length / 2].ToString() + burger[burger.Length - 1].ToString()); // used ToString to get strings instead of index numbers

            //// Changing case
            //string capsTestStr = "Characters";
            //Console.WriteLine(capsTestStr);
            //Console.WriteLine(capsTestStr.ToLower());
            //Console.WriteLine(capsTestStr.ToUpper());

            //// Getting parts of strings
            //string partingStr = "Senzawa";
            //partingStr = partingStr.Remove(0, 1);
            //partingStr = partingStr.Remove(partingStr.Length - 1, 1);
            //Console.WriteLine(partingStr);

            // Searching
            string x = "Korone";
            char y = 'o';

            int foundChar = x.IndexOf(y);
            bool charInStr = x.Contains(y);

            string fakeFilePath = "c:\\fake\\bar.txt";
            char theDrive = fakeFilePath[fakeFilePath.IndexOf('c')];
            string[] splitFilePath = fakeFilePath.Split('.');
            string noExtension = splitFilePath[0];

            Console.WriteLine(noExtension);
            Console.WriteLine(theDrive);

            const string formatX = "Hello there {0}, I am a {1}";
            string yFormatter = string.Format(formatX, "Pekora", "Miko");
            Console.WriteLine(yFormatter);

            double dDouble = 3.145;
            Console.WriteLine(string.Format("The first format element has 2 decimals: {0:0.00}", dDouble));
        }
    }
}
