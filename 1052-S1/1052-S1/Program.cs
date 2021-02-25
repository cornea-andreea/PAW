using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1052_S1
{
    class Program
    {
        static void Main(string[] args)
        {
            //afisare consola; diferenta intre Console.WriteLine si Console.Write
            Console.Write("Hello ");
            Console.Write("grupa ");
            Console.Write("1052");
            Console.Write(Environment.NewLine);
            Console.WriteLine("Hello ");
            Console.WriteLine("grupa ");
            Console.WriteLine("1052");

            //citire si afisare consola
            Console.Write("Scrie activitatea: ");
            string activity = Console.ReadLine();
            int activityNo = 1;
            Console.WriteLine("Activitatea {0} si seminar {1} ", activity, activityNo);

            int[] numbers1 = new int[5];
            int[] numbers2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Print array with for:");
            for (int i=0; i< numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
            Console.WriteLine("Print array with foreach:");
            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }

            //shallow copy
            int[] numbers3 = numbers2;
            Console.WriteLine("Shallow copy:");
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers3[0]);
            numbers2[0] = 7;
            Console.WriteLine("After changing numbers2[0] value:");
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers3[0]);

            //deep copy with for
            //{ 7, 2, 3, 4, 5 };
            int[] deepArrayByFor = new int[numbers2.Length];
            for (int i=0; i< numbers2.Length; i++)
            {
                deepArrayByFor[i] = numbers2[i];
            }
            Console.WriteLine("Deep copy:");
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(deepArrayByFor[0]);
            numbers2[0] = 1;
            Console.WriteLine("After changing numbers2[0] value:");
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(deepArrayByFor[0]);

            //deep copy with CopyTo
            int[] deepArrayByCopyTo = new int[numbers2.Length];
            numbers2.CopyTo(deepArrayByCopyTo, 0);

            Console.WriteLine("Deep copy:");
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(deepArrayByCopyTo[0]);
            numbers2[0] = 10;
            Console.WriteLine("After changing numbers2[0] value:");
            Console.WriteLine(numbers2[0]);
            Console.WriteLine(deepArrayByCopyTo[0]);

            Movie movie = new Movie();
            movie.Name = "abc";
            Console.WriteLine(movie.Name);
            Console.WriteLine(movie.ToString());
        }
    }
}
