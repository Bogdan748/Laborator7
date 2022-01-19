using System;

namespace Tema4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate numere ale lui Fibonacci?");
            string number = Console.ReadLine();
            int nr;
            if (!Int32.TryParse(number, out nr))
            {
                Console.WriteLine("Numar incorect");
            }

            Fibo(nr);
        }

        static void Fibo(int n)
        {
            int[] rezult = new int[n];

            if (n >= 1)
            {
                rezult[0] = 0;
            }

            if (n >= 2)
            {
                rezult[1] = 1;
            }
            
            

            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    rezult[i] = rezult[i - 1] + rezult[i - 2];
                }
            }

            Console.WriteLine($"Nr. sunt: {String.Join(",", rezult)}");
        }
    }
}
