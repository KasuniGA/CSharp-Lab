using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 03

            //Q1

            Console.WriteLine("Enter the integer number :");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Odd");
                Console.ReadLine();
            }


            //Q2

            string inputstring;
            int i, len, vowels, others;


            inputstring = "afggeiiofivm";
            vowels = 0;
            others = 0;
            len = inputstring.Length;


            for (i = 0; i < len; i++)
            {


                if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                    inputstring[i] == 'i' || inputstring[i] == 'o' ||
                    inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U')
                {


                    vowels++;
                }



                else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
                         (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
                {


                    others++;
                }
            }


            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + others);

            Console.ReadLine();


            // Q3


            Console.WriteLine("Enter the number");
            int Num = Convert.ToInt32(Console.ReadLine());


            int sum = 0, r;
            for (int l = 0; num > 0; l++)
            {
                r = num % 10;
                sum = sum + r;
                num = num / 10;

            }
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();

            //Q4
            int Sum = 0;
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int k = 0; k < number; k += 2)
            {
                sum += k;
            }
            Console.Write($"Sum of Odd numbers from 1 to {number} is : {sum}");
            Console.ReadKey();
        }
    }
}
