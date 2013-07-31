//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountInfo
{
    static void Main()
    {
        string firstName = "Dimitar";
        string middleName = "Dimitrov";
        string lastName = "Dimitrov";
        decimal balance = 950.33m;
        string bankName = "Banka";
        string ibanNumber = "BG99 9999 9999 9999 9999 99";
        string bicCode = "BG99999999";
        string firstCreditCard = "999999999999999";
        string secondCreditCard = "888888888888888";
        string thirdCreditCard = "777777777777777";

        Console.WriteLine("Account information:\n");
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Middle Name: {0}", middleName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Account Balance: {0} BGN", balance);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN Number: {0}", ibanNumber);
        Console.WriteLine("BIC Code: {0}", bicCode);
        Console.WriteLine("Credit Card Numbers: {0} / {1} / {2}", firstCreditCard, secondCreditCard, thirdCreditCard);
    }
}
