using System;

// Write a program that calculates N!*K! divided by(/) (K-N) for given N and K(1<N<K).

namespace nakovCSharpBook06ex05
{
    class FactorialDivision
    {
        static void Main()
        {
            DivideFactorial();
        }

        private static void DivideFactorial()
        {
            Console.Write("Enter N: ");
            decimal n = 0;

            string userInp = Console.ReadLine();
            bool check = decimal.TryParse(userInp, out n);

            Console.Write("Enter K: ");
            decimal k = 0;
            string userInp2 = Console.ReadLine();
            bool check2 = decimal.TryParse(userInp2, out k);

            if (check != true || check2 != true)
            {
                Console.WriteLine("Please enter a number");
            }

            // N!*K! / (K-N)! = N! * (K - (K - N))
            decimal nFact = 1;
            for (decimal i = 1; i <= n; i++)
            {
                nFact = nFact * i;
            }

            decimal secondResult = 1;
            for (decimal i = 0; i < (k - (k - n)); i++)
            {
                secondResult = secondResult * (k - i);
            }

            Console.WriteLine(nFact * secondResult);
        }
    }
}
