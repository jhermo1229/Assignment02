using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    /**
     * Conversion class of temperature. Created the criteria of having no decimal point in every 
     * conversion.
     */
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

        public double ConvertCelsiusToFahrenheit()
        {
            double value = (conversionObj * 1.8) + 32;
            return Math.Round(value,
                               MidpointRounding.AwayFromZero);
        }

        public double ConvertCelsiusToKelvin()
        {
            double value = (conversionObj + 273) ;
            return Math.Round(value,
                               MidpointRounding.AwayFromZero);
        }

        public double ConvertKelvinToFahrenheit()
        {
            double value = (1.8 * (conversionObj - 273.15)) + 32;
            return Math.Round(value,
                               MidpointRounding.AwayFromZero);
        }

        public double ConvertKelvinToCelsius()
        {
            double value = conversionObj - 273;
            return Math.Round(value,
                               MidpointRounding.AwayFromZero);
        }

        public double ConvertFahrenheitToKelvin()
        {
            double value = (((conversionObj-32) * 5) / 9) + 273.15;
            return Math.Round(value,
                               MidpointRounding.AwayFromZero);
        }

        public double ConvertFahrenheitToCelsius()
        {
            double value = (conversionObj - 32)/1.8;
            return Math.Round(value,
                               MidpointRounding.AwayFromZero);
        }

    }
}
