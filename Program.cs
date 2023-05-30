using System.ComponentModel.Design;

namespace C__gr3_part1_HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to check two given integers and return true if one is negative and one is positive.

            int no1, no2;
            bool check;

            Console.WriteLine("Checking two given integers and returning \"True\" if one is negative and one is positive...");
            Console.Write("Enter the first number: ");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            no2 = Convert.ToInt32(Console.ReadLine());
            check = (no1>0) ^ (no2>0);
            Console.WriteLine("The result is: " + check.ToString() + "\nPress Enter to continue...");

            Console.ReadLine();

            // - Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.


            Console.WriteLine("Checking if one of the numbers or the sum of those numbers is equal to 20...");

            Console.Write("Enter the first number: ");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            no2 = Convert.ToInt32(Console.ReadLine());
            check = no1 == 20 || no2 == 20 || ((no1 + no2) == 20);
            Console.WriteLine("The result is: " + check.ToString() + "\nPress Enter to continue...");

            Console.ReadLine();

            // - Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.

            Console.WriteLine("\nOdd numbers from 1 to 99:");

            for (int oddNumber = 1; oddNumber <=99; oddNumber +=2)
            {
                Console.WriteLine(oddNumber);
            }

            // - Write a C# program to compute the sum of the first 500 prime numbers.

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            int i = 2, j, sumOfPrimes = 0, countOfPrimes = 0;

            while (countOfPrimes<500)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; // if factor found, not prime

                if (j > (i / j))
                {
                    sumOfPrimes += i;
                    countOfPrimes++;
                }

                i++;
            }

            Console.WriteLine("The sum of first 500 prime numbers is: {0}", sumOfPrimes);

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            // Write a C# program and compute the sum of the digits of an integer.

            Console.Write("Calculating the sum of the digits in a given number...\nPlease enter the number: ");
            no1 = Convert.ToInt32(Console.ReadLine());
            no2 = 0;

            while (no1!=0)
            {
                no2 += no1 % 10;
                no1 = no1 / 10;
            }

            if (no2 < 0)
                no2 *= -1;

            Console.WriteLine("The sum of the digits is: {0}", no2);
            Console.WriteLine("\nPress Enter to finish...");
            Console.ReadLine();
        }
    }
}