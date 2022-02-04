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

            int value;
            String bb = "";
            Boolean isCorrect = false;
            Boolean isTrue = false;


            while (!(isCorrect))
            {
                
                Console.WriteLine("Enter the value to be converted:");
                bb = Console.ReadLine();
                isCorrect= (int.TryParse(bb, out value) && value > 0);

                if (!isCorrect)
                {
                    Console.WriteLine("Please input numeric value greater than 0");
                    Console.WriteLine(" ");
                }
            }
            value = int.Parse(bb);


            int choice = 0;
            String aaa = "";

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
                aaa = Console.ReadLine();
                isTrue = (int.TryParse(aaa, out choice) && (choice > 0 && choice < 8));

                if (!isTrue)
                {
                    Console.WriteLine("Please input the correct choice from the menu");
                    Console.WriteLine(" ");
                }
                else
                {
                    choice = int.Parse(aaa);                    
                    Console.WriteLine(Conversion(choice, value));                    
                }
            }
                      
        }

        private Double Conversion(int choice, int value)
        {
            Double aa = 0.0;
            Conversion c = new(value);
            switch (choice)
            {
                case 1:                    
                    aa = c.ConvertCelciusToFahrenheit();
                    return aa;
                case 2:
                    aa = c.ConvertCelciusToKelvin();
                    return aa;
                case 3:
                    aa = c.ConvertFahrenheitToCelsius();
                    return aa;
                case 4:
                    aa = c.ConvertFahrenheitToKelvin();
                    return aa;
                case 5:
                    aa = c.ConvertKelvinToCelsius();
                    return aa;
                case 6:
                    aa = c.ConvertKelvinToFahrenheit();
                    return aa;

                default:
                    return aa;
            }
        }
    }
}
