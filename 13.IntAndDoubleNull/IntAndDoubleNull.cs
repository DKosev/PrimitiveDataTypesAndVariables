//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class IntAndDoubleNull
{
    static void Main()
    {
        int? intValue = null;
        double? doubleValue = null;

        Console.WriteLine("The int null value: {0}\nThe double null value: {1}", intValue, doubleValue);
        Console.WriteLine("If we add a value to the null int, the result is: {0}", intValue + 500);
        Console.WriteLine("If we add a value to the null double, the result is: {0}", doubleValue + 500);
    }
}