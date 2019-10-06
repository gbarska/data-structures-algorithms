using System;

namespace powerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPowerOfTwo(256));
        }

        public static bool isPowerOfTwo(int n) {
            long power = 1;

            while(power < n){            
                power *= 2;    
            }

            return power == n;
        }
    }
}
