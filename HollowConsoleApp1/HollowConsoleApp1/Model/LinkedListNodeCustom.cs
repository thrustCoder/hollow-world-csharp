namespace HollowConsoleApp1.Model
{
	// Named with "Custom" suffix since there is a pre-existing class called LinkedListNode.
	// You can also use that if you want.
	class LinkedListNodeCustom
	{
		public LinkedListNodeCustom(int d) {
			Data = d;
			Next = null;
		}

		public int Data { get; set; }
		public LinkedListNodeCustom Next { get; set; }
	}
}
