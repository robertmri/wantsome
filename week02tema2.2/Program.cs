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
            ex8();

        }

        private static void ex8()
        {
            //Copy elements from an array into another
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;


            Console.Write("\n\nCopy the elements one array into another array :\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }


            Console.Write("\nThe elements stored in the first array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }


            Console.Write("\n\nThe elements copied into the second array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n\n");
        }

        private static void ex7()
        {
            //Find common elements between two arrays of integers
            List<int> a = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> b = new List<int> { 2, 4, 6, 8, 10 };

            int CommonNumber = a.Intersect(b).Count();
            Console.WriteLine(CommonNumber);
        }

        private static void ex6()
        {
            //Find the maximum and minimum value of an array.
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min, n;

            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);
        }

        private static void ex5()
        {
            //Insert an element into an array at a specified position
            
            int i = 0;
            int pos = 0;
            int item = 0;
            int[] arr = new int[10];

            
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter position : ");
            pos = int.Parse(Console.ReadLine());

            Console.Write("Enter new item : ");
            item = int.Parse(Console.ReadLine());

            
            for (i = 5; i >= pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[pos - 1] = item;

            
            Console.WriteLine("Array elements after insertion : ");
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
        }

        private static void ex4()
        {
            // remove an element from array
            int i = 0;
            int pos;
            int[] arr = new int[5] { 35, 50, 55, 77, 98 };

            Console.WriteLine("Elements before deletion:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Element[" + (i) + "]: " + arr[i]);
            }

            pos = 2;

            for (i = pos - 1; i < 4; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("Elements after deletion: ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
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
