using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-----This program can tell you if your number is odd or even----------");
            Console.WriteLine("----------------------------------------------------------------------");


            int R, numb;
            int i = 0;
            while (i == 0)
            {
                Console.Write("Enter a whole number between 1 and 1000: ");
                numb = int.Parse(Console.ReadLine());
                R = numb % 2;
                if(R == 0)
                {
                    Console.WriteLine("That number is even");
                    break;
                }
                else
                {
                    Console.WriteLine("That number is odd");
                    break;
                }
               
            }
            Console.ReadLine();



        }
    }
}
