using System;



/*
 This is a console application.
 All console apps must contain:

    - One or more namespaces
    - One or more classes
    - Exactly one Main method

- Notice the "using" statements at the top left of Program.cs
- These statements import namespaces which contain code you can use
- For example, the Console class used in Console.WriteLine() is contained in the "System" namespace

- Notice the namespace in your program
- These are named gropus that contain classes
- All classes must be in a namespace

- Notice the class in your program
- These are named groups that contain code
- All code must be in a class

- Notice the main method in your program
- The main method is called the entry point of your program
- This is where the program starts when you run it

The .NET Framework
- A programming infrastructure created by Microsoft, consisting of many parts
    - Most are beyond the scope of this presentation

- The parts we're interested in are:
    - Framework Class Library
    - Common Language Runtime
    - LINQ

Framework Class Library (FCL)
- Collection of Reusable classes, interfaces, and types
    - You don't have to reinvent the wheel!

- Including, but not limited to:
    - Console and file I/O, math, collections, diagnostics, dates and times, localization
      (language and currency), security, regular expressions, threading, networking, etc.

Comments
- Comments are lines that are ignored by the compiler
- They are meant to help humans understand code without having to dig in
- Three ways to comment:
    - Single line
    - Multi-line
    - XML Documentation

Single Line Comments
- To comment a single line, use two forward-slashes("//")
    - Note that Visual Studio shows comments in green

Multi-Line Comments
- To create a multi-line comment block, use / * and * /
    - Useful for long explanations, file/code snippets, etc.

- Note that Visual Studio inserts a "*" on each line for formatting, but this is not required

XML Documentation Comments
- Special comments tat go before classes, interfaces, and functions
- These comments have two additional purposes
    - They build an xml file of comments when you compile with the /doc option
    - They show information to the user through Intellisense

Statements
- The actions that a program takes are expressed in statements
- Common statements include:
    - Declaring variables
    - Assigning values
    - Calling methods/functions
    - Looping through collections
    - Branching to a block of code, based on a condition
- Statements can be single or blocks
- Single line statements must end in a semicolon ;
- Statement blocks are usually enclosed in curly brackets {} and can contain nested statements
- C# statements are case-sensitive



 */

/// <summary>
/// Prints Hello World to the console and waits for a key press from the user
/// </summary>



namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // write hello to the console
            Console.WriteLine("Hello World!");

            Console.ReadKey(); // wait for the user to press a key
        }
    }
}
