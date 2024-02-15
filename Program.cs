using System;

class Interval
{
    static void Main()
    {
        // ask the user to enter a real number
        Console.Write("Enter a real number: ");
        double x = double.Parse(Console.ReadLine());

        // Checking if the entered number belongs to the specified interval I
        bool belongsToI = (x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2);

        // Displaying the result based on the test
        if (belongsToI)
        {
            Console.WriteLine($"x belongs to I");
        }
        else
        {
            Console.WriteLine($"x does not belong to I");
        }
    }
}
