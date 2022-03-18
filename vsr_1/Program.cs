using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsr_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача: Определить наибольший отрицательный элемент в массиве
            int[] Arr = {-3,-2,89,13,-1};
            int min = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i]<0)
                {
                    if (min<Arr[i])
                    {
                       min = Arr[i];
                    }
                }
            }
            Console.WriteLine(min);

        }
    }
}
