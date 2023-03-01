using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
  
            List<ulong> numbers = new List<ulong>();

            numbers.Add(1);
            numbers.Add(1);  
            Console.WriteLine();
            Console.WriteLine("Vuvedi do koe chislo na Fibonachi iskash da vkarash: ");
            byte numFib = byte.Parse(Console.ReadLine());
            for (int i = 2; i < numFib; i++)
            {
                numbers.Add(numbers[i-2] + numbers[i-1]);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
