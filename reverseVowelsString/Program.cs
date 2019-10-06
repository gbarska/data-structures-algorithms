using System.Collections.Generic;
using System;

namespace reverseVowelsString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reverseVowelsString("Hellu"));
        }

        public static string reverseVowelsString(string text){
            var vowelsArr = new char[10]{'a','A','i','I','o','O','u','U','e','E'};
            var reversed = text.ToCharArray();

            HashSet<char> vowels = new HashSet<char>(); 
          
            foreach (var vowel in vowelsArr)
            {
                 vowels.Add(vowel);
            }

            int i =0;
            int j = reversed.Length -1;

            while(i < j){
                
                     while(i < j && !vowels.Contains(reversed[i])){
                         i++;
                    }
                    while(i < j && !vowels.Contains(reversed[j])){
                         j--;
                    }

                    char temp = reversed[i];
                    reversed[i++] = reversed[j];
                    reversed[j--] = temp;
            }  
            
            return new string(reversed);

        }
    }
}
