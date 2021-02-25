using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1051_S1
{
    class Program
    {
        static void Main(string[] args)
        {

            //afisare consola; diferenta intre Console.WriteLine si Console.Write
            Console.Write("Hello ");
            Console.Write("grupa ");
            Console.Write("1051");
            Console.Write("\n");
            Console.WriteLine("Hello ");
            Console.WriteLine("grupa ");
            Console.WriteLine("1051");

            //citire de la tastatura si afisare consola
            Console.Write("Scrie activitatea: ");
            //string text = Console.ReadLine();
            int number = 1;
            Console.Write(Environment.NewLine);
            //Console.WriteLine("Activitatea {0} are numarul {1}", text, number);

            bool isTrue = false;
            Console.WriteLine(isTrue);

            //definire array
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] numberArray = new int[5];
            Console.WriteLine("Afisare array:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //shallow copy
            Console.WriteLine("Shallow copy:");
            int[] shallowArray = numbers;
            Console.WriteLine(shallowArray[0]);
            Console.WriteLine(numbers[0]);
            numbers[0] = 0;
            Console.WriteLine(shallowArray[0]);
            Console.WriteLine(numbers[0]);

            //deep copy with for
            Console.WriteLine("Deep copy with for: ");
            int[] deepArrayByFor = new int[numbers.Length];
            for (int i =0; i < numbers.Length; i++)
            {
                deepArrayByFor[i] = numbers[i];
            }
            Console.WriteLine(numbers[0]);
            Console.WriteLine(deepArrayByFor[0]);
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(deepArrayByFor[0]);

            //deep copy with CopyTo
            Console.WriteLine("Deep copy with CopyTo: ");
            int[] deepArrayByCopy = new int[numbers.Length];
            numbers.CopyTo(deepArrayByCopy, 0);

            Console.WriteLine(numbers[0]);
            Console.WriteLine(deepArrayByCopy[0]);
            numbers[0] = 6;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(deepArrayByCopy[0]);

            //define object and test constructor, get, set
            Group group = new Group();
            group.Number = 1;
            Console.WriteLine("Numarul grupului este {0}", group.Number);
            group.Name = "abc";
            Console.WriteLine("Numele grupului este {0}", group.Name);
            group.Name = "a";
            Console.WriteLine("Numele grupului este {0}", group.Name);
            Console.WriteLine("String interpolation:");
            Console.WriteLine($"Numele grupului este {group.Name}");

            Console.WriteLine(group.ToString());
            Console.WriteLine(group.afisare());

            //Parse si TryParse
            Console.WriteLine("Parse: ");
            string s1 = "8f";
            //int i1 = Int32.Parse(s1);
            //Console.WriteLine(i1);

            Console.WriteLine("TryParse false: ");
            int i2;
            Console.WriteLine(Int32.TryParse(s1, out i2));
            Console.WriteLine("TryParse true: ");
            string s2 = "88";
            Int32.TryParse(s2, out i2);
            Console.WriteLine(i2);
        }
    }
}
