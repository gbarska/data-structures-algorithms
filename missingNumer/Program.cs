using System.Collections.Generic;
using System;

namespace missingNumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(missingNumer(new int[6] {0,1,2,3,4,6}));
        }

        public static int missingNumerExtraMemory(int[] nums){
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(!set.Contains(i))
                    return i;
            }
            return -1;
        }

        public static int missingNumer(int[] nums){
            int sum=0;
            foreach (var number in nums)
            {
                sum += number;
            }

            int n = nums.Length + 1;
            return(n*(n-1)/2)-sum;

        }
    }
}
