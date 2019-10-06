using System;

namespace New_Folder_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5];

            arr[0] = 3;
            arr[1] = 180;
            arr[2] = 15;
            arr[3] = 12;
            arr[4] = 30;

            Console.WriteLine(generalizedGCD(5, arr));
        }

        public static int generalizedGCD(int num, int[] arr){
           
         var result = arr[0];

           for(int i = 0; i < num; i++){
               result = gcd(result, arr[i]);
           }
        
        return result;
        }


        public static int gcd(int n1, int n2){
            if(n2 == 0){
                return n1;
            }

            return gcd(n2, n1%n2);
        }

        public static int teste(int num,int[] arr){
             var gcd = 1;    
            int i = 0;
            
            if (arr.Length != num){
                return 1;
            }


            while(true) {
                if ( arr[i] % gcd != 0){
                    gcd = gcd == 1 ? 1 : gcd - 1;
                    break;
                }
                if(i == num-1){
                  gcd++;
                  i = 0;
                }
                 i++;             
            }

            return gcd;
        }
       
       
    }
}
