using System;
using System.Collections.Generic;
using System.Linq;

public class TreeNode
{
	
	public static void Main(string[] args)
	{
		//var x = new int[] { 1, 2, 3, 4, 5, 6, 7, 2, 2 };
		//var result = GetMajorityElement(x);
		//Console.WriteLine(result);

		//var result = AreAnagram("xyz", "zyx");
		//Console.Write(result);

		//SwapWithoutTempVariable();

		//var result = FibonacciSeries(6);
		//Console.WriteLine(result);
	}

	public static int FibonacciSeries(int n)
	{
		//0,1,1,2,3,5,8,13,21,34
		int previous = 0;
		int current = 0;
		int pprevios = 0;

		for (int x = 1; x <= n;  x++)
		{
			if (x == 1)
			{
				current = 1;
				previous = 0;
			}
			else
			{
				//1
				pprevios = previous;
				previous = current;
				current = pprevios + previous;
				
			}
			
		}

		return current;

	}

	public static void SwapWithoutTempVariable()
	{
		int first, second;
		first = 200;
		second = 100;
		first = first + second;
		second = first - second;
		first = first - second;
		Console.WriteLine(first.ToString());
		Console.WriteLine(second.ToString());
		Console.ReadLine();
	}

	public static bool AreAnagram(string value1, string value2)
	{
		char[] word1 = value1.ToCharArray();
		char[] word2 = value2.ToCharArray();

		Array.Sort(word1);
		Array.Sort(word2);

		var newWord1 = new string(word1);
		var newWord2 = new string(word2);

		if (newWord1 == newWord2)
			return true;
		else
			return false;

	}

	public static int GetMajorityElement(params int[] x)
	{
		int result;
		Dictionary<int, int> d = new Dictionary<int, int>();
		int majority = x.Length / 2;

		//Stores the number of occcurences of each item in the passed array in a dictionary
		foreach (int i in x)
		{
			if (d.ContainsKey(i))
			{
				d[i]++;
				//Checks if element just added is the majority element
				if (d[i] > majority)
				{
					result = i;
					return result;
				}
			}
			else
			{
				d.Add(i, 1);
			}
		}

		//sort dictionary by values
		result = d.OrderByDescending(p => p.Value).FirstOrDefault().Key;

		return result;

	}
}