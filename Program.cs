using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using a for loop to display the first 10 natural numbers
            Console.WriteLine("First 10 natural numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 

            // Using a while loop to print the first 10 even natural numbers
            Console.WriteLine("\nFirst 10 even natural numbers:");
            int j = 2;
            while (j <= 20)
            {
                Console.Write(j + " ");
                j += 2;
            }
            Console.WriteLine(); 

            // Using a do-while loop to print the first 10 odd natural numbers
            Console.WriteLine("\nFirst 10 odd natural numbers:");
            int k = 1;
            do
            {
                Console.Write(k + " ");
                k += 2;
            } while (k <= 19);
            Console.WriteLine(); 
            Console.ReadKey();
        }
    }
}
