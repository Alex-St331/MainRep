using System;

class Program
{
    static void Main()
    {
        int[] arr = {64, 25, 12, 22, 11};
        SelectionSort(arr);
        Console.WriteLine("Sorted array is: ");
        foreach(var num in arr)
        {
            Console.Write(num + " ");
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
}
