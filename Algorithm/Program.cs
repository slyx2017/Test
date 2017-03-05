using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.测试时间方法 TestTime()
            //using (new TestTime())
            //{
            //    Decimal total = 0;
            //    int limit = 300000000;
            //    for (int i = 0; i < limit; i++)
            //    {
            //        total = total + i;
            //    }
            //}

            //2.读取注册表
            //using (RegistryKey keyRun=Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"))
            //{
            //    foreach (string valueName in keyRun.GetValueNames())
            //    {
            //        Console.WriteLine("Name：{0}\tValue：{1}", valueName,keyRun.GetValue(valueName));
            //    }
            //}
            Console.WriteLine("请输入数字的个数：");
            List<int> list = new List<int>();
            Random r = new Random();
            int numCount = Convert.ToInt32(Console.ReadLine());
            string strNum = "";
            for (int i = 0; i < numCount; i++)
            {
                int num = r.Next(1, 100);
                list.Add(num);
                strNum += num + ",";
            }
            strNum = strNum.Substring(0, strNum.Length - 1);
            //3.BubbleSort()
            Console.WriteLine("冒泡排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            //int[] arrNum0 = { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            List<int> arrNum = list;//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum = CommSortHelper.BubbleSort(arrNum);
            }
            ShowSortEnd(arrNum);

            Console.WriteLine("*****************************************************");
            //4.SelectionSort()
            Console.WriteLine("选择排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum1 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum1 = CommSortHelper.SelectionSort(arrNum1);
            }
            ShowSortEnd(arrNum1);
            Console.WriteLine("*****************************************************");
            //5.InsertionSort()
            Console.WriteLine("插入排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum2 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum2 = CommSortHelper.InsertionSort(arrNum2);
            }
            ShowSortEnd(arrNum2);
            Console.WriteLine("*****************************************************");
            //6.ShellSort()
            Console.WriteLine("希尔排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum3 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum3 = CommSortHelper.ShellSort(arrNum3);
            }
            ShowSortEnd(arrNum3);
            Console.WriteLine("*****************************************************");
            //6.ShellSort()
            Console.WriteLine("希尔排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum4 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum4 = CommSortHelper.ShellSorted(arrNum4);
            }
            ShowSortEnd(arrNum4);
            Console.WriteLine("*****************************************************");
            //7.MergeSort()
            Console.WriteLine("归并排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum5 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum5 = CommSortHelper.MergeSort(arrNum5);
            }
            ShowSortEnd(arrNum5);
            Console.WriteLine("*****************************************************");
            //8.快速排序()
            Console.WriteLine("快速排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum6 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum6 = CommSortHelper.QuickSort(arrNum6, 0, arrNum6.Count - 1);
            }
            ShowSortEnd(arrNum6);
            Console.WriteLine("*****************************************************");
            //9.堆排序()
            Console.WriteLine("堆排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum7 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum7 = CommSortHelper.HeapSort(arrNum7);
            }
            ShowSortEnd(arrNum7);
            Console.WriteLine("*****************************************************");
            //10.计数排序()
            Console.WriteLine("计数排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum8 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum8 = CommSortHelper.CountSort(arrNum8);
            }
            ShowSortEnd(arrNum8);
        }

        private static void ShowSortEnd(List<int> arr)
        {
            string sortValue = "";
            for (int j = 0; j < arr.Count; j++)
            {
                sortValue += arr[j].ToString() + ",";
            }
            sortValue = sortValue.Substring(0, sortValue.Length - 1);
            Console.WriteLine("排序后的数字：{0}\t", sortValue);
        }
    }
}
