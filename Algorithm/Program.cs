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
            int numCount =Convert.ToInt32(Console.ReadLine());
            string strNum = "";
            for (int i = 0; i < numCount; i++)
            {
                int num = r.Next(1, 100);
                list.Add(num);
                strNum += num + "," ;
            }
            strNum= strNum.Substring(0, strNum.Length - 1);
            //3.BubbleSort()
            Console.WriteLine("冒泡排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            //int[] arrNum0 = { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            List<int> arrNum = list;//new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum = CommSortHelper.BubbleSort(arrNum);
            }
            string sortValue = "";
            for (int j = 0; j < arrNum.Count; j++)
            {
                sortValue += arrNum[j].ToString() + ",";
            }
            sortValue = sortValue.Substring(0, sortValue.Length - 1);
            Console.WriteLine("排序后的数字：{0}\t", sortValue);

            Console.WriteLine("*****************************************************");
            //4.SelectionSort()
            Console.WriteLine("选择排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum1 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum1 = CommSortHelper.SelectionSort(arrNum1);
            }
            string sortValue1 = "";
            for (int j = 0; j < arrNum1.Count; j++)
            {
                sortValue1 += arrNum1[j].ToString() + ",";
            }
            sortValue1 = sortValue1.Substring(0, sortValue1.Length - 1);
            Console.WriteLine("排序后的数字：{0}\t", sortValue1);

            Console.WriteLine("*****************************************************");
            //5.InsertionSort()
            Console.WriteLine("插入排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum2 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum2 = CommSortHelper.InsertionSort(arrNum2);
            }
            string sortValue2 = "";
            for (int j = 0; j < arrNum2.Count; j++)
            {
                sortValue2 += arrNum2[j].ToString() + ",";
            }
            sortValue2 = sortValue2.Substring(0, sortValue2.Length - 1);
            Console.WriteLine("排序后的数字：{0}\t", sortValue2);

            Console.WriteLine("*****************************************************");
            //6.ShellSort()
            Console.WriteLine("希尔排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum3 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum3 = CommSortHelper.ShellSort(arrNum3);
            }
            string sortValue3 = "";
            for (int j = 0; j < arrNum3.Count; j++)
            {
                sortValue3 += arrNum3[j].ToString() + ",";
            }
            sortValue3 = sortValue3.Substring(0, sortValue3.Length - 1);
            Console.WriteLine("排序后的数字：{0}\t", sortValue3);

            Console.WriteLine("*****************************************************");
            //6.ShellSort()
            Console.WriteLine("希尔排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum4 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum4 = CommSortHelper.ShellSorted(arrNum4);
            }
            string sortValue4 = "";
            for (int j = 0; j < arrNum4.Count; j++)
            {
                sortValue4 += arrNum4[j].ToString() + ",";
            }
            sortValue4 = sortValue4.Substring(0, sortValue4.Length - 1);
            Console.WriteLine("排序后的数字：{0}\t", sortValue4);

            Console.WriteLine("*****************************************************");
            //7.MergeSort()
            Console.WriteLine("归并排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum5 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum5 = CommSortHelper.MergeSort(arrNum5);
            }
            string sortValue5 = "";
            for (int j = 0; j < arrNum5.Count; j++)
            {
                sortValue5 += arrNum5[j].ToString() + ",";
            }
            sortValue5 = sortValue5.Substring(0, sortValue5.Length - 1);
            Console.WriteLine("排序后的数字：{0}\t", sortValue5);

            Console.WriteLine("*****************************************************");
            //8.快速排序()
            Console.WriteLine("快速排序");
            Console.WriteLine("要排序的数字：{0}", strNum);
            List<int> arrNum6 = list;// new List<int>() { 44, 3, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            using (new TestTime())
            {
                arrNum6 = CommSortHelper.QuickSort(arrNum6,0,arrNum6.Count-1);
            }
            string sortValue6 = "";
            for (int j = 0; j < arrNum6.Count; j++)
            {
                sortValue6 += arrNum6[j].ToString() + ",";
            }
            sortValue6 = sortValue6.Substring(0, sortValue6.Length - 1);
            Console.WriteLine("排序后的数字：{0}\t", sortValue6);
        }
    }
}
