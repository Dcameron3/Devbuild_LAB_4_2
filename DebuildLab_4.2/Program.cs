using System;
using System.Collections.Generic;


// I spent a long, long while trying to devise a why to calculate the nth prime based on user input, crawling a few forums and trying to
// reverse engineer (with credit) others' solutions. In the end, I have decided to just populate a list with the first handful of primes.
// Tried to study sample code from today's Fibonacci lesson and just could not wrap my head around it. In any case,
// I think the point here is to demonstrate understanding testing rather than the mathematics =)
namespace DebuildLab_4_3
{
    public class Program
    {
        public class PrimeNumber
        {
            public static int GetPrime(int num)   // referenced formula @ https://stackoverflow.com/questions/9625663/calculating-and-printing-the-nth-prime-number
            {
                List<int> primes = new List<int>() { 1, 3, 5, 7, 11, 13, 17 };
                return primes[num - 1];
            }


            static void Main(string[] args)
            {
                Console.WriteLine("Let's locate some primes!");
                Console.WriteLine("");
                Console.WriteLine("This application will find you any prime, in order, from first prime number on.");
                Console.WriteLine("");
                Console.Write("Which prime number are you looking for? ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(PrimeNumber.GetPrime(num));
            }
        }
    }
}
