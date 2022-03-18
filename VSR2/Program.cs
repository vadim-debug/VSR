using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Простейший калькулятор

            Console.WriteLine("Введите первое число:");
           double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            char oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
           double b = Convert.ToDouble(Console.ReadLine());
            double total;
            if (oper == '+')
            {
                 total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }
        }
    }
}
