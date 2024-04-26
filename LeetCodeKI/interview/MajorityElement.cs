using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
    public class MajorityElement169
    {
        public static int MajorityElement(int[] nums)
        {
            int count = 0;
            int majorityElement = 0;
            foreach (var num in nums)
            {
                if (count == 0)
                {
                    majorityElement = num;
                    count = 1;
                }
                else if (num == majorityElement)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return majorityElement;
        }
    }
}
