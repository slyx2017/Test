﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class CommSortHelper
    {
        /// <summary>
        /// 1.冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> BubbleSort(List<int> arr)
        {
            int len = arr.Count;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j + 1, j);
                    }
                }
                //ShowPro(arr, i);
            }
            return arr;
        }
        /// <summary>
        /// 2.选择排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> SelectionSort(List<int> arr)
        {
            int len = arr.Count;
            int minIndex;
            for (int i = 0; i < len - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(arr, i, minIndex);
                //ShowPro(arr, i);
            }
            return arr;
        }
        /// <summary>
        /// 3.插入排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> InsertionSort(List<int> arr)
        {
            int len = arr.Count;
            int perIndex, current;
            for (int i = 1; i < len; i++)
            {
                perIndex = i - 1;
                current = arr[i];
                while (perIndex >= 0 && arr[perIndex] > current)
                {
                    arr[perIndex + 1] = arr[perIndex];
                    perIndex--;
                }
                arr[perIndex + 1] = current;
                //ShowPro(arr, i);
            }
            return arr;
        }
        /// <summary>
        /// 4.希尔排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> ShellSort(List<int> arr)
        {
            int d = arr.Count / 2;
            while (d >= 1)
            {
                ShellInsert(arr, d);
                //ShowPro(arr, d - 1);
                d /= 2;
            }
            return arr;
        }
        private static void ShellInsert(List<int> arr, int d)
        {
            int len = arr.Count;
            for (int i = d; i < len; i++)
            {
                int j = i - d;
                int temp = arr[i];
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + d] = arr[j];
                    j -= d;
                }
                arr[j + d] = temp;
            }
        }
        /// <summary>
        /// 4.1希尔排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> ShellSorted(List<int> arr)
        {
            int len = arr.Count,
                temp,
                gap = 1;
            while (gap < len / 3)
            {
                gap = gap * 3 + 1;
            }
            for (; gap > 0;)
            {
                for (int i = gap; i < len; i++)
                {
                    int j = i - gap;
                    temp = arr[i];
                    for (; j >= 0 && arr[j] > temp;)
                    {
                        arr[j + gap] = arr[j];
                        j -= gap;
                    }
                    arr[j + gap] = temp;
                }
                //ShowPro(arr, gap - 1);
                gap = gap / 3;
            }
            return arr;
        }
        /// <summary>
        /// 5.归并排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> MergeSort(List<int> arr)
        {
            int len = arr.Count;
            if (len < 2)
            {
                return arr;
            }
            int middle = len / 2;
            List<int> left = arr.GetRange(0, middle);
            List<int> right = arr.GetRange(middle, len - middle);
            List<int> result = MergeArray(MergeSort(left), MergeSort(right));
            //ShowPro(result, middle);
            return result;
        }
        /// <summary>
        /// 6.快速排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static List<int> QuickSort(List<int> arr, int left, int right)
        {
            int partionIndex;//基准值
            if (left < right)
            {
                partionIndex = Partition(arr, left, right);
                QuickSort(arr, left, partionIndex - 1);
                QuickSort(arr, partionIndex + 1, right);
                //ShowPro(arr, partionIndex);
            }
            return arr;
        }
        /// <summary>
        /// 合并两个数组
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static List<int> MergeArray(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }
            while (left.Count > 0)
            {
                result.Add(left.First());
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                result.Add(right.First());
                right.RemoveAt(0);
            }
            return result;
        }
        /// <summary>
        /// 快速排序分区操作
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static int Partition(List<int> arr, int left, int right)
        {
            int pivot = left,
                index = pivot + 1;
            for (int i = index; i <= right; i++)
            {
                if (arr[i] < arr[pivot])
                {
                    Swap(arr, i, index);
                    index++;
                }
            }
            Swap(arr, pivot, index - 1);
            return index - 1;
        }
        /// <summary>
        /// 交换数值
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i">被交换值的索引</param>
        /// <param name="j">要交换值的索引</param>
        private static void Swap(List<int> arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        /// <summary>
        /// 打印排序过程
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        private static void ShowPro(List<int> arr, int index)
        {
            string sortValue = "";
            for (int j = 0; j < arr.Count; j++)
            {
                sortValue += arr[j].ToString() + ",";
            }
            sortValue = sortValue.Substring(0, sortValue.Length - 1);
            Console.WriteLine("index={0},value={1}", index + 1, sortValue);
        }
    }
}
