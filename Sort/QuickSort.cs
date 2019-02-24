using System;
namespace OO_Design_Patterns.Sort
{
    public class QuickSort : ISort
    {
        private int[] arr;
        public QuickSort(int[] arr)
        {
            this.arr = arr;
        }
        public void AscendSort()
        {
            myAscendSort(0, arr.Length - 1);
        }

        public void Display()
        {
            Console.WriteLine("Sorted array");
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write("  ");
            }
        }

        private void myAscendSort(int left, int right)
        {
            if (left > right)
            {
                return;
            }
            // init
            int i, j, t, temp;
            temp = arr[left];
            i = left;
            j = right;

            //swap
            while (i != j)
            {
                while (i < j && arr[j] >= temp)
                {
                    j--;
                }
                while (i < j && arr[i] <= temp)
                {
                    i++;
                }
                if (i < j)
                {
                    t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                }
            }
            arr[left] = arr[i];
            arr[i] = temp;
            myAscendSort(left, i - 1);
            myAscendSort(i + 1, right);
        }
    }
}