using System;

class Program
{
    static void Main(string[] args)
    {
        int age = 23;
        Console.WriteLine(age);

        long num = 1000000L;
        System.Console.WriteLine(num);

        double negative = -55.2D;
        System.Console.WriteLine(negative);

        float precision = 11.000022F;
        System.Console.WriteLine(precision);

        decimal money = 14.99M;
        System.Console.WriteLine(money);

        System.Console.WriteLine(int.MaxValue);
        System.Console.WriteLine(long.MaxValue);
        System.Console.WriteLine(double.MaxValue);
        System.Console.WriteLine(float.MaxValue);

         // Numeric data types
        int intVar = 10;          // Integer
        double doubleVar = 15.5;  // Double
        float floatVar = 7.2f;    // Float
        long longVar = 123456789L; // Long
        short shortVar = 3;       // Short
        byte byteVar = 255;       // Byte

        // Displaying numeric variables
        Console.WriteLine("Numeric Data Types:");
        Console.WriteLine($"intVar: {intVar}, doubleVar: {doubleVar}, floatVar: {floatVar}, longVar: {longVar}, shortVar: {shortVar}, byteVar: {byteVar}");

        // Text-based data types
        string strVar = "Hello, C#!"; // String
        char charVar = 'A';           // Character

        // Displaying text variables
        Console.WriteLine("\nText-Based Data Types:");
        Console.WriteLine($"strVar: {strVar}, charVar: {charVar}");

        // Converting string to numbers
        string numStr = "12345";
        int convertedNum = int.Parse(numStr); // Converting string to integer
        double convertedDouble = double.Parse("12.34"); // Converting string to double

        // Displaying converted values
        Console.WriteLine("\nConverting String to Numbers:");
        Console.WriteLine($"Converted int: {convertedNum}, Converted double: {convertedDouble}");

        // Boolean data type
        bool isActive = true;  // Boolean
        bool isFinished = false; // Boolean

        // Displaying boolean values
        Console.WriteLine("\nBoolean Data Types:");
        Console.WriteLine($"isActive: {isActive}, isFinished: {isFinished}");

        // Operators
        int addition = intVar + 5;    // Addition
        int subtraction = intVar - 2; // Subtraction
        int multiplication = intVar * 3; // Multiplication
        double division = doubleVar / 2;  // Division
        int remainder = intVar % 3;   // Remainder (Modulus)

        // Displaying results of operators
        Console.WriteLine("\nOperators:");
        Console.WriteLine($"Addition: {addition}, Subtraction: {subtraction}, Multiplication: {multiplication}, Division: {division}, Remainder: {remainder}");

        // Remainder
        Console.WriteLine("\nRemainder:");
        Console.WriteLine($"Remainder when {intVar} is divided by 3: {remainder}");

        // Var keyword
        var dynamicVar = "This is a string!";
        Console.WriteLine("\nVar Keyword:");
        Console.WriteLine($"dynamicVar: {dynamicVar}");

        // Const keyword
        const double pi = 3.14159;  // Const value for Pi
        Console.WriteLine("\nConst Keyword:");
        Console.WriteLine($"The value of Pi is: {pi}");
    }
}
