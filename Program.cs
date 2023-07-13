using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num1, num2;
            Console.WriteLine("Enter Number"); 
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number"); 
            num2 = int.Parse(Console.ReadLine());
            var result = num1 > num2 ? "First Number is greater" : "Second Number is greater";

            Console.WriteLine(result);
            Console.ReadKey();*/

            int pre, final;
            Console.WriteLine("Enter Marks");
            pre = int.Parse(Console.ReadLine());
            if(pre > 60)
            {
                Console.WriteLine("Enter marks obtained in finals");
                final = int.Parse(Console.ReadLine());

                if(final > 55)
                {
                    Console.WriteLine("Selected");
                } else
                {
                    Console.WriteLine("Fail in finals");
                }
            } 
            else
            {
                Console.WriteLine("Fail in pre");
            }
            Console.ReadKey();

        }
    }
}
