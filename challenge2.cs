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
			string path = "test.txt"; // this is the path specified for the text file 
			string[] lines = readTextFile(path);
			Dictionary<int, string> inputData = SaveTextFileToDict(lines);
			int[] arr = inputData.Select(x => x.Key).ToArray();
			int limit = 1100; // Change this limit and run app to test with different inputs
			int[] index = Find2ItemsWithLargestSumWithinLimit(arr, limit);
			if (index[0] == 0 && index[1] == 0)
				Console.WriteLine("Not Possible");
			else
			{
				string firstItem = inputData[arr[index[0]]];
				string secondItem = inputData[arr[index[1]]];
				Console.WriteLine(firstItem + " " + arr[index[0]] + " , " + secondItem + " " + arr[index[1]]);

			}
		}

		private static int[] Find2ItemsWithLargestSumWithinLimit(int[] arr, int limit)
		{
			int[] indexOfMaxItems = new int[2];
			int max = 0;
			int i = 0;  //Pointer to First Item
			int j = arr.Length - 1; //Pointer to Last Item

			while (i < j)
			{
				int sum = arr[i] + arr[j];
				if (sum > max && sum <= limit && i != j)
				{
					max = sum;
					indexOfMaxItems[0] = i;
					indexOfMaxItems[1] = j;
					i++;
				}
				else
					j--;
				
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

	// Time Complexity will be O(n^2) if we use brute force method and calculate all possible sums and take out the max.

	// Instead, I am solving it O(n) by maintating two pointers. One is at start and second at end and we go through the array 
	// till the pointers collide and return the indices

	// You can run this by creating new console app, pasting this code in the main CS fle and copying test.txt file with sample input in the same folder


}
