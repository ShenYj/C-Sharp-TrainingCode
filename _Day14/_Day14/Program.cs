using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Day14
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 2, 3, 4, };
            int[] result = TwoSum(arr, 6);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int number1 = 0;
            int number2 = 0;
            for (int i = 0; i < nums.Count() - 1; i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    number1 = nums[j];
                    number2 = nums[i];
                    if (number1 + number2 == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[2];
        }
    }
}
