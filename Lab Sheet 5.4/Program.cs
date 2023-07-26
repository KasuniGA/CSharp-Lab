using Question_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{

    public class SeparateClass
    {
        private void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }
    }

}

// question 02//



public class Program
{
    public static void Main()
    {
        SeparateClass separateObj = new SeparateClass();
        separateObj.SayHello();
    }
}