using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Conversion
    {

        private int conversionObj;

        public Conversion()
        {
            conversionObj = 1;
        }

        public Conversion(int conversionObj)
        {
            this.conversionObj = conversionObj;
        }

        public double ConvertCelciusToFahrenheit()
        {
            double value = (conversionObj * 1.8) + 32;
            return value;
        }

        public double ConvertCelciusToKelvin()
        {
            double value = (conversionObj + 273) ;
            return value;
        }

        public double ConvertKelvinToFahrenheit()
        {
            double value = (1.8 * (conversionObj - 273)) + 32;
            return value;
        }

        public double ConvertKelvinToCelsius()
        {
            double value = conversionObj - 273;
            return value;
        }

        public double ConvertFahrenheitToKelvin()
        {
            double value = (((conversionObj-32) * 5) / 9) + 273.15;
            return value;
        }

        public double ConvertFahrenheitToCelsius()
        {
            double value = (conversionObj - 32) * 1.8;
            return value;
        }

    }
}
