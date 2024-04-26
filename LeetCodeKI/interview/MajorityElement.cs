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
            int flag = 0;
            int result = 0;
            foreach (var num in nums)
            {
                if (flag == 0)
                {
                    result = num;
                    flag = 1;
                }
                else if (num == result)
                {
                    flag++;
                }
                else
                {
                    flag--;
                }
            }
            return result;
        }
    }
}
