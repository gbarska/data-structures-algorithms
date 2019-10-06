using System.Data;
using System.Linq;
using System.Collections.Generic;
using System;

namespace firstUniqueCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(firstUniqueChar("leetcode"));
        }

        public static int firstUniqueChar(string s){
            Dictionary<char, int> map = new Dictionary<char, int>();

            for(int i =0 ; i < s.Length; i++){
                var currentChar = s[i];

                if(!map.ContainsKey(currentChar)){
                    map.Add(currentChar,i);
                }
                else {
                    map[currentChar] = -1;
                }
            }

            int min = int.MaxValue;
            foreach(char c in map.Keys){
                if (map.GetValueOrDefault(c) > -1 && map.GetValueOrDefault(c) < min)
                min = map.GetValueOrDefault(c);
            }

        return min == int.MaxValue ? -1 : min;

        }
    }
}
