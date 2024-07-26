using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
	public static class EasyInOneFile
	{
		public static bool CanConstruct(string ransomNote, string magazine)
		{
			var dictionary = new Dictionary<char, int>();

			for (int i = 0; i < ransomNote.Length; i++)
			{
				var letter = ransomNote[i];
				if (dictionary.ContainsKey(letter))
				{
					dictionary[letter]++;
				}
				else
				{
					dictionary.Add(letter, 1);
				}
				
			}

			for (int i = 0; i < magazine.Length; i++)
			{
				var letter = magazine[i];
				if (dictionary.ContainsKey(letter))
				{
					dictionary[letter]--;
				}
			}

			foreach (char letter in dictionary.Keys)
			{
				if (dictionary[letter] > 0)
					return false;
			}

			return true;
		}

		public static int SearchInsert(int[] nums, int target)
		{
			var left = 0;
			var right = nums.Length - 1;
			
			while (left <= right)
			{
				var mid = (left + right) / 2;
			
				var number = nums[mid];

                if (number == target)
                {
					return mid;
                }
				else if (number > target)
                {
                    right = mid - 1;
                }
				else
				{
					left = mid + 1;
				}
            }

			return left;
		}
	}
}
