using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
    public class MergeSortedArray88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //not my solution
            if (n == 0) return;
            int len1 = nums1.Length;
            int end_idx = len1 - 1;
            while (n > 0 && m > 0)
            {
                if (nums2[n - 1] >= nums1[m - 1])
                {
                    nums1[end_idx] = nums2[n - 1];
                    n--;
                }
                else
                {
                    nums1[end_idx] = nums1[m - 1];
                    m--;
                }
                end_idx--;
            }
            while (n > 0)
            {
                nums1[end_idx] = nums2[n - 1];
                n--;
                end_idx--;
            }

            //MY solution)0)
            var newSize = m + n;
            Array.Resize(ref nums1, newSize);
            Array.Copy(nums2, 0, nums1, m, n);
            Array.Sort(nums1);
        }
    }
}

