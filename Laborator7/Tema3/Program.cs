using System;

namespace Tema3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nr pana la care sa fie extrase nr. prime:");
            string number = Console.ReadLine();
            int nr;
            if (!Int32.TryParse(number, out nr))
            {
                Console.WriteLine("Numar incorect");
            }

            PrimeNumbers(nr);
        }

        static void PrimeNumbers(int nr)
        {

            if (nr == 0)
            {
                Console.WriteLine("Nu exista numere prime.");
                return;
            }

            if (nr == 1)
            {
                Console.WriteLine("Nr. prime: 1");
                return;
            }

            bool[] primes = new bool[nr];
            

            for (int i = 2; i < primes.Length; i++)
            {
                if ((i % 2 == 0 && i != 2) || (i % 3 == 0 && i != 3) || (i % 5 == 0 && i != 5) || (i % 7 == 0 && i != 7)) primes[i] = true;
             }
            
            for (int i = 1; i < primes.Length; i++)
            {
                if (!primes[i]) Console.Write($"{i},");
            }
        }
    }
}
