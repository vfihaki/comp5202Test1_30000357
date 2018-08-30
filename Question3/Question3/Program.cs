using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-------This program will expand a basic quadratic equation------------");
            Console.WriteLine("----------------------(x + n) (x + m)---------------------------------");

            Console.WriteLine("LOOKING AT THE ABOVE BRACKETS...");
            int n, m;

            Console.Write("Enter a +ve or -ve value for n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter a +ve or -ve value for m: ");
            m = int.Parse(Console.ReadLine());


           Console.WriteLine("That is standard form is: x^2 {0}x {1}", (n + m), (n * m));
           

          
            Console.ReadLine();







        }
    }
}
