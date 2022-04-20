using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = ConvertFarenheitToCelsius(45.0);
            Console.WriteLine("45 degrees Farenheit is roughly " + celsius + " degrees Celsius.");

            celsius = ConvertFarenheitToCelsius(0);
            Console.WriteLine("0 degrees Farenheit is roughly " + celsius + " degrees Celsius.");

            celsius = ConvertFarenheitToCelsius(100);
            Console.WriteLine("100 degrees Farenheit is roughly " + celsius + " degrees Celsius.");
        }


        public static double ConvertFarenheitToCelsius(double farenheitTemperature)
        {
            // This code performs a calculation which will convert the F temperature to C
            double celsiusTemperature = (farenheitTemperature - 32) * (5.0 / 9.0);

            // Math.Round() is a method which will round the value celsiusTemperature to 1 decimal value
            double roundedCelsiusValue = Math.Round(celsiusTemperature, 1);

            return roundedCelsiusValue;
        }
    }
}
