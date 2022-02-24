using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Don't need to do this since its a static class - TempConverter tempconverter = new TempConverter();  
            TempConverter.FahrenheitToCelcius(9.5);
            TempConverter.CelsiusToFahrenheit(9.5);
        }
    }
}
