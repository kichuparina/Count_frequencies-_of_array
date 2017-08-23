using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CountFrequenciesOfArray
{
    class Program
    {
        //static int[] arr = { 1, 5, 5, 2, 2, 3, 3, 6, 5, 10, 5, 8, 5, 4, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 2, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 24, 25, 25 };

        static int[] arr = { 1, 5, 5, 2, 2, 3, 3, 6, 5, 10 };
        static int length = 0;
        static void Main(string[] args)
        {

            length = arr.Length;

            Console.WriteLine("Input");
            Print();
            Console.WriteLine("..........");

            Thread.Sleep(1000);
            Method1();
            //Better approach
            Method2();

            Console.Read();

        }








        static void Method1()
        {
            Console.WriteLine("Output Method 1");

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 1; i <= length; i++)
            {

                int counter = 0;

                for (int j = 0; j < length; j++)
                {
                    if (i == arr[j])
                    {
                        counter++;
                    }
                }


                Console.WriteLine(i + "        " + counter);
            }
            sw.Stop();

            Console.WriteLine("Total Time: " + sw.Elapsed);

        }
        static void Method2()
        {

            Console.WriteLine("Output Method 2");
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < length; i++)
            {
                arr[i]--;
            }

            for (int i = 0; i < length; i++)
            {

                arr[arr[i] % length] = +length;
            }


            for (int i = 0; i < length; i++)
            {
                Console.WriteLine((i + 1) + "        " + arr[i] / length);
            }

            watch.Stop();
            Console.WriteLine("Total Time: " + watch.Elapsed);
        }




        static void Print()
        {

            foreach (var r in arr)
            {

                if (r.ToString().Length == 1)
                    Console.Write(" " + r + "  ");
                else
                    Console.Write(r + "  ");
            }

            Console.WriteLine("");

        }
    }
}
