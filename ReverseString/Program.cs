using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
	class Program
	{
		static void Main(string[] args)
		{
			string temp = ReverseString("Karan");
		}

		static string ReverseString(string input)
		{
			string s = input;
			if (input.Trim().Length > 1)
			{
				char[] temp = input.ToCharArray();
				int left = 0;
				int right = input.Length - 1;
				while (left < right)
				{
					char t = temp[left];
					temp[left] = temp[right];
					temp[right] = t;
					left = left + 1;
					right = right - 1;
				}
				s = new string(temp);
			}
			return s;
		}
	}
}
