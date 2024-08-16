namespace HW5.Thermostat
{
    

	public class Thermostat
    {
        public delegate void TemperatureChangedEventHandler(object sender, TemperatureEventArgs e);
        public event TemperatureChangedEventHandler? TemperatureChanged;

        public void ChangeTemperature(double newTemperature)
        {
            Console.WriteLine("Температуру змінено!");

            var args = new TemperatureEventArgs() { NewTemperature = newTemperature };
            OnTemperatureChanged(args);
        }

        protected virtual void OnTemperatureChanged(TemperatureEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);            
        }
    }
}