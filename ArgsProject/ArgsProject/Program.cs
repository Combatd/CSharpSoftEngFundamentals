using System;

namespace ArgsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string direction = args[0];
            string boolStr = args[1];
            string intStr = args[2];

            if(args.Length < 1 || args[0] == "/?" || args[1] == "/?" || args[2] == "/?")
            {
                Console.WriteLine("Needs at least two arguments, a direction and a true/false");
                Console.WriteLine("Ex: Up ");
            } else if (args[0] == "" || args[1] == "")
            {
                Console.WriteLine("Error: first or second argument is missing");
            } else
            {

                try
                {
                    string theDirection = direction;
                    bool theBool = bool.Parse(args[1]);
                    int theInt = int.Parse(args[2]);

                    Console.WriteLine(theDirection);
                    Console.WriteLine(theBool);
                    Console.WriteLine(theInt);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }

            }


        }



        //public void travelThing(string direction, bool going, int number)
        //{
        //    Console.WriteLine("Enter a direction, true or false, and then a number if desired");

        //    if (direction != "UP" && direction != "DOWN" && direction != "LEFT" && direction != "RIGHT")
        //    {
        //        Console.WriteLine("Needs at least two arguments, a direction and a true/false");
        //        Console.WriteLine("Ex: Up ");
        //    }
        //}
    }

    enum Direction
    {
            up,
            down,
            left,
            right,
    }
}
