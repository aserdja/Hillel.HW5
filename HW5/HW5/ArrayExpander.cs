namespace HW5
{
	public static class ArrayExpander
	{
		public static double Average(this int[] array)
		{
			double result = 0;
			foreach (int item in array)
			{
				result += item;
			}
			return result / array.Length;
		}
	}
}
