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

		public static double Average(this IEnumerable<double?> array)
		{
			double result = 0;
			int counter = 0;

			foreach (var item in array)
			{
				if (item != null)
				{
					result += Convert.ToDouble(item);
					counter++;
				}
			}
			return result / counter;
		}
	}
}
