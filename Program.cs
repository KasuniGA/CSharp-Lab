using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 01
            // Q1
            string Name = "KASUNI ABEYANAYAKE";
            double batch = 22.2;

            Console.WriteLine("I'm " + Name + " and my batch is " + batch);
            Console.ReadLine();



            // Q2
            Console.Write("Enter the radius :");
            double radius = Convert.ToDouble(Console.ReadLine());


            double area;
            area = 3.14 * radius * radius;

            Console.Write("area is :" + area);



            Console.ReadLine();


            //Q3
            Console.Write("Enter 1st number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum;
            sum = num1 + num2;

            Console.WriteLine("sum is " + sum);
            Console.ReadLine();



            //Q4
            Console.WriteLine("Enter the salary :");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the tax rate :");
            double tax = Convert.ToDouble(Console.ReadLine());

            double newSalary;

            newSalary = salary - tax;
            Console.WriteLine("new salary is :" + newSalary);
            Console.ReadLine();


        }
    }
}
    