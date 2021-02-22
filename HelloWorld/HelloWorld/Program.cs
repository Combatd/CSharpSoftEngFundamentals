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

Variables
- Variables are named identifiers that can be assigned a value
    - All variable names should be camelCase, with some exceptions
- Must be declared before they are used
    - You can declare multiple variables of the same type on the same line


- Storing a value in a variable is called assignment or initialization
    - The value on the right of the equals is stored in the variable on the left
    - You can declare and initialize a variable on the same line

Constants
- Variables can usually be updated any time after they are created
- Constnats are variables whose values can never be changed
    - The value is set at compile time
    - They must be initialized when they are declared

Types
- All variables must have a type
- The type determines many things, including, but not limited to
    - What kind of data that varaible can store
    - What operations can be performed on that data
- The .NET FCL defines many built-in types you can use

Commonly Used Built-In Types
- bool - represents true or false
- int - represents a 32-bit signed integer (-5, 2, 6)
- double / float - represents floating point numbers (-4.5, 1.9, 19.3948)
- char - represents a single character ('h')
- string - represents a collection of charactes ("hello")

Default Values
- All types have a default value
- Variables are set to the default value when they are declared
    - The default value for bool is false
    - The default value for int is 0
    - The default value for double / float is 0.
    - The default value for char is the null character ('\0')
    - The default value for string is null

Min/Max Values
- All numeric types have a min and max value
    - You will get an error if you go beyond these values
- To access those values, use the MinValue and MaxValue properties


Strongly/Strictly Typed
- C# is a strongly-typed/strictly-typed language
- All variabes must have a type
- Variables cannot change types after they are declared
- Variables can only contain values that match their type


Implicit Types
- You can let the compiler determine variable type by using the var keyword
    - Compiler determines type by evaluating the value on the right side of the equals sign
    - This only works if the variable is being initialized

Expressions
- Sequence of operands and operators that evaluate to a single value, object, or method
- The final value of an expression depends on the types and operations use

Operators
- Operators are "actions" that can be applied to one or more operands (which are usually expressions)
    - Operators that take one, two, or three operands are called unary, binary, and ternary operators, respectively
- Operators can behave differently based on the types of the operands

Common Unary Operators
- Increment ++
    - Pre-increment ++x - Returns the value of x after incrementing it by 1
    - Post-increment x++ - Returns the value of x before incrementing it by 1
- Decrement --
    - Pre-decrement --x - Returns the value of x after decrementing it by 1
    - Post-decrement x-- Returns the value of x before decrementing it by 1

Common Binary Operators - Assignment
- Assignment = - Evaluates the expression on the right side and stores it in the variable on the left
    - Both sides can reference the same variable, the right side is always evaluated first
- There are many math + assignment operators, which are just shortcuts
    - x += y - same as x = x + y
    - x -= y - same as x = x - y
    - x *= y - same as x = x * y
    - x /= y - same as x = x/y

Common Binary Operators - Math
- Math operators (+ - * /) all behave like you expect them to with numbers
    - Dividing two ints always returns an int, not a decimal!
    - The + operator performs concatenation with strings.
- Modulus % - Returns the remainder of a division operation
    - For example, 10 & 3 will return 1, since 10/3 is 3 with remainder 1

Common Unary Operators
- Member access (.) - Accesses members on the object stored in the variable
- Logical negation (!) - Negates the operand
    - Only workso n expressions that evaluate to a boolean

Conditional Operator
- The conditional operator is the only ternary operator in C#
condition ? first_expression : second_expression;

- If condition evaluates to true, returns the evaluation of first_expression
- If condition evaluates to false, returns the evaluation of second_expression
Example: string s = condition ? "condition is true" : "condition is false";


Type Conversion
- You often need to copy the value of one variable into another
- What if the variables have different types?

- You need to change the type of th source to store it in the target
- This is called a type conversion

- There are two main types of conversions in C#
    - Implicit conversions
    - Explicit conversions (also called casts)

Implicit Conversions
- No special syntax is required because the conversion is is type safe
- The compiler handles this for you, no data wil be lost

Explicit Conversions
- Require a cast operator, because information might be lost
- cast from double to int doesn't work because a double is larger than an int
    - Also, all the decimal places will be lost

- To store a double in an int, you have to cast the double to the int type
- By doing this, you've told the compiler "I'm aware, just do it anyway"
- After this statement, y will contain 1, the int part of the double
    - Note that no rounding occurs, it just takes the int part

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

            // multiple variables on same line
            // int x, y, z;
            int a = 5, b = 10, c = 20;

            // constant
            const double pI = 3.14159;

            // min and max values
            int minInt = int.MinValue; // -2147483648
            int maxInt = int.MaxValue; // 2147483647

            double minDouble = double.MinValue; // -1.7976931...
            double maxDouble = double.MaxValue; // 1.7976931...

            // y will be an int since 100 is an int
            //int x = 100;
            //var y = 100;

            // expressions
            //int x = 1; // literal
            //int y = 2 + 5; // resolves to an int
            //string hi = "hello!"; // literal

            //int z = x + y; // resolves to an int

            //// operands
            //// assignment operator has integer variable y and expression 2+3 as operands
            //y = 2 + 3; // two binary operators, each with two operands



            // implicit conversion is type safe
            //int x = 1;
            //double y = x; // an int can be stored in a double

            //double x = 1.2345;
            //int y = x; // does not convert from double to int

            // no rounding, takes the int part in type cast
            //double x = 1.2345;
            //int y = (int)x; // 1

            //int x = 4;
            //int y = 5;
            //double z = 4 / 5; // equals 0.8, so it is 0 for int part
            //// z will be 0

            // cast either operand to a double
            int x = 4;
            int y = 5;

            //double z = (double) 4 / 5; // 0.8
            double z = 4 / (double) 5; // 0.8


        }
    }
}
