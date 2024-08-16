namespace HW5
{
	public static class NumberFilter
	{
		public static IEnumerable<int> ReturnWhere(this IEnumerable<int> list, Func<int, bool> lambda)
		{
			foreach (var item in list)
			{
				if (lambda(item))
				{
					yield return item;
				}
			}
		}

		public static void ShowList(IEnumerable<int> list)
		{
			foreach (var item in list)
			{
				Console.Write($"{item}, ");
			}
		}
	}
}
