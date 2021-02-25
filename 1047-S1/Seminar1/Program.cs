using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    class Program
    {
        static void Main(string[] args)
        {

            //citire si scriere la consola; diferenta intre Console.WriteLine si Console.Write
            Console.Write(".NET ");
            Console.Write("Framework");
            Console.Write(Environment.NewLine);
            Console.WriteLine(".NET");
            Console.WriteLine("Framework");

            Console.Write("Nume materie: ");
            string name = Console.ReadLine();
            int number = 1;
            Console.WriteLine("Numele materiei este {0} si seminarul {1}", name, number);

            //definire array
            int[] numbers = new int[5];
            int[] numbers2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Afisare array cu for: ");
            for (int i=0; i< numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            Console.WriteLine("Afisare array cu foreach: ");
            foreach(int i in numbers2)
            {
                Console.WriteLine(i);
            }

            //shallow copy
            Console.WriteLine("Before shallow copy: ");
            int[] shallowNumbers = numbers2;
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(shallowNumbers[0]);
            Console.WriteLine("After shallow copy: ");
            numbers2[0] = 6;
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(shallowNumbers[0]);

            //deep copy
            Console.WriteLine("Deep copy with for: ");
            int[] deepArrayByFor = new int[numbers2.Length];
            for (int i=0; i< numbers2.Length; i++)
            {
                deepArrayByFor[i] = numbers2[i];
            }
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(deepArrayByFor[0]);
            Console.WriteLine("After deep copy: ");
            numbers2[0] = 1;
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(deepArrayByFor[0]);

            Console.WriteLine("Deep copy with CopyTo: ");
            int[] deepArrayByCopyTo = new int[numbers2.Length];
            numbers2.CopyTo(deepArrayByCopyTo, 0);

            Console.WriteLine(numbers2[0]);
            Console.WriteLine(deepArrayByCopyTo[0]);
            Console.WriteLine("After deep copy: ");
            numbers2[0] = 10;
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(deepArrayByCopyTo[0]);

            Product product1 = new Product();
            product1.Name = "pizza";
            Console.WriteLine(product1.Name);
            product1.Name = "coffee";
            Console.WriteLine(product1.Name);
        }
    }
}
