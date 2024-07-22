using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.other
{
	public static class MoveZeroes
	{
		public static void MoveZeroesMethod(int[] nums)
		{
			var pointer = 0;
			for (int i = 0; i < nums.Length; i++) {
				if (nums[i] != 0)
				{
					(nums[i], nums[pointer]) = (nums[pointer], nums[i]);
					pointer++;
				}
			}
		}
	}
}
