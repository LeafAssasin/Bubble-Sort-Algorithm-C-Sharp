using BubbleSortAlgorithm;
using System;
using System.Diagnostics;
using bubbleInt = BubbleSortAlgorithm.BubbleSort<int>;
using bubbleDouble = BubbleSortAlgorithm.BubbleSort<double>;
using bubbleString = BubbleSortAlgorithm.BubbleSort<string>;

namespace BubbleSortAlgorithm
{
    class Program
    {
        static Random rand = new Random();
        static int n = 15;

        //TODO: Add Unit tests
        static void Main(string[] args)
        {
            int[] testIntArr = GenerateIntArray();
            double[] testDoubleArr = GenerateDoubleArray();
            string[] testStringArr = GenerateStringArray();

            Console.WriteLine("Original int arr:");
            Console.WriteLine(String.Join(", ", testIntArr));

            Console.WriteLine();

            Console.WriteLine("Original double arr:");
            Console.WriteLine(String.Join(", ", testDoubleArr));

            Console.WriteLine();

            Console.WriteLine("Original string arr:");
            Console.WriteLine(String.Join(", ", testStringArr));

            Console.WriteLine();

            Console.WriteLine("Int ascending:");
            Console.WriteLine(String.Join(", ", bubbleInt.SortAscending(testIntArr)));
            Console.WriteLine();
            Console.WriteLine("Int descending:");
            Console.WriteLine(String.Join(", ", bubbleInt.SortDescending(testIntArr)));

            Console.WriteLine();

            Console.WriteLine("Double ascending:");
            Console.WriteLine(String.Join(", ", bubbleDouble.SortAscending(testDoubleArr)));
            Console.WriteLine();
            Console.WriteLine("Double descending:");
            Console.WriteLine(String.Join(", ", bubbleDouble.SortDescending(testDoubleArr)));

            Console.WriteLine();

            Console.WriteLine("String ascending:");
            Console.WriteLine(String.Join(", ", bubbleString.SortAscending(testStringArr)));
            Console.WriteLine();
            Console.WriteLine("String descending:");
            Console.WriteLine(String.Join(", ", bubbleString.SortDescending(testStringArr)));
        }

        static int[] GenerateIntArray()
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 101);
            }

            return arr;
        }

        static double[] GenerateDoubleArray()
        {
            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 101);
            }

            return arr;
        }

        static string[] GenerateStringArray()
        {
            string[] arr = new string[n];

            for (int i = 0;i < n; i++)
            {
                int lenght = rand.Next(1, 21);

                arr[i] = RandomString(lenght);
            }

            return arr;
        }

        //generates random strings
        static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}
