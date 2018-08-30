using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("--------This program will compute the average of ten numbers----------");
            Console.WriteLine("----------------------------------------------------------------------");

            float total = 0;
            for(int i=1; i <=10; i++)
            {
                Console.Write($"Enter number {i}: ");
                total = total + float.Parse(Console.ReadLine())/10;
            }
            Console.WriteLine($"The average of those ten numbers is: {total} ");

            Console.ReadLine();
        }
    }
}
