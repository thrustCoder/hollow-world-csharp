using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using HollowConsoleApp1.Model;

namespace HollowConsoleApp1.Service
{
	class LinkedList
	{
		public static void ConvertListToSingleNum()
        {
			IEnumerable<int> listOfNums = new[] { 113, 455, 23, -125, 5, 34 };

			var resultStr = string.Empty;
			foreach (var num in listOfNums)
            {
				resultStr += num.ToString();
            }

			long result;
			var didParse = long.TryParse(resultStr, out result);
			Console.WriteLine("Result = " + (didParse ? result : -1));
        }

		public static void PrepFindLength() 
		{
			LinkedListNodeCustom l11 = new LinkedListNodeCustom(1);
			LinkedListNodeCustom l12 = new LinkedListNodeCustom(2);
			LinkedListNodeCustom l13 = new LinkedListNodeCustom(3);
			LinkedListNodeCustom l14 = new LinkedListNodeCustom(4);

			l11.Next = l12;
			l12.Next = l13;
			l13.Next = l14;

			Console.WriteLine($"Length of linked list: {Length(l11)}");
		}

		internal static void DoubleDivision()
		{
			int SIX = 0;
			int TWO = 60;
			double? x;
			x = (double) SIX / TWO;
			Console.WriteLine(x);
		}

		internal static void NewRandomExperiment2()
		{
			int SIX = 6;
			int TWO = 2;
			string CASEID = "2202221451234567";
			Console.WriteLine(CASEID.Substring(SIX, TWO));
		}

		internal static void NewRandomExperiment()
		{
			int[] numbers = new int[2];
			var doubledNumbers = numbers.Select(x => 2 * x);
			//Console.WriteLine(doubledNumbers.ToString());
		}

		internal static void NullConcatString()
		{
			string a = null;
			string b = "hello";
			string c = a + b;
			Console.WriteLine(c);
		}

		internal static void DefaultValues()
		{
			long a = 0;
			Console.WriteLine(a == default);

			long? b = 0;
			Console.WriteLine(b == default);

			long? c = null;
			Console.WriteLine(c == default);
		}

		internal static void RandomExperiment()
        {
			string timeInUTC = "2022-02-26T17:00:00.000Z";
			// yyyy-mm-ddThh:mi:ss.mmm
			DateTimeOffset utcDtTimeOffset = DateTimeOffset.Parse(timeInUTC);
			DateTime utcDtTime = utcDtTimeOffset.UtcDateTime;

			DateTime utcDtTimeOld = Convert.ToDateTime(timeInUTC);
			Console.WriteLine(utcDtTimeOld);

			DateTime? date = new DateTime(2019, 11, 12, 22, 45, 12, 004);
			string b = date.Value.ToString("dd-MMM-yyyy");

			string x2 = null;


			string c = "    ";
			string d = c.Substring(0, 4);

			string a1 = null;
			string b1 = "b1";
			string c1 = "c1";

			string a2 = string.Join("   ", "as", "Harry", "Sally");

			string x = null;
			string y = "sally";
			Console.WriteLine(y == x);

			dynamic obj = new ExpandoObject();
			obj.name = "Dev";

			string[] sArr = new string[] { };
			Console.WriteLine($"count = {sArr.Length}"); 
			Array.ForEach(sArr, ele => Console.WriteLine($"{ele}, "));

			string CountryWhereFilter = @"country: {{ in: [""{0}""] }}";
			string[] country = { "USA" };
			IList<string> countryList = new List<string>() { "USA", "India" };
			string formatStr = string.Format(CountryWhereFilter, string.Join(@""",""", countryList));
			Console.WriteLine(formatStr);

			string aHello = null;
			string bHello = "Hello";
			aHello += bHello; 
			Console.WriteLine("**********Ahello = " + aHello);

			string yInt = null;
			string xInt = null;
			Console.WriteLine("***********XLONG = " + string.Equals(yInt, xInt, StringComparison.OrdinalIgnoreCase));

			var myString = "D";
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			//var myString = "爱 爱";
			//var myString = "\x263A";
			//var pieces = myString.Split(new[] { ' ' }, 2);
			string[] pieces = myString.Split((string[])null, 2, StringSplitOptions.RemoveEmptyEntries);
			
			Console.WriteLine("***********piece 0 = " + pieces[0]);
			if (pieces.Length == 2 && !string.IsNullOrWhiteSpace(pieces[1]))
			{
				Console.WriteLine("***********piece 1 = " + pieces[1]);
			}

			if (!string.IsNullOrWhiteSpace(myString))
			{
				var trimmed = myString.Trim();
				int spaceDelimiterIndex = trimmed.IndexOf(" ");
				if (spaceDelimiterIndex >= 0)
				{
					Console.WriteLine("***************first = " + trimmed.Substring(0, spaceDelimiterIndex).Trim());
				}
				else
					Console.WriteLine("***************last = " + trimmed.Substring(spaceDelimiterIndex + 1).Trim());
			}

		}

        private static int Length(LinkedListNodeCustom head)
		{
			int len = 0;
			LinkedListNodeCustom current = head;

			while (current != null)
			{
				len++;
				current = current.Next;
			}

			return len;
		}
	}
}
