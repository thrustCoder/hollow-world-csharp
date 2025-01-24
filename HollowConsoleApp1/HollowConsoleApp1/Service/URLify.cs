using System;

namespace HollowConsoleApp1.Service
{
	/// <summary>
	/// Gayle Laakmann's Cracking the Coding Interview Question:
	/// URLify: Write method to replace all spaces in a string with ‘%20’. 
	/// You may assume that the string has sufficient space at the end to hold the additional characters 
	/// and that you are given the “true” length of the string. 
	/// (Note: If implementing in Java, please use a character array so that you can perform this operation in place.)
	/// Ref.:
	/// https://the-average-developer.medium.com/cracking-the-coding-interview-3-urlify-5fcb8d84429
	/// https://pyseek.com/2021/02/urlify-a-given-string-using-python/
	/// https://www.geeksforgeeks.org/urlify-a-given-string-replace-spaces-with-%20/
	/// https://leetcode.com/discuss/interview-question/124608/amazon-phone-screen-urlify-a-given-string-replace-spaces-with-20
	/// https://leetcode.com/discuss/general-discussion/651658/understanding-urlify-code-from-cracking-the-code-interview-book
	/// https://aaronpkelly.github.io/2021/06/04/crackingTheCodingInterview_interviewQuestions_1.3.html
	/// </summary>
	public class URLify
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
