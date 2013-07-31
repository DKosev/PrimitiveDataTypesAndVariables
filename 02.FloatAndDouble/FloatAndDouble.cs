//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatAndDouble
{
    static void Main()
    {
        double firstValue = 34.567839023;
        float secondValue = 12.345F;
        double thirdValue = 8923.1234857;
        float fourthValue = 3456.091F;

        Console.WriteLine("The values of float type are: {0} and {1}", secondValue, fourthValue);
        Console.WriteLine("The values of double type are: {0} and {1}", firstValue, thirdValue);
    }
}
