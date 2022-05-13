using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("{0} is Leap Year", year);
            else
                Console.WriteLine("{0} is not a Leap Year", year);
            
            
            Console.ReadLine();
        }
    }
}