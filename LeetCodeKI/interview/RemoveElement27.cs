using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
    public class RemoveElement27
    {
        public static int RemoveElement(int[] nums, int val)
        {
            //wrong solution, but I like how it works
            int count = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                int indexOfLastElement = 1 + count;
                if (nums[^i] == val)
                {
                    if (nums[^i] == nums[^indexOfLastElement])
                    {
                        count++;
                        continue;
                    }

                    (nums[^i], nums[^indexOfLastElement]) = (nums[^indexOfLastElement], nums[^i]);
                    count++;
                }
            }


            Array.Resize(ref nums, nums.Length - count);

            return count;
        }
    }
}
