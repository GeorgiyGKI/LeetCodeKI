using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
	public static class ValidAnagram
	{
		public static bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length)
			{
				return false;
			}

			var dictionaryS = new Dictionary<char, int>();

			for (int i = 0; i < s.Length; i++)
			{
				if (dictionaryS.ContainsKey(s[i]))
				{
					dictionaryS[s[i]]++;
				}
				else
				{
					dictionaryS.Add(s[i], 1);
				}
			}

			for (int i = 0; i < t.Length; i++)
			{
				if (!dictionaryS.ContainsKey(t[i]) || dictionaryS[t[i]] == 0)
				{
					return false;
				}

				dictionaryS[s[i]]--;
			}

			return true;
		}
	}
}
