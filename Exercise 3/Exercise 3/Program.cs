using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1234));
            Console.WriteLine(Divide(36));
            Console.WriteLine(Count(123465));
            OddEvenCount(1234);
            Console.WriteLine(Armstrong(153));
            Console.WriteLine(GetFirstNumber(864123));
            Console.WriteLine(GetLastNumber(1234568));
            Console.WriteLine(SameFirstLastDigit(1211));
            Console.WriteLine(Palindrome(1221));
            Console.WriteLine(SumOfPrimeNumbers(20));
            Console.WriteLine(PalindromeLength(123));
            Console.WriteLine(SumOfPerfectSquare(20));
            Console.WriteLine(SumOfOddNumbers(10));
        }
        public static int Reverse(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            return rev;
        }
        public static bool Divide(int N)
        {
            // int b;
            bool flag = true;
            while (N != 0)
            {

                int x = N % 10;
                N = N / 10;
                if (N % x != 0)
                {
                    flag = false;
                    break;
                }


            }
            return flag;

        }

        public static int Count(int n)
        {
            int count = (int)(Math.Log10(n) + 1);
            Reverse(n);
            return count;
        }
        public static void OddEvenCount(int n)
        {
            int count = 0;
            int count1 = 0;
            //int OddCount = 0;
            while (n != 0)
            {
                int rem = n % 10;

                if (rem % 2 == 0)
                {
                    count++;


                }
                else
                {
                    count1++;

                }
                n = n / 10;
                Console.WriteLine(count);
                Console.WriteLine(count1);
            }
        }
        public static bool Armstrong(int n)
        {
            int rem;
            // int temp;
            double sum = 0;
            int count;
            count = (int)(Math.Log10(n) + 1);
            int temp = n;
            bool flag = true;
            while (n != 0)
            {
                rem = n % 10;



                sum = sum + (Math.Pow(rem, count));
                n = n / 10;
            }
            if (sum == temp)
            {
                return flag;
            }
            else
            {
                return false;
            }

        }

        public static int GetFirstNumber(int n)
        {
            while (n > 10)
            {
                // int rem = n % 10;
                n = n / 10;
            }
            return n;

        }
        public static int GetLastNumber(int n)
        {
            n = n % 10;
            return n;
        }
        public static bool SameFirstLastDigit(int n)
        {
            bool flag = true;
            if (GetFirstNumber(n) == GetLastNumber(n))
            {
                return flag;
            }
            else
            {
                return false;
            }
        }
        public static bool Palindrome(int n)
        {
            bool flag = true;
            if (Reverse(n) == n)
            {
                return flag;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPrime(int n)
        {
            int i;
            int count = 0;
            bool flag = true;
            if (n <= 1)
            {
                return false;
            }
            if (n == 2)
            {
                count++;
                return true;

            }
            i = 2;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    flag = false;
                }
                i++;
            }
            //for (int i = 2; i <= Math.Sqrt(n); i++)
            //{
            //    if (n % i == 0)
            //    {
            //        flag = false;
            //    }


            //}
            return flag;
        }

        public static int SumOfPrimeNumbers(int n)
        {
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    sum = sum + i;
                }

            }
            return sum;
        }
        public static bool PalindromeLength(int n)
        {
            bool flag = true;
            Palindrome(n);
            if (n % 2 == 0)
            {
                return flag;
            }
            else
            {
                return false;
            }

        }
        public static bool IsPerfectSquare(double n)
        {
            bool flag = true;
            double x = Math.Sqrt(n);
            double y = Math.Round(x);
            if (x - y == 0)
            {
                return flag;
            }
            else
            {
                return false;
            }
        }
        public static int SumOfPerfectSquare(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (IsPerfectSquare(i))
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        public static bool IsOdd(int n)
        {
            bool flag = true;
            if (n % 2 != 0)
            {
                return flag;
            }
            return false;
        }
        public static int SumOfOddNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i = i + 2)
            {
                if (IsOdd(i))
                {
                    sum = sum + i;
                }

            }
            return sum;
        }


    }
}





