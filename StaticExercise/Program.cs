namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts Fahrenheit to Celsius & Celsius to Fahrenheit!");
            string conversion = CommandDoWhileLoop();
            
            if (conversion == "celsius")
            {
                double tempFahrenheit = TryParseDoWhileLoop();
                Console.WriteLine(TempConverter.FahrenheitToCelsius(tempFahrenheit));
            }
            else if (conversion == "fahrenheit")
            {
                double tempCelsius = TryParseDoWhileLoop();
                Console.WriteLine(TempConverter.CelsiusToFahrenheit(tempCelsius));
            }
            else // (conversion == "goodbye")
            {
                Console.WriteLine("Goodbye");
            }

            static string CommandDoWhileLoop()
            {
                string conversion;
                string fahrenheit = "fahrenheit";
                string celsius = "celsius";
                string goodbye = "goodbye";

                do
                {
                    Console.Write("Please, type 'celsius' to convert to Celsius.\nPlease, type 'fahrenheit' to convert to Fahrenheit.\nPlease, type 'goodbye' to leave.\n");
                    conversion = Console.ReadLine().ToLower();
                }while (conversion != "celsius" && conversion != "fahrenheit" && conversion != "goodbye");
                
                return conversion;
            }

            static double TryParseDoWhileLoop()
            {
                bool tempIsADouble;
                double temp;

                do
                {
                    Console.WriteLine("Please, type a temperature.");
                    tempIsADouble = double.TryParse(Console.ReadLine(), out temp);
                }while(!tempIsADouble);
                
                return temp;
            }
        }
    }
}
