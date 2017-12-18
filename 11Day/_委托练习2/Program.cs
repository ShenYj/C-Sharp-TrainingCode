using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _委托练习2
{
    class Program
    {
        private delegate void DGetMax(int[] list, ref int maxNumber);
        private delegate void DGetMaxObject(object[] objectList, ref object max);

        static void Main(string[] args)
        {
            int[] array = { 24, 654, 76, 132, 89, 28 };
            object[] array1 = { "123", "65436", "7654322"};
            DGetMaxObject objectGetMax = (object[] objectList, ref object theMax) => {
                if (objectList.First() is int)
                {
                    int maxNumber = (int)objectList.First();
                    for (int i = 0; i < objectList.Length; i++)
                    {
                        if (i == 0) continue;
                        if (maxNumber < (int)objectList[i]) maxNumber = (int)objectList[i];
                    }
                    Console.WriteLine(maxNumber);
                }
                else if (objectList.First() is string)
                {
                    string maxLengthString = (string)objectList.First();
                    for (int i = 0; i < objectList.Length; i++)
                    {
                        if (i == 0) continue;
                        string currentString = (string)objectList[i];
                        if (maxLengthString.Length < currentString.Length) maxLengthString = currentString;

                    }
                    Console.WriteLine(maxLengthString);
                }
            };

            //DGetMaxObject objectGetMax = delegate(object[] objectList, ref object theMax){
            //    if (objectList.First() is int)
            //    {
            //        int maxNumber = (int)objectList.First();
            //        for (int i = 0; i < objectList.Length; i++)
            //        {
            //            if (i == 0) continue;
            //            if (maxNumber < (int)objectList[i]) maxNumber = (int)objectList[i];
            //        }
            //        Console.WriteLine(maxNumber);
            //    }
            //    else if (objectList.First() is string)
            //    {
            //        string maxLengthString = (string)objectList.First();
            //        for (int i = 0; i < objectList.Length; i++)
            //        {
            //            if (i == 0) continue;
            //            string currentString = (string)objectList[i];
            //            if (maxLengthString.Length < currentString.Length) maxLengthString = currentString;
                        
            //        }
            //        Console.WriteLine(maxLengthString);
            //    }
            //};

            object value = null;
            object[] objArray = new object[array.Length];
            array.CopyTo(objArray, 0);


            objectGetMax(array1, ref value);

            Console.ReadKey();
        }


        public static void Test1()
        {
            int[] array = { 24, 654, 76, 132, 89, 28 };
            DGetMax getMax1 = delegate (int[] arr, ref int maxNumber) {
                int number = arr.First();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (number < arr[i]) number = arr[i];
                }
                maxNumber = number;
            };

            int max = 0;
            getMax1(array, ref max);

            Console.WriteLine(max);
        }

        public static void Test2()
        {
            int[] array = { 24, 654, 76, 132, 89, 28 };
            DGetMax getMax1 = (int[] arr, ref int maxNumber) => {
                int number = arr.First();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (number < arr[i]) number = arr[i];
                }
                maxNumber = number;
            };

            int max = 0;
            getMax1(array, ref max);

            Console.WriteLine(max);
        }
    }
}
