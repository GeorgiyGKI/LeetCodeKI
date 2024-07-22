using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.other
{
	public static class AddDigits
	{
		public static int AddDigitsMethod(int num)
		{
			if (num >= 10) 
			{
				var answer = 0;
				while (num > 0)
				{
					var number = num % 10;
					answer += number;
					num = (num - number) / 10;
				}
				return AddDigitsMethod(answer);
			}
            else
            {
				return num;
            }
		}
	}
}
