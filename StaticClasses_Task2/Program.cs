using System;
using System.Linq;
using System.Net;

namespace StaticClasses_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4, 1, 7, 3, 6, 9, 0};
            Console.WriteLine("origin array: ");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine("\nreversed array: ");
            array = array.MyReverse();
            foreach (int i in array)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }

    public static class MyExtentionsMethods
    {
        public static int[] MyReverse(this int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}
