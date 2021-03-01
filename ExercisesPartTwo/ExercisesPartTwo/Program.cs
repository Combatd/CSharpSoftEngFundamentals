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
        }

        public enum Mood
        {
            Happy,
            Melancholic,
            Content,
            Enraged
        }
    }
}
