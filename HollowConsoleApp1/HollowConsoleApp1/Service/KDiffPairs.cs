using System;

namespace HollowConsoleApp1.Service
{
    /// <summary>
    /// Leetcode Question:
    /// https://leetcode.com/problems/k-diff-pairs-in-an-array/solutions/
    /// https://www.youtube.com/watch?v=4olB4YAts9E
    /// </summary>
    public class KDiffPairs
	{
		public static void URLifyStringWrapper()
        {
			Console.WriteLine(URLifyString(null));
			Console.WriteLine(URLifyString(""));
			Console.WriteLine(URLifyString("John Smith"));
			Console.WriteLine(URLifyString(" John Smith  "));
			Console.WriteLine(URLifyString("John   Smith  "));
			Console.WriteLine(URLifyString("John   "));
			Console.WriteLine(URLifyString("   Smith"));
			Console.WriteLine(URLifyString("www.test.com/I Love Coding  "));
        }

		private static string URLifyString(string stringWithSpaces)
		{
			/*if (stringWithSpaces == null)
			{
				return stringWithSpaces;
			}
			else
			{
				var trimmedStringWithSpaces = stringWithSpaces.Trim();
				return trimmedStringWithSpaces.Replace(" ", "%20");
			}*/

			return stringWithSpaces?.Trim().Replace(" ", "%20");
		}
	}
}
