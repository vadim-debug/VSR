using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsr_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // нахождение чисел в массиве меньше среднего арифметического
            int[] Arr = { -3, -2, 89, 13, -1 };
            int sum =0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum+=Arr[i];
            }

            int avg = sum/Arr.Length; 


            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < avg)
                {
                    Console.WriteLine(Arr[i]);
                }
            }
          
        }
    }
}
