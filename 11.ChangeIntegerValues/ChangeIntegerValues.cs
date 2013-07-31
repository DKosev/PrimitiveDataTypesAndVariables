//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ChangeIntegerValues
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;

        Console.WriteLine("We have two values: {0} and {1}", firstValue, secondValue);

        int tempValue;
        tempValue = firstValue;
        firstValue = secondValue;
        secondValue = tempValue;

        Console.WriteLine("After the exchange: {0} and {1}", firstValue, secondValue);
    }
}
