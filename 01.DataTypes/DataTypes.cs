//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class DataTypes
{
    static void Main()
    {
        byte firstVariable = 97;
        sbyte fourthVariable = -115;
        short fifthVariable = -10000;
        ushort secondVariable = 52130;
        int thirdVariable = 4825932;

        Console.WriteLine("The variables:\n{0}\n{1}\n{2}\n{3}\n{4}", firstVariable, secondVariable, thirdVariable, fourthVariable, fifthVariable);
    }
}