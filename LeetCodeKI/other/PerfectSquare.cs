using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.other
{
	public static class PerfectSquare
	{
		public static bool IsPerfectSquare(int num)
		{
			if (num == 1)
				return true;

			long l = 1;
			long r = num;

			while (l <= r)
			{
				long mid = (l + r) / 2;
				long answer = mid * mid;
				if (answer == num)
				{
					return true;
				}
				if (answer < num)
				{
					l = mid + 1;
				}
				else
				{
					r = mid - 1;
				}
			}
			return false;
		}
	}
}
