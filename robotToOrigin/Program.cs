using System;

namespace robotToOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(judgeCircle("LRUD"));
        }

        public static bool judgeCircle(string moves){
            int UD = 0;
            int LR = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                char currentMove = moves[i];
                if (currentMove == 'U'){
                    UD++;
                } else if(currentMove == 'D'){
                    UD--;
                }else if(currentMove == 'L'){
                    LR++;
                }else if(currentMove == 'R'){
                    LR--;
                }

            }

            return UD == 0 && LR == 0;
        }
    }
}
