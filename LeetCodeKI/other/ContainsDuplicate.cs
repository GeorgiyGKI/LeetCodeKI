`using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeKI.other
{
	public static class ContainsDuplicate
	{
		public static bool ContainsDuplicateMethod(int[] nums)
		{
			return nums.Length != new HashSet<int>(nums).Count;
		}
	}
}
