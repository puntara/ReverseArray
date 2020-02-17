using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5,6};
            printArray(nums,6);
            ReverseArray(nums,0, 6);
            printArray(nums, 6);
        }
        static void printArray(int [] arr, int n )
        {
            for (int i = 0; i < n ; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void ReverseArray(int [] arr, int initial, int n)
        {
            int temp;

            while (initial < n)
            {
                temp = arr[initial];
                arr[initial] = arr[n-1];
                arr[n-1] = temp;
                initial = initial + 1;
                n = n - 1;
            }
        }
    }
}
