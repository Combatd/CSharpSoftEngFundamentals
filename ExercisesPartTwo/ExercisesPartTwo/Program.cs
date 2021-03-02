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

            // Switch

            var mood = Mood.Content;

            switch (mood)
            {
                case Mood.Happy:
                    Console.WriteLine("Happy time!");
                    break;
                case Mood.Melancholic:
                    Console.WriteLine("A Melancholic Day");
                    break;
                case Mood.Content:
                    Console.WriteLine("Generally an okay day");
                    break;
                case Mood.Enraged:
                    Console.WriteLine("Anger seethes from within...");
                    break;
                default:
                    Console.WriteLine("Default case: where is the mood?");
                    break;
                   
            }


            // Loops

            string s = "0123456789";
            int sIndex = 0;
            while (sIndex < s.Length)
            {
                int currentNumber = int.Parse(s[sIndex].ToString());
      
                if (currentNumber > 0 && currentNumber % 2 != 0)
                {
                  Console.WriteLine(currentNumber);
                }
                sIndex++;
            }






            // Reference Type Equality
            int[] testArr1 = { 1, 2, 3, 4 };
            int[] testArr2 = { 1, 2, 3, 4 };
            int[] testArr3 = { 0, 2, 3, 4 };

            Console.WriteLine(AreArraysEqual(testArr1, testArr2));
            Console.WriteLine(AreArraysEqual(testArr1, testArr3));

        }

        public enum Mood
        {
            Happy,
            Melancholic,
            Content,
            Enraged
        }

        static bool AreArraysEqual(int[] arr1, int[] arr2 )
        {
            if(arr1.Length != arr2.Length)
            {
                return false;
            }
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
