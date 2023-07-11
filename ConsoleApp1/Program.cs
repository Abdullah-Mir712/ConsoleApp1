using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////SearchArray();
            //Console.WriteLine("\n\n");
            ////Palindrome();
            //Console.WriteLine("\n\n");
            //unsortedArray();
            //Console.WriteLine("\n\n");
            //Triangle();
            //reverseString();
            //PerfectNumber();
            //StringReversed();
            int n = 100; // Change the value of n as per your requirement

            Console.WriteLine("Prime numbers up to {0}:", n);

            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }


        
        Console.Read();
        }

      

        static void SearchArray()
        {
            int[] items =  { 11, 22, 33, 44, 55 };
            Console.WriteLine("enter a number ");
            int num1 = Convert.ToInt32( Console.ReadLine());
            int i = 0;
            bool found = true;
            while(i< items.Length)
            {
                if(items[i] == num1)
                {
                    Console.WriteLine("item found");
                    found = false;
                    break;

                }
                i++;
            }
            if (found == true)
            Console.WriteLine("item not found");
        }

        static void Palindrome()
        {
            Console.WriteLine("enter string to check if it is Palindrome: ");
            string item = Console.ReadLine();
            int left = 0, right = item.Length - 1;
            bool check = true;
            while(left < right)
            {
                if(item[left] != item[right])
                {
                    check = false;
                }

                left++;
                right--;
            }
            if(check== true)
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }


            
        }

        static void unsortedArray()
        {
            int[] unsortedArray = { 7, 2, 5, 1, 9, 3 };

            int smallest = unsortedArray[0];
            int largest = unsortedArray[0];

            foreach (int num in unsortedArray)
            {
                if (num < smallest)
                {
                    smallest = num;
                }

                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine("Smallest number: " + smallest);
            Console.WriteLine("Largest number: " + largest);

            

        }

        static void Triangle()
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

        static void reverseString()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversed = "";
            int length = input.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine("Reversed string: " + reversed);

        }
        


        static void PerfectNumber()
        {

            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sumOfDivisors = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sumOfDivisors += i;
                }
            }
            if(sumOfDivisors == number)
            {
                Console.WriteLine(number+" is a perfect number");
            }
            else
            {
                Console.WriteLine(number+" is not a perfect number");
            }
        }

        static void StringReversed()
        {
            string letter = "asdfgh";

            string reversed = "";
            for(int i = letter.Length-1; i>=0; i--)
            {
                reversed +=  letter[i].ToString();

            }
            Console.WriteLine(reversed);
        }
    }

    
}
