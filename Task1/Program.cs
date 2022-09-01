using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало main");
            Console.WriteLine();
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);
            int fact = Fact(n - 1);
            Console.WriteLine($"Результат main: {fact}");
            Console.WriteLine();
            Console.WriteLine("Конец main");
            Console.WriteLine();
            Console.ReadKey();
        }
        static int Fact(int n)
        {
            Console.WriteLine("Начало Fact");
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Console.WriteLine(f);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Конец Fact");
            Console.WriteLine();
            return f;
        }

        static async Task FactAsync(int n)
        {
            Console.WriteLine("Начало FactAsync");
            Console.WriteLine();
            int resoult = await Task.Run(() => Fact(n));
            Console.WriteLine($"Результат FactAsync: {resoult}");
            Console.WriteLine();
            Console.WriteLine("Конец FactAsync");
            Console.WriteLine();
        }
    }
}
