using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciAndPalindrom
{
    internal class Program
    {
        public static int fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
        public static bool palindrom(string str, int start, int end)
        {
            if (start >= end)
                return true;
            if (str[start] != str[end])
                return false;
            return palindrom(str, start + 1, end - 1);
        }
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("\n1 - фибоначи 2 - палиндром 0 - выход");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1:
                        {
                            Console.Write("введите количество чисел Фибоначчи, которые необходимо вывести: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                            while (count < 0)
                            {
                                Console.Write("Введите корректное положительное число: ");
                                count = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("последовательность Фибоначчи: ");
                            for (int i = 0; i < count; i++)
                            {
                                if (i + 1 == count) Console.Write(fibonacci(i));
                                else Console.Write(fibonacci(i) + ", ");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("введите строку для проверки на палиндром: ");
                            string ip = Console.ReadLine();
                            while (ip.Length == 0 || ip == " ")
                            {
                                Console.Write("введите строку для проверки на палиндром: ");
                                ip = Console.ReadLine();
                            }
                            string input = ip.Replace(" ", "").ToLower();
                            bool result = palindrom(input, 0, input.Length - 1);
                            if (result) Console.WriteLine("строка является палиндромом");
                            else Console.WriteLine("строка не является палиндромом");

                            break;
                        }
                    default: Console.WriteLine("Введите корректное значение");
                        break;
                }
            }
        }
    }
}
