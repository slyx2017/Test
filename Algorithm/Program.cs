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
            Console.WriteLine("请输入随机生成数字的个数：");
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
            string strName = "要排序的数字";
            strNum = strName + strNum.Substring(0, strNum.Length - 1);
            int count = strNum.Length + strName.Length * 2;
            //3.BubbleSort()
            Console.WriteLine("冒泡排序");
            Console.WriteLine("{0}", strNum);
            //int[] arrNum0 = { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            List<int> arrNum = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum = CommSortHelper.BubbleSort(arrNum);
            }
            ShowSortEnd(arrNum);
            DividingLine(count);
            //4.SelectionSort()
            Console.WriteLine("选择排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum1 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum1 = CommSortHelper.SelectionSort(arrNum1);
            }
            ShowSortEnd(arrNum1);
            DividingLine(count);
            //5.InsertionSort()
            Console.WriteLine("插入排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum2 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum2 = CommSortHelper.InsertionSort(arrNum2);
            }
            ShowSortEnd(arrNum2);
            DividingLine(count);
            //6.ShellSort()
            Console.WriteLine("希尔排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum3 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum3 = CommSortHelper.ShellSort(arrNum3);
            }
            ShowSortEnd(arrNum3);
            DividingLine(count);
            //6.ShellSort()
            Console.WriteLine("希尔排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum4 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum4 = CommSortHelper.ShellSorted(arrNum4);
            }
            ShowSortEnd(arrNum4);
            DividingLine(count);
            //7.MergeSort()
            Console.WriteLine("归并排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum5 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum5 = CommSortHelper.MergeSort(arrNum5);
            }
            ShowSortEnd(arrNum5);
            DividingLine(count);
            //8.快速排序()
            Console.WriteLine("快速排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum6 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum6 = CommSortHelper.QuickSort(arrNum6, 0, arrNum6.Count - 1);
            }
            ShowSortEnd(arrNum6);
            DividingLine(count);
            //9.堆排序()
            Console.WriteLine("堆排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum7 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum7 = CommSortHelper.HeapSort(arrNum7);
            }
            ShowSortEnd(arrNum7);
            DividingLine(count);
            //10.计数排序()
            Console.WriteLine("计数排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum8 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum8 = CommSortHelper.CountSort(arrNum8);
            }
            ShowSortEnd(arrNum8);
            DividingLine(count);
            //10.桶排序()
            Console.WriteLine("桶排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum9 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum9 = CommSortHelper.BucketSort(arrNum9);
            }
            ShowSortEnd(arrNum9);
            DividingLine(count);
            //10.基数排序()
            Console.WriteLine("基数排序");
            Console.WriteLine("{0}", strNum);
            List<int> arrNum10 = new List<int>(list);//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum10 = CommSortHelper.RadixSort(arrNum10.ToArray());
            }
            ShowSortEnd(arrNum10);
        }
        /// <summary>
        /// 分割线
        /// </summary>
        private static void DividingLine(int count)
        {
            string flag = "";
            for (int i = 0; i < count; i++)
            {
                flag += "*";
            }
            Console.WriteLine(flag);
        }

        private static void ShowSortEnd(List<int> arr)
        {
            if (arr.Count <= 0) return;
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
