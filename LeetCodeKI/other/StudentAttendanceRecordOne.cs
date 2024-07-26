using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKI.other
{
	internal class StudentAttendanceRecordOne
	{
		public bool CheckRecord(string s)
		{
			var L_count = 0;
			var A_count = 0;

			foreach (var letter in s)
			{
				if (letter == 'A')
				{
					A_count++;
					if (A_count == 2)
						return false;
				}

				if (letter == 'L')
				{
					L_count++;
					if(L_count >2) 
						return false;
				}
				else
				{
					L_count = 0;
				}
					
			}
		    return true;
		}
	}
}
