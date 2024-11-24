using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session7
{
    internal class Algorithmson
    {
        public static void Main()
        {

        }
        public static int LinearSearch(int[] array, int ItemToSearch)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ItemToSearch)
                    return i;
            }
            return -1;
        }
        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        public static void Bubbleort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j > n - i - 1; j++)
                {
                    if (arr[i] > arr[j + 1])
                    {//to swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void selectionSort(int[] arr)
        {
            int n = arr.Length;
            //method to find length of array!
            for (int i = 0; i < n - 1; i++)
            {
                int index = 1;
                int min = arr[i];
                //taking the min element as the ith element of array
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[index])
                    {
                        index = j;
                        min = arr[j];
                    }
                }
                int t = arr[index];
                //interchange the place of the elements
                arr[index] = arr[i];
                arr[i] = t;
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                //move elements of arr[0...i-1]
                //that are greater than key, to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
