//Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.

using System;

class ConvertDecimalToHex
{
    static void Main()
    {
        int decimalValue = 254;
        string hexValue = decimalValue.ToString("X");

        Console.WriteLine("The number {0} converted to HEX looks like: {1}", decimalValue, hexValue);
    }
}