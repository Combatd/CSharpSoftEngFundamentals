﻿using System;

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
            
        }
    }
}
