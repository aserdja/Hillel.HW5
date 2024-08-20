using System.Threading.Channels;

namespace HW5
{
	public class Sensor
	{
		public double?[] measurments { get; private set; } = new double?[10];

		public event EventHandler<double>? MeasurmentUpdated;

		Func<double, bool> addPositiveNumber = (x) =>
		{
			return x > 0;
		};

		public void AddMeasurment(double newValue)
		{
			if (addPositiveNumber(newValue))
			{
				AddNewValueToArray(newValue);
				Console.WriteLine("New value was added!");
				OnMeasureAdded(measurments.Average());
			}
			else
			{
                Console.WriteLine("New value can't be added. It's < 0");
            }			
		}

		protected virtual void OnMeasureAdded(double average)
		{
			MeasurmentUpdated?.Invoke(this, average);
		}

		public void AddNewValueToArray(double newValueToAdd)
		{
			for (int i = 0; i < measurments.Length; i++)
			{
				if (measurments[i] == null)
				{
					measurments[i] = newValueToAdd;
					break;
				}
			}
		}
	}
}
