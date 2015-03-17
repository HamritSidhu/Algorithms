using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            stringToIntConversion conversion = new stringToIntConversion();
            Console.WriteLine("Enter a string to convert:");
            string convertee = Console.ReadLine();
            conversion.convert(convertee);
            Console.ReadLine();
        }
    }
}
