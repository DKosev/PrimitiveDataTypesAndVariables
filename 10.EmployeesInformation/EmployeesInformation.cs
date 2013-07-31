//A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class EmployeesInformation
{
    static void Main()
    {
        Console.Write("Enter your First name:\n=> ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your Last name:\n=> ");
        string lastName = Console.ReadLine();
        Console.Write("Enter your Age:\n=> ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter your Gender: m/f\n=> ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Enter your ID Number:\n=> ");
        uint idNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter your Employee Number: (27560000 to 27569999)\n=> ");
        uint employeeNumber = uint.Parse(Console.ReadLine());

        Console.WriteLine("\nPlease check your information below:\n");
        Console.WriteLine("\tFirst Name: {0}", firstName);
        Console.WriteLine("\tLast Name: {0}", lastName);
        Console.WriteLine("\tAge: {0}", age);
        if (gender == 'm')
            Console.WriteLine("\tGender: Male");
        else if (gender == 'f')
            Console.WriteLine("\tGender: Female");
        else
            Console.WriteLine("\tGender: Incorrect Information!");
        Console.WriteLine("\tID Number: {0}", idNumber);
        if (employeeNumber < 27560000)
            Console.WriteLine("\tEmployee Number: Incorrect Information!");
        else if (employeeNumber > 27569999)
            Console.WriteLine("\tEmployee Number: Incorrect Information!");
        else
            Console.WriteLine("\tEmployee Number: {0}", employeeNumber);
        Console.Write("\nDo you want to change your information? y/n\n=> ");
        Console.ReadLine();
    }
}
