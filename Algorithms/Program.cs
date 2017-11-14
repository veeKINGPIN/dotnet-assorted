using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IntSort intSort = new IntSort(new int[] { 1, 9, 4, 2, 5, 12, 8, 2, 6, -1, 7, -324, 8, 2, 4, -1324, 77, 22, 5 });
			//intSort.MergeSort();
			intSort.QuickSort(0, intSort.Array.Length - 1);
			foreach (var item in intSort.Array)
			{
				Console.WriteLine(item.ToString());
			}
			Console.ReadKey();
		}

	}
}
