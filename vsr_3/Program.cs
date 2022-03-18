using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsr_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Факториал числа
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
                if (i == num)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0} * ", i);
                }
            }
            Console.Write(" = {0}", factorial);
            Console.ReadKey();
            
        }
    }
}
