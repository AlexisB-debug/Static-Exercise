namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double aTempFahrenheit)
    {
        double celsius = ((aTempFahrenheit - 32) * 5) / 9;
        return celsius;
    }

    public static double CelsiusToFahrenheit(double aTempCelsius)
    {
        double fahrenheit = ((aTempCelsius * 9) / 5) + 32;
        return fahrenheit;
    }
}