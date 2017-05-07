using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapVowels
{
	class Program
	{
		static char[] Vowels = new char[] { 'a','e','i','o','u','A','E','I','O','U'};
		static void Main(string[] args)
		{
			string result = SwapVowels("UNITED");
				}

		static string SwapVowels(string s)
		{
			string result = s;
			if (s.Trim().Length > 1)
			{
				char[] temp = s.ToCharArray();
				int left = 0;
				int right = s.Length - 1;
				while (left < right)
				{
					while (!Vowels.Contains(temp[left]) && left <right)
					{
						left = left + 1;
					}
					while(!Vowels.Contains(temp[right]) && right > left)
					{
						right = right - 1;
					}
					if (left > right) break;
					Swap(temp, left, right);
					left = left + 1;
					right = right - 1;
				}

				result = new string(temp);
			}
			return result;

		}
		static void Swap(char[] temp, int left, int right)
		{
			char t = temp[left];
			temp[left] = temp[right];
			temp[right] = t;
		}
	}
}
