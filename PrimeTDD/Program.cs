using System;
using System.Collections.Generic;

namespace PrimeTDD
{
    public class PrimeNumbers
    {
        public static int GetPrime(int number)
        {
            List<int> prime = new List<int>();

            for (int i = 2; i <= 10500; i++)
            {
                bool primeNum = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primeNum = false;
                        break;
                    }
                }
                if (primeNum == true)
                {
                    prime.Add(i);
                }
            }
            int fetch = prime[number - 1];
            Console.WriteLine($"{fetch}\n"); 
            return fetch;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Let's locate some primes!\n");
            Console.WriteLine("This application will find you any prime, in order, from first prime number on.\n");
            bool done = false;
            while (done == false)
            {

                bool valid = false;
                while (valid == false)
                {
                    Console.Write("Which prime number are you looking for? ");
                    string input = Console.ReadLine();
                    int prime;
                    bool convert = Int32.TryParse(input, out prime);
                    if (convert == true)
                    {
                        valid = true;
                        PrimeNumbers.GetPrime(prime);
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number, try again.\n");
                    }
                }
                
               

                bool correct = false;
                while (correct == false)
                {

                    Console.Write("Do you want to find another prime number? (y/n): ");
                    string resp = Console.ReadLine().ToLower();
                    if (resp != "n" && resp != "y")
                    {
                        Console.WriteLine("That is not a correct option, try again\n");
                    }
                    else if (resp == "y")
                    {
                        correct = true;
                    }
                    else
                    {
                        correct = true;
                        done = true;
                    }
                }
            }
        }
    }
}
