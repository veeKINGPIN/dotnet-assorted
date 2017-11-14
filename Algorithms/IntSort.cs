using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class IntSort
	{
		private int[] array;

		public IntSort(int[] array)
		{
			this.array = array;
		}

		public int[] Array
		{
			get
			{
				return this.array;
			}
		}

		public void MergeSort()
		{
			int[] helper = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				helper[i] = 99999; //initialize the helper array
			}

			MergeSort(array, helper, 0, array.Length - 1);
		}

		private void MergeSort(int[] array, int[] helper, int low, int high)
		{
			if (low < high)
			{
				int middle = (low + high) / 2;
				MergeSort(array, helper, low, middle);
				MergeSort(array, helper, middle + 1, high);
				Merge(array, helper, low, middle, high);
			}
		}

		private void Merge(int[] array, int[] helper, int low, int middle, int high)
		{
			//Copy all the elements to the helper array
			for (int i = low; i <= high; i++)
			{
				helper[i] = array[i];
			}

			int helperLeft = low;
			int helperRight = middle + 1;
			int arrayCounter = low;

			while (helperLeft <= middle && helperRight <= high)
			{
				if (helper[helperLeft] <= helper[helperRight])
				{
					array[arrayCounter] = helper[helperLeft];
					helperLeft++;
				}
				else
				{
					array[arrayCounter] = helper[helperRight];
					helperRight++;
				}
				arrayCounter++;
			}

			//Copy the rest to the main array
			//int remaining = middle - helperLeft;
			for (int i = helperLeft; i <= middle; i++)
			{
				array[arrayCounter] = helper[i];
				arrayCounter++;
			}
		}

		public void QuickSort(int left, int right)
		{
			int index = QuickSort_Partition(left, right);

			if (left < index - 1)
			{
				QuickSort(left, index - 1);
			}
			if (index < right)
			{
				QuickSort(index, right);
			}
		}

		private int QuickSort_Partition(int left, int right)
		{
			//Assign the left as pivot
			int pivot = left;

			while (left <= right)
			{
				while (array[left] < array[pivot])
				{
					left++;
				}

				while (array[right] > array[pivot])
				{
					right--;
				}

				if (left <= right)
				{
					int temp = array[left];
					array[left] = array[right];
					array[right] = temp;

					left++;
					right--;
				}
			}

			return left;
		}
	}
}
