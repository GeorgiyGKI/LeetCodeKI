using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
	public static class LengthOfLastWord
	{
		public static int LengthOfLastWordMethod(string s)
		{
			int length = 0;
			int i = s.Length - 1;

			// Skip trailing spaces
			while (i >= 0 && s[i] == ' ')
			{
				i--;
			}

			// Count the length of the last word
			while (i >= 0 && s[i] != ' ')
			{
				length++;
				i--;
			}

			return length;
		}
	}
	
}
