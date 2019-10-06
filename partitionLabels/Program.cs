using System;
using System.Collections.Generic;

namespace partitionLabels
{
    class Program
    {
        static void Main(string[] args)
        {
           foreach (var item in partitionLabels("ababcbacadefegdehijhklij"))
           {
               Console.WriteLine(item);
           }
        }

        public static List<int> partitionLabels(string s){
            List<int> partitionsLenghts = new List<int>();
            int[] lastIndexes = new int[26];

            for (int l = 0; l < s.Length; l++)
            {
                lastIndexes[s[l] - 'a'] = l;
            }

            int i = 0;
            while(i < s.Length){
                int end = lastIndexes[s[i] - 'a'];
                int j = i+1;

                while(j!= end){
                    end = Math.Max(end, lastIndexes[s[j++] - 'a']);
                }

                partitionsLenghts.Add(j - i + 1);
                i = j +1;
            }

        return partitionsLenghts;
        }
    }
}
