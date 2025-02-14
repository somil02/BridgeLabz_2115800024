﻿using System;

public class MergeSort
{
    public void merge(int[] arr, int start, int end)
    {
        int mid = start + (end - start) / 2;
        int n1 = mid - start + 1;
        int n2 = end - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        for (int i = 0; i < n1; i++)
        {
            L[i] = arr[start + i];
        }
        for (int j = 0; j < n2; j++)
        {
            R[j] = arr[mid + 1 + j];
        }
        int k = start;
        int i1 = 0;
        int i2 = 0;
        while (i1 < n1 && i2 < n2)
        {
            if (L[i1] <= R[i2])
            {
                arr[k] = L[i1];
                i1++;
            }
            else
            {
                arr[k] = R[i2];
                i2++;
            }
            k++;
        }
        while (i1 < n1)
        {
            arr[k] = L[i1];
            i1++;
            k++;
        }
        while (i2 < n2)
        {
            arr[k] = R[i2];
            i2++;
            k++;
        }
    }
    public void mergeSort(int[] arr, int start, int end)
    {
        if (start >= end)
        {
            return;
        }
        int mid = start + (end - start) / 2;
        mergeSort(arr, start, mid);
        mergeSort(arr, mid + 1, end);
        merge(arr, start, end);
    }

    public static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        int n = arr.Length;
        MergeSort ob = new MergeSort();
        ob.mergeSort(arr, 0, n - 1);
        Console.WriteLine("Sorted array");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
