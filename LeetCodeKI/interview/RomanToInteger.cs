using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.interview
{
    public class RomanToInteger
    {
        //private static readonly Dictionary<char, int> dictionary = new Dictionary<char, int>()
        //    {
        //        { 'I', 1},
        //        { 'V', 5},
        //        { 'X', 10},
        //        { 'L', 50},
        //        { 'C', 100},
        //        { 'D', 500},
        //        { 'M', 1000},
        //    };

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>()
                {
                    { 'I', 1},
                    { 'V', 5},
                    { 'X', 10},
                    { 'L', 50},
                    { 'C', 100},
                    { 'D', 500},
                    { 'M', 1000},
                };

            int answer = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var romanNumber = dictionary[s[i]];

                if (i + 1 < s.Length &&
                    romanNumber < dictionary[s[i + 1]])
                {
                    answer += dictionary[s[i + 1]] - romanNumber;
                    i++;
                }
                else
                {
                    answer += romanNumber;
                }
            }

            return answer;
        }
    }
}
