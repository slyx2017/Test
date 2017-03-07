using System;
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
        /// 7.堆排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> HeapSort(List<int> arr)
        {
            int len = arr.Count;
            //建立大顶堆
            for (int i = len / 2 - 1; i >= 0; i--)
            {
                heapAdjust(arr, i, len);
            }
            for (int i = len - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapAdjust(arr, 0, i);
            }
            return arr;
        }
        /// <summary>
        /// 8.计数排序
        /// </summary>
        /// <param name="arr">待排序的数组</param>
        /// <returns>排序后的结果</returns>
        public static List<int> CountSort(List<int> arr)
        {
            int max = GetMaxValue(arr.ToArray());
            int[] arrResult = new int[arr.Count];
            int[] arrList = new int[max + 1];

            for (int i = 0; i <= max; i++)
            {
                arrList[i] = 0;//初始化计数数组
            }
            //单个元素计数
            for (int i = 0; i < arr.Count; i++)
            {
                arrList[arr[i]] = arrList[arr[i]] + 1;
            }
            //计算小于等于某数的个数
            for (int i = 1; i <= max; i++)
            {
                arrList[i] += arrList[i - 1];
            }
            //得到排序后的结果
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                int numindex = arrList[arr[i]] - 1;
                arrResult[numindex] = arr[i];
                arrList[arr[i]] = arrList[arr[i]] - 1;
            }
            return arrResult.ToList();
        }
        /// <summary>
        /// 9.桶排序
        /// </summary>
        /// <param name="arr">待排序的数组</param>
        /// <returns>返回排序后的结果</returns>
        public static List<int> BucketSort(List<int> arr)
        {
            int len = arr.Count;
            int min = GetMinValue(arr.ToArray());
            int max = GetMaxValue(arr.ToArray());
            int bucketCount = (max - min) / len + 1;//桶的数量
            List<List<int>> bucketList = new List<List<int>>(bucketCount);//创建桶
            for (int i = 0; i < bucketCount; i++)
            {
                bucketList.Add(new List<int>());//初始化桶
            }
            for (int i = 0; i < len; i++)
            {
                int numIndex = (arr[i] - min) / len;
                bucketList[numIndex].Add(arr[i]);
            }
            arr.Clear();
            for (int i = 0; i < bucketList.Count; i++)
            {
                InsertionSort(bucketList[i]);
                for (int j = 0; j < bucketList[i].Count; j++)
                {
                    arr.Add(bucketList[i][j]);
                }
                //ShowPro(bucketList[i], i - 1);
            }
            return arr;
        }
        /// <summary>
        /// 10.基数排序
        /// </summary>
        /// <param name="arr">待排序的数组</param>
        /// <returns>返回排序后的结果</returns>
        public static List<int> RadixSort(int[] arr)
        {
            int len = arr.Length;
            //创建桶
            List<List<int>> arrResult = new List<List<int>>();
            for (int i = 0; i < 10; i++)
            {
                //申请10个桶，用于存放0-9
                arrResult.Add(new List<int>());
            }
            int maxBit = GetMaxBit(arr);
            for (int i = 0; i < maxBit; i++)
            {
                //数据入桶
                for (int j = 0; j < len; j++)
                {
                    int bucket = arr[j]/(int)(Math.Pow(10,i))-arr[j] / (int)(Math.Pow(10, i+1))*10;
                    arrResult[bucket].Add(arr[j]);
                }
                int pos = 0;
                //将桶里数据重新放入数组
                for (int k = 0; k < 10; k++)
                {
                    foreach (int item in arrResult[k])
                    {
                        arr[pos++] = item;
                    }
                }
                //清除桶里所有数据
                for (int k = 0; k < 10; k++)
                {
                    arrResult[k].Clear();
                }
            }
            return arr.ToList();
        }
        /// <summary>
        /// 得到数组arr中最大值的位数
        /// </summary>
        /// <param name="arr">数组</param>
        /// <returns>返回最大值的位数</returns>
        private static int GetMaxBit(int[] arr)
        {
            int maxBit = 0;
            foreach (int ele in arr)
            {
                if (ele > maxBit) maxBit = ele;
            }
            return maxBit.ToString().Length;
        }
        /// <summary>
        /// 得到数组arr中最大值
        /// </summary>
        /// <param name="arr">数组</param>
        /// <returns>返回最大值</returns>
        private static int GetMaxValue(int[] arr)
        {
            int maxValue = int.MinValue;
            foreach (int ele in arr)
            {
                if (ele > maxValue) maxValue = ele;
            }
            return maxValue;
        }
        /// <summary>
        /// 得到数组arr中最小值
        /// </summary>
        /// <param name="arr">数组</param>
        /// <returns>返回最小值</returns>
        private static int GetMinValue(int[] arr)
        {
            int minValue = int.MaxValue;
            foreach (int ele in arr)
            {
                if (ele < minValue) minValue = ele;
            }
            return minValue;
        }
        /// <summary>
        /// 堆筛选 
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="start">起始值针</param>
        /// <param name="end">结束指针</param>
        private static void heapAdjust(List<int> arr, int start, int end)
        {
            int temp = arr[start];
            int child = 2 * start + 1;
            while (child < end)
            {
                if (child + 1 < end && arr[child] < arr[child + 1]) child++;
                if (temp >= arr[child]) break;
                arr[start] = arr[child];
                start = child;
                child = 2 * start + 1;
            }
            arr[start] = temp;
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
                    result.Add(Shift(left));
                }
                else
                {
                    result.Add(Shift(right));
                }
            }
            while (left.Count > 0)
            {
                result.Add(Shift(left));
            }
            while (right.Count > 0)
            {
                result.Add(Shift(right));
            }
            return result;
        }
        /// <summary>
        /// 把数组的第一个元素从其中删除,并返回第一个元素的值。
        /// </summary>
        /// <param name="arr">数组</param>
        /// <returns>返回的值</returns>
        private static int Shift(List<int> arr)
        {
            int value=arr.First();
            arr.RemoveAt(0);
            return value; 
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
            if (arr.Count <= 0) return;
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
