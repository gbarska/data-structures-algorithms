using System;

namespace New_Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[8];
            input[0] = 1;
            input[2] = 0;
             input[1] = 0;
              input[3] = 0;
               input[4] = 0;
                input[5] = 1;
                 input[6] = 0;
                  input[7] = 0;

            var array = cellCompete(input,1);

            foreach (var item in array){
                Console.WriteLine(item);
            }

          input[0] = 1;
            input[2] = 1;
             input[1] = 1;
              input[3] = 0;
               input[4] = 1;
                input[5] = 1;
                 input[6] = 1;
                  input[7] = 1;

          array = cellCompete(input,2);

              Console.WriteLine("second: ");        

             foreach (var item in array){
                Console.WriteLine(item);
            }
        }

        public static int[] cellCompete(int[] states, int days){
            int[] lastStates = states;
            int[] nextStates = new int[8];

            for(int n = 0 ; n < days; n++){
                    for(int i=0; i<8 ; i++){
                        if (i == 0 ){
                            nextStates[i] = lastStates[i+1] == 0 ? 0 : 1;
                        }                     
                        else if(i == 7){
                             nextStates[i] = lastStates[6] == 0 ? 0 : 1;
                        }
                        else{
                            if(lastStates[i-1] == lastStates[i+1]){
                                nextStates[i] = 0;
                            }
                            else{
                                 nextStates[i] = 1;
                            }
                        }

                      }
                nextStates.CopyTo(lastStates,0);
                      
            }     

            return nextStates;
        }
    }
}
