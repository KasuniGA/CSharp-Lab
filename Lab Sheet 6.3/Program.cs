using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();

            animal.AnimalMethod();
            dog.AnimalMethod();
            dog.DogMethod();
        }
    }
}