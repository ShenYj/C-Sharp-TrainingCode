using System;

namespace _CSharpTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello C Sharp !");

            int a = 10;
            int b = 23;

            int result = calculate(a, b);
            int[] array = { 2, 256, 6543, 12 };
            result = sum(array);
            Console.WriteLine(result);


            string name = "小桌子";
            int age = 18;

            Console.WriteLine("姓名: " + name + ";\n" + "年龄: " + age);
        }

        /// <summary>
        /// Calculate the specified a and b.
        /// </summary>
        /// <returns>The calculate.</returns>
        /// <param name="a">The alpha component.</param>
        /// <param name="b">The blue component.</param>
        public static int calculate(int a,int b)
        {
            return a + b;
        }

        /// <summary>
        /// Sum the specified arr.
        /// </summary>
        /// <returns>The sum.</returns>
        /// <param name="arr">Arr.</param>
        public static int sum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }




    }
}
