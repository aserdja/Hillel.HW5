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

		public static double Average(this double?[] array)
		{
			double result = 0;
			int counter = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					result += Convert.ToDouble(array[i]);
					counter++;
				}
			}
			return result / counter;
		}
	}
}
