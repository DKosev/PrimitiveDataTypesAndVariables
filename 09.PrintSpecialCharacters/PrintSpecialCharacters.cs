//Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

using System;

class PrintSpecialCharacters
{
    static void Main()
    {
        char copyrightSymbol = '\u00a9';
        Console.Write("How many rows of the triangle do you want to add?\n=> ");
        int row = int.Parse(Console.ReadLine());
        for (int i = 0; i < row; i++)
        {
            Console.Write(new string(' ', row - i + 20));
            Console.Write(new string(copyrightSymbol, 2 * i + 1));
            Console.WriteLine();
        }
    }
}