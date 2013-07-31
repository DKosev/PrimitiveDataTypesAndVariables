//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties. Do the above in two different ways: with and without using quoted strings.

using System;

class QuotationsString
{
    static void Main()
    {
        string firstWay = @"The ""use"" of quotations causes difficulties.";
        string secondWay = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine("The output of the two strings is the same:\n");
        Console.WriteLine("{0}\n{1}", firstWay, secondWay);
    }
}
