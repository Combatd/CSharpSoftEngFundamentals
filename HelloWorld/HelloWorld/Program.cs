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

Converting Numeric Types to Strings
- All types have a function called "ToString()"
    - This does different things depending on the type
- For numeric types, it does what you expect
    - In the example, xAsString is "4" and yAsString will be "3.14159"


Strings
- A string is an object that holds a sequence of characters
- The default value of a string is null
- Strings can be initialized by using a literal (surrounded by double quotes "")_
    - Or by anything that returns a string, such as a function

Escape Sequences
- Strings can contain escape sequences that do variuso things
- In C#, they all start with a backslash \
- The most common escape sequences are:
    - \n represents a new line
    - \\ represents a backslash character '\'

- To store a file path in a string, you have to escape all the backslashes
- To represent multiple lines in a string, use \n

String Literals
- A string literal starts with a @ symbol before the double quotes
= All characters are interpreted verbatim
    - Escape sequences are ignored
- Very useful for file path


String Operations
- The string class has many members that are useful
- We will briefly cover various common string operations
- Note that none of the operations change the existing strings
    - They return new ones!

String Concatenation
- Concatenation means combining one string with another
- You can use the + operator to concatenate strings together


Checking For Null or Empty
- If you try to perform operatios on a null string, you will get an error
- You can use string.IsNullOrEmpty() to check for the following values:
    - null, "", string.Empty
- You can also use isNullOrWhiteSpace() to check for the following values:
    - null, "", string.Empty, spaces, tabs, newlines

String Length
- All strings have a length (int), which represents the number of characters in it
- Can be accessed in the Length property

Indexing into Strings
- Recall that a string is a sequence of characters
- Each character is stored at an integer index, starting at zero
- You can use the index operator [] to get a character at a specific index
    - The expression inside the index operator must resolve to an integer
    - If the index is outside the string, you will get an error

Changing Case
- If you need a string in all uppercase, use ToUpper()
- If you need a string in all lowercase, use ToLower()

Getting a Substring
- There are two ways to ask for a substring
    - string.Substring(int startIndex)
    - string.Substring(int startIndex, int length)

Removing a Substring
- There are two ways to remove a substring
    - str.Remove(int startIndex)
    - str.Remove(int startIndex, int count

Replacing
- There are two ways to replace parts of a string
    - string.Replace(char oldChar, char newChar)
    - string.Replace(string oldValue, string newValue)

Searching Strings
- There are many ways to check if a string contains things:
    - IndexOf() / LastIndexOf()
    - Contains()
    - StartsWith() / EndsWith()

IndexOf() / LastOf()
- IndexOf() / LastIndexOf() will return the integer index of the first/last occurence of the specified value
    - It returns -1 if the specified value is not found
- Very useful when you have to know exactly where the match is

Contains()
- Contains() returns true if the string contains the specified value
- Very useful when you don't care where the match is

StartsWith()/EndsWith()
- StartsWith() / EndsWith() returns true if the string starts / ends with the specified string
- Note that you can't use single characters here, but you can use a single character string

Trimming whitespace
- You can trim leading/trailing/both whitespace from a string using TrimStart(), TrimEnd(), or Trim(), respectively
- Very useful when you have to sanitize user inputs

Splitting
- You can split a string into an array of strings by specifying the character to split on
    - Arrays are covered later, but it's good to know this function since it's used so often
    - Usually used to split a sentence into words by splitting on space
- The specified character is not included in the results

Formatted Strings
- There are many, many ways to format strings
- Use string.Format() to insert the values of one or more expressions into another string
- Has two parts:
    - The format string
    - The values that will be inserted
- The format string must contain tokens that look like {n} where n is the number of the token
- For each otken, there must be a corresponding value to insert
    - If there are more tokens than values, you will get an error
- String.Format will call ToString() on each value and insert that into the string

Converting Strings to Other Types
- Most types have a function called Parse()
    - You can also use TryParse), which is almost always better
- Takes in a string and returns an object of the specified typed
- If successful, the object is returned. If not, you get an error.

Enumerations
- An enum is a distinct type that consists of a set of named constants
    - Typically used to store a collection of related values
- Each constant is accessed by name, but also has a numeric value
    - The default value type is int. It starts at zero and increments by one.
- You can explicitly set values as well.
- To convert frmo enum to int, cast the enum to int
- To convert from enum to string, call ToString()
- To convert from string to enum, just use enum.Parse() on the string
    - You can also ignore case

Structs
- A struct a type that acts as a contianer for related variables
- To initialize a struct type variable, use the new keyword
    - This is called instantiation
- To access the struct members, use the Member Access Operator (.)
- A struct is just a blueprint, it does nothing on its own
- When you instantiate an struct, you are creating an object/instance of that type
    - The object is unique, and contains a unique copy of everything in the struct
- This is conceptually the same as creating two different integers
    - They share the same type but they contain different values

Console Input/Output
- Console applications interact with the user by using the System.Console class
- You can also read arguments passed in to the program
    - This is the string array called args in the Main method
    - This is covered when arrays are covered in another presentation

Writing to the Console
- To write to the console, use Console.Write() or Console.WriteLine()
    - Write() takes in a string and prints it
    - WriteLine() takes in a string and prints it, and adds a newline at the end

Reading from the Console
- To read from the console, use the following methods:
    - Console.Read() reads the next character and returnsthe int value of that character
    - Console.ReadKey()
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
            //Console.WriteLine("Hello World!");

            //Console.ReadKey(); // wait for the user to press a key

            //// multiple variables on same line
            //// int x, y, z;
            //int a = 5, b = 10, c = 20;

            //// constant
            //const double pI = 3.14159;

            //// min and max values
            //int minInt = int.MinValue; // -2147483648
            //int maxInt = int.MaxValue; // 2147483647

            //double minDouble = double.MinValue; // -1.7976931...
            //double maxDouble = double.MaxValue; // 1.7976931...

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
            //int x = 4;
            ////int y = 5;

            ////double z = (double) 4 / 5; // 0.8
            //double z = 4 / (double)5; // 0.8

            //// Convert numeric type to string
            //int x = 4;
            //double y = 3.14159;
            //string xAsString = x.ToString();
            //string yAsString = y.ToString();

            //// escape all the backslashes in filePath
            //string filePath = "c:\\myfolder\\myFile.txt";

            //// Represent multiple lines in a string
            //string multiLineString = "This is a string\nthat prints \non three lines";

            //// String Literal file path
            //filePath = @"c:\myFolder\myfile.txt";

            //// string concatenation
            //string s1 = "Hello";
            //string s2 = "World";
            //string s3 = "!";

            //string s4 = s1 + " " + s2 + " " + s3;

            //// changing case
            //string str = "Hello World!";
            //string upperStr = str.ToUpper();
            //string lowerStr = str.ToLower();

            //// get substring
            //string sub1 = str.Substring(0);
            //string sub2 = str.Substring(0, str.Length - 1);

            //// remove substring
            //string subRemove1 = str.Remove(1); // H
            //string subRemove2 = str.Remove(0, 6); // World!

            //// replace parts of string
            //string subReplace1 = str.Replace('o', '0'); // Hell0 W0rld!
            //string subReplace2 = str.Replace('!', ')'); // Hello World)

            //string subReplace3 = str.Replace('World', "Microsoft"); // Hello Microsoft!

            //int index1 = str.IndexOf('o'); // 4
            //int index2 = str.IndexOf('Z'); // -1
            //int index3 = str.IndexOf("World"); // 6
            //int index4 = str.IndexOf("world"); // -1

            //int index5 = str.LastIndexOf('o'); // 7

            //// Trim whitespace from a string

            //string unTrimmed = "     Hello world!     ";

            //string trim1 = unTrimmed.TrimStart(); //"Hello world!   "
            //string trim2 = unTrimmed.TrimEnd(); //"     Hello world!"
            //string trim3 = unTrimmed.Trim(); // "Hello world!"

            // Format a string

            //const string formatStr = "Hello {0}! Such lovely {1} we're having for a {2}, it only rained {3} times! the time is {4}";

            //const string adam = "Adam";
            //const string noun = "weather";
            //const string dayOfWeek = "Tuesday";


            //string formattedString = string.Format(formatStr, adam, noun, dayOfWeek);

            //string boolStr = "true";
            //string intStr = "12345";
            //string doubleStr = "3.14159";

            //bool bParsed = bool.Parse(boolStr);
            //int tParsed = int.Parse(intStr);
            //double dParsed = double.Parse(doubleStr);

            // Enumeration

        //    enum Mood {
        //    Undefined, // defaults to 0
        //    Hungry, // defaults to 1
        //    Sleepy = 50,
        //    Grumpy = 10,
        //    Happy = 2
        //}

        ////var myMood = Mood.Happy;
        //int myMoodAsInt = (int)Mood.Happy;
        //string myMoodAsStr = Mood.Happy.ToString();



        //var myBook = new Book();
        //myBook.title = "Jurassic Park";
        //myBook.author = "Michael Crichton";
        //myBook.price = 9.99;

        // var myBook2 = new Book();
        // myBook2.title = "Harry Potter";
        // myBook2.author "J. K. Rowling";
        // myBook2.price = 5.99;

    }


    // structs
    public struct Book
    {
        public double price;
        public string title;
        public string author;
    }


}
