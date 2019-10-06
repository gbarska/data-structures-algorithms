using System.Linq;
using System.Collections.Generic;
using System;

namespace singleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(singleNumber(new int[] {4,1,2,1,2}));
        }

        public static int singleNumber(int[] nums){
            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numbers.Contains(nums[i]))
                    numbers.Add(nums[i]);
                else {
                    numbers.Remove(nums[i]);
                }
            }

            return numbers.FirstOrDefault();

        }
    }
}
