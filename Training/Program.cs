using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Введите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"Число {num1} и {num2} равны.");

            }
            else if (num1 > num2)
            {
                Console.WriteLine($"Первое число - {num1} больше второго - {num2}.");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Первое число - {num1} меньше второго - {num2}.");
            }
            else 
            {
                
                Console.WriteLine("Ой вы совершили ошибку :( ");
            }


            Console.ReadKey();
        }
    }
}
 