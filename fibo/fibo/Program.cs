using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            int firstNumber = 0, secondNumber = 1, nextNumber;

            Console.WriteLine("Fibonacci sequence:");

            for (int i = 1; i <= terms; i++)
            {
                if (i == 1)
                {
                    Console.Write(firstNumber + " ");
                    continue;
                }
                if (i == 2)
                {
                    Console.Write(secondNumber + " ");
                    continue;
                }
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;

                Console.Write(nextNumber + " ");
            }
        }
    }
}
