using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 02
            //Q1

            Console.WriteLine("Enter 1st number :");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number :");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum;
            sum = n1 + n2;

            Console.WriteLine("sum is :" + sum);
            Console.ReadLine();


            //Q2

            Console.WriteLine("Enter 1st number :");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number :");
            double num2 = Convert.ToInt32(Console.ReadLine());

            double Sum = num1 + num2;
            Console.WriteLine("sum is :" + sum);


            double sub = num1 - num2;
            Console.WriteLine("sunstraction is :" + sub);


            double mul = num1 * num2;
            Console.WriteLine("multiplication is :" + mul);


            double div = num1 / num2;
            Console.WriteLine("division  is :" + div);


            Console.ReadLine();



            //Q3

            Console.WriteLine("Enter the radius :");
            double r = Convert.ToDouble(Console.ReadLine());

            double area = 3.14 * r * r;
            Console.WriteLine("area is :" + area);

            double circum = 2 * 3.24 * r;
            Console.WriteLine("Circumference is :" + circum);

            Console.ReadLine();




            //Q4
            Console.WriteLine("Enter the number :");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even number");
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine("odd number");
                Console.ReadLine();
            }



            //Q5

            const int NumberOfInputs = 10;

            Console.WriteLine("Enter 10 numbers :");

            for (int i = 1; i < NumberOfInputs; i++)
            {
                Console.WriteLine($"Number {i} :");

                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }

            }

















        }
    }
}
  