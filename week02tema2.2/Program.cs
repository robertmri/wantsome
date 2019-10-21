using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week02tema2._2
{
    class Program
    {
        static void Main(string[] args)

        {
            ex3();

        }

        private static void ex3()
        {
            // index of an element in an array
            int[] Array = { 5, 8, 3, 7 };
            int Element = 3;
            int Index;

            for (int i = 0; i < Array.Length; i++)
            {
                if (Element == Array[i])
                {
                    Index = i;
                }
            }
        }

        private static void ex2()
        {
            //1. average value of array

            int size;
            Console.WriteLine("enter the size:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("enter the element of array:");
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int len = a.Length;
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += a[i];
            }
            average = sum / size;
            Console.WriteLine("Average is:" + average);
            Console.ReadLine();
        }

        private static void ex1()
        {

            // 1. sum the values of an array

            int[] array = new int[] { 1, 5, 89, 35, 67 };
            int sum = array.Sum();

            Console.WriteLine("Suma elementelor este:" + sum);
        }
    }
}
