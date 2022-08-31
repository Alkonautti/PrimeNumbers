using System;
using System.Collections.Generic;
using System.Numerics;

namespace PrimeNumbers
{
    class Program
    {

        public static List<int> division = new List<int>();
        static void Main(string[] args)
        {
            CheckPrime();
        }
        public static void CheckPrime()
        {
            division.Clear();
            Console.WriteLine("\nEnter number to check: ");
            string uinput = Console.ReadLine();

            char temp = uinput[uinput.Length - 1];
            string input = temp.ToString();

            if (input == "0" ||
                input == "2" ||
                input == "4" ||
                input == "5" ||
                input == "6" ||
                input == "8")
            {
                Console.WriteLine("Not a prime number");
                CheckPrime();
            }

            else
            {
                BigInteger num = BigInteger.Parse(uinput);

                for (int i = 2; i < num; i++)
                {
                    Console.WriteLine($"Testing number: {i}");
                    if (num % i == 0)
                    {
                        Console.WriteLine($"Division found: {i}");
                        division.Add(i);
                        break;
                    }
                }

                if (division.Count != 0)
                {
                    Console.WriteLine("Not a prime number");
                    CheckPrime();
                }

                else
                {
                    Console.WriteLine($"{uinput} is a prime number!");
                    CheckPrime();
                }
            }
        }

    }
}
