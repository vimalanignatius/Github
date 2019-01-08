using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            int[] a1 = new int[5];
            int[] a2 = new int[5];


            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {

                a1[i] = int.Parse(Console.ReadLine());
            }
            ReverseArray();

            void ReverseArray()
            {

                for (i = 0, j = a1.Length - 1; i < a1.Length; i++)
                {

                    a2[i] = a1[j];
                    j--;

                }

                Console.WriteLine("Reverse elements : ");
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine(a2[i]);

                }
            }

        }
    }
}
