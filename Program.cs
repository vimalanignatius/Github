using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] n = new int[9] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            for(int j = 1; j <=20; j++)
            {
               Console.WriteLine(" ");
                
                for (int i = 2; i <= 10; i++)
                {
                    int c = i*j;
                    Console.Write("\t");
                 

                    Console.Write( i+ " * " + j + " = " + c);
                }
            }

        }
    }
}
