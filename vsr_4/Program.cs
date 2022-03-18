using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsr_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Подкидывание монетки
            Random rnd = new Random();
            int d = rnd.Next(2);

            if (d==0)
            {
                Console.WriteLine("Выпал орёл");
            }
            else {
                Console.WriteLine("Выпала решка");
            }
        }
    }
}
