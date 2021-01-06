using System;

namespace SquStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string massBegin = "";

             for (int k = 0; k<n; k++)
            {
                massBegin +=  Console.ReadLine();
            }

            string ringer = "";

            for (int i = 0; i < massBegin.Length; i++)
            {
                if(massBegin[i] != ' ' && massBegin[i] != '|') ringer += massBegin[i];
            }

            Console.WriteLine($"{Environment.NewLine}" + ringer);

            

            // for (int j = 0; j < n; j++)
            // {
            //     for (int row = 0; row < n; row++)
            // {
            //     for (int stabl = 0; stabl < n; stabl++)
            //     {
            //         filler[row, stabl] = ;
            //     }
            // }
            // }
        }
    }
}


                                                       
// a b c | d e f
// g h r | l k m
// o p w | z y s
