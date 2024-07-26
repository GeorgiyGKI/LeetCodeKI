using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
	public static class MissingNumber
	{
		public static int MissingNumberHash(int[] nums)
		{
			var hash = new HashSet<int>(nums);

			for (int i = 0; i <= nums.Length; i++)
			{
				if (!hash.Contains(i))
				{
					return i;
				}
			}

			// Этот return никогда не будет выполнен, так как всегда найдется недостающее число
			return -1;
		}

		public static int MissingNumberMath(int[] nums)
		{
			int n = nums.Length;
			int totalSum = n * (n + 1) / 2;
			int arraySum = 0;

			foreach (int num in nums)
			{
				arraySum += num;
			}

			return totalSum - arraySum;
		}
	}
}
