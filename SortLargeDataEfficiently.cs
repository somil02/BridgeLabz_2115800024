using System;
using System.Diagnostics;

class SortLargeDataEfficiently
{
    static void Main(string[] args)
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        Random randomGenerator = new Random();
        foreach (int dataSize in datasetSizes)
        {
            int[] originalArray = GenerateRandomArray(dataSize);
            int[] bubbleSortArray = (int[])originalArray.Clone();
            int[] mergeSortArray = (int[])originalArray.Clone();
            int[] quickSortArray = (int[])originalArray.Clone();

            Console.WriteLine($"Sorting {dataSize} elements:");

            // Bubble Sort
            Stopwatch timer = Stopwatch.StartNew();
            BubbleSort(bubbleSortArray);
            timer.Stop();
            Console.WriteLine($"Bubble Sort: {timer.ElapsedMilliseconds}ms");

            // Merge Sort
            timer.Restart();
            MergeSort(mergeSortArray, 0, mergeSortArray.Length - 1);
            timer.Stop();
            Console.WriteLine($"Merge Sort: {timer.ElapsedMilliseconds}ms");

            // Quick Sort
            timer.Restart();
            QuickSort(quickSortArray, 0, quickSortArray.Length - 1);
            timer.Stop();
            Console.WriteLine($"Quick Sort: {timer.ElapsedMilliseconds}ms");
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random randomGenerator = new Random();
        int[] randomArray = new int[size];
        for (int index = 0; index < size; index++)
        {
            randomArray[index] = randomGenerator.Next(0, 1000000000);
        }
        return randomArray;
    }

    static void BubbleSort(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        int leftSize = middle - left + 1;
        int rightSize = right - middle;

        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        Array.Copy(array, left, leftArray, 0, leftSize);
        Array.Copy(array, middle + 1, rightArray, 0, rightSize);

        int leftIndex = 0, rightIndex = 0, mergedIndex = left;
        while (leftIndex < leftSize && rightIndex < rightSize)
        {
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                array[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        while (leftIndex < leftSize)
        {
            array[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        while (rightIndex < rightSize)
        {
            array[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int smallerElementIndex = (low - 1);
        for (int currentIndex = low; currentIndex < high; currentIndex++)
        {
            if (array[currentIndex] < pivot)
            {
                smallerElementIndex++;
                int temp = array[smallerElementIndex];
                array[smallerElementIndex] = array[currentIndex];
                array[currentIndex] = temp;
            }
        }
        int tempPivot = array[smallerElementIndex + 1];
        array[smallerElementIndex + 1] = array[high];
        array[high] = tempPivot;
        return smallerElementIndex + 1;
    }
}
