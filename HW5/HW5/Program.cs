using HW5;
using HW5.Thermostat;

public class Program
{
    public static void Main(string[] args)
    {

		#region Exercise 1 test
		var th1 = new Thermostat();
		th1.TemperatureChanged += On_TemperatureChanged;

		th1.ChangeTemperature(100);
		#endregion

		#region Exercise 2 test
		var testList = new List<int>() { 1, 2, 5, 10, 11, 12, 15, 16, 20 };

		var outputTest = testList.ReturnWhere(x => x % 2 == 0);
		NumberFilter.ShowList(outputTest);

		Console.WriteLine();

		var r = new Random();
		var randomNumber = r.Next(0, 20);
		var outputTest2 = testList.ReturnWhere(x => x > randomNumber);
		NumberFilter.ShowList(outputTest2);
        #endregion

    }

	#region Exercise 1
	public static void On_TemperatureChanged(object sender, TemperatureEventArgs e)
	{
		Console.WriteLine($"Нова температура: {e.NewTemperature}");
	}
	#endregion

}


