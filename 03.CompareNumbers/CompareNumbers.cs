//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

class CompareNumbers
{
    static void Main()
    {
        float firstValue = 6.03f;
        float secondValue = 6.04f;
        Boolean compare = (firstValue == secondValue);
        Console.WriteLine(compare);

        float thirdValue = 6.00000001f;
        float fourthValue = 6.00000003f;
        Console.WriteLine(thirdValue == fourthValue);

        decimal fifthValue = 6.00000001m;
        decimal sixthValue = 6.00000003m;
        Console.WriteLine(fifthValue == sixthValue);
    }
}
