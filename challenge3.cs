using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "10X10X0";
            char[] chars = str.ToCharArray();
            ReplaceX(chars, 0);
            Console.WriteLine("Program Finished");
        }


        private static void ReplaceX(char[] a, int i)
        {
            if (i >= a.Length)
            {
                Console.WriteLine(a);
                return;
            }
          
            if (a[i] == 'X')
            {
                a[i] = '0';
                ReplaceX(a, i + 1);
                a[i] = '1';
                ReplaceX(a, i + 1);
                a[i] = 'X';
            }
            else ReplaceX(a, i + 1);
        }

    }

    // Time Complexity will be O(n)

    // You can run this online at https://codepad.remoteinterview.io/NQBTQRIUSE




}
