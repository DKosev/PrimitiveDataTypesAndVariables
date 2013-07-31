//Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class CharVariableUnicode
{
    static void Main()
    {
        int decValue = 72;
        char hexValue = '\u0048';
        Console.WriteLine("The symbol with Unicode {0} is: {1}\a", decValue, hexValue);
    }
}
