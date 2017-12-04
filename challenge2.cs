using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt"; // this is the path specified
            string[] lines = readTextFile(path);
            Dictionary<int, string> inputData = SaveTextFileToDict(lines);
            int[] arr = inputData.Select(x => x.Key).ToArray();
            int limit = 10000; // Change this limit and run app to test with different inputs
            int[] index = Find2ItemsWithLargestSumWithinLimit(arr, limit);
            if (index[0] == 0 && index[1] == 0)
                Console.WriteLine("Not Possible");
            else
            {
                string firstItem = inputData[arr[index[0]]];
                string secondItem = inputData[arr[index[1]]];
                Console.WriteLine(secondItem + " " + arr[index[1]] + " , " + firstItem + " " + arr[index[0]]);

            }
        }

        private static int[] Find2ItemsWithLargestSumWithinLimit(int[] arr, int limit)
        {
            int[] indexOfMaxItems = new int[2];
            int max = 0;
            int lastItemIndex = arr.Length - 1;

            for (int i = lastItemIndex; i >= 0; i--)
            {
                for (int j = lastItemIndex - 1; j >= 0; j--)
                {
                    int sum = arr[i] + arr[j];
                    if (sum > max && sum <= limit && i != j)
                    {
                        max = sum;
                        indexOfMaxItems[0] = i;
                        indexOfMaxItems[1] = j;
                    }
                }
            }

            return indexOfMaxItems;
        }

        private static string[] readTextFile(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        private static Dictionary<int, string> SaveTextFileToDict(string[] lines)
        {
            Dictionary<int, string> inputData = new Dictionary<int, string>();
            foreach (var line in lines)
            {
                string[] words = line.Split(',');
                string item = words[0];
                int price = Int32.Parse(words[1].Substring(1, words[1].Length - 1));
                inputData.Add(price, item);
            }
            return inputData;
        }

    }

    // Time Complexity will be O(n^2) as it is brute force method. 

    // You can run this by creating new console app and copying test.txt file with sample input in the same folder




}
