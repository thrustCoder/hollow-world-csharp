using System;
using HollowConsoleApp1.Model;

namespace HollowConsoleApp1.Service
{
	class LinkedList
	{
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
