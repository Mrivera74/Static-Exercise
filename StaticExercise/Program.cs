namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(86);

            Console.WriteLine($"{celsius} degrees Celsius");

            Console.WriteLine();

            var fahrenheit = TempConverter.CelsiusToFahrenheit(30);

            Console.WriteLine($"{fahrenheit} degrees Fahrenheit");
        }
    }
}
