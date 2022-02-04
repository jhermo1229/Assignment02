using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new();
            program.Go();
        }

        private void Go()
        {

            int valueTobeConverted;
            String rawValue = String.Empty;
            Boolean isValueValid = false;

            //Loop until entered value is valid
            while (!(isValueValid))
            {
                
                Console.WriteLine("Enter the value to be converted:");
                rawValue = Console.ReadLine();
                isValueValid= (int.TryParse(rawValue, out valueTobeConverted) && valueTobeConverted > 0);

                if (!isValueValid)
                {
                    Console.WriteLine("--Please input numeric value greater than 0--");
                    Console.WriteLine(" ");
                }
            }
            valueTobeConverted = int.Parse(rawValue);


            int choice = 0;
            String rawChoice;
            Boolean isChoiceValid;

            //loop until choice is equivalent to 7
            while (choice != 7)
            {
                Console.WriteLine("Please choose the conversion by entering the number:");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Fahrenheit to Celsius");
                Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                Console.WriteLine("5. Convert Kelvin to Celsius");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit ");
                rawChoice = Console.ReadLine();
                isChoiceValid = (int.TryParse(rawChoice, out choice) && (choice > 0 && choice < 8));

                if (!isChoiceValid)
                {
                    Console.WriteLine("--Please input the correct choice from the menu--");
                    Console.WriteLine(" ");
                }
                else
                {
                    choice = int.Parse(rawChoice);                    
                    Console.WriteLine(Conversion(choice, valueTobeConverted));                    
                }
            }
                      
        }
        //Conversion method that will call the class
        private Double Conversion(int choice, int value)
        {
            Conversion conversion = new(value);
            switch (choice)
            {
                case 1: 
                    return conversion.ConvertCelsiusToFahrenheit();
                case 2:
                    return conversion.ConvertCelsiusToKelvin();
                case 3:
                    return conversion.ConvertFahrenheitToCelsius();
                case 4:
                    return conversion.ConvertFahrenheitToKelvin();
                case 5:
                    return conversion.ConvertKelvinToCelsius();
                case 6:
                    return conversion.ConvertKelvinToFahrenheit();

                default:
                    return 0.0;
            }
        }
    }
}
