using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IntSort intSort = new IntSort(new int[] { 1, 9, 4, 2 });
			intSort.MergeSort();
			foreach (var item in intSort.Array)
			{
				Console.WriteLine(item.ToString());
			}
			Console.ReadKey();
		}

	}
}
