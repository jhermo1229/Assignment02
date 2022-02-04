using NUnit.Framework;
using System;

namespace Assignment02.Test
{
    public class ConversionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_WhenNothingIsSetDefaultValueIs1_ReturnIs34()
        {
            Conversion c = new();
            Double expectedValue = 34;

            Double value = c.ConvertCelsiusToFahrenheit();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_WhenReturnIsDouble_ReturnTrue()
        {
            Conversion c = new(100);

            Assert.IsTrue(c.ConvertCelsiusToFahrenheit().GetType() == typeof(double));
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_WhenInputIs100_ReturnIs212()
        {
            Conversion c = new(100);
            Double expectedValue = 212;

            Double value = c.ConvertCelsiusToFahrenheit();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_WhenInputIs0_ReturnIs32()
        {
            Conversion c = new(0);
            Double expectedValue = 32;

            Double value = c.ConvertCelsiusToFahrenheit();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertCelsiusToKelvin_WhenNothingIsSetDefaultValueIs1_ReturnIs274()
        {
            Conversion c = new();
            Double expectedValue = 274;

            Double value = c.ConvertCelsiusToKelvin();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertCelsiusToKelvin_WhenReturnIsDouble_ReturnTrue()
        {
            Conversion c = new(100);

            Assert.IsTrue(c.ConvertCelsiusToFahrenheit().GetType() == typeof(double));
        }

        [Test]
        public void ConvertCelsiusToKelvin_WhenInputIs100_ReturnIs373()
        {
            Conversion c = new(100);
            Double expectedValue = 373;

            Double value = c.ConvertCelsiusToKelvin();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertCelsiusToKelvin_WhenInputIsNegative1_ReturnIs272()
        {
            Conversion c = new(-1);
            Double expectedValue = 272;

            Double value = c.ConvertCelsiusToKelvin();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertFahrenheitToCelsius_WhenNothingIsSetDefaultValueIs1_ReturnIsNegative17()
        {
            Conversion c = new();
            Double expectedValue = -17;

            Double value = c.ConvertFahrenheitToCelsius();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertFahrenheitToCelsius_WhenReturnIsDouble_ReturnTrue()
        {
            Conversion c = new(100);

            Assert.IsTrue(c.ConvertFahrenheitToCelsius().GetType() == typeof(double));
        }

        [Test]
        public void ConvertFahrenheitToCelsius_WhenInputIs100_ReturnIs38()
        {
            Conversion c = new(100);
            Double expectedValue = 38;

            Double value = c.ConvertFahrenheitToCelsius();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertFahrenheitToCelsius_WhenInputIs101_ReturnIs38()
        {
            Conversion c = new(101);
            Double expectedValue = 38;

            Double value = c.ConvertFahrenheitToCelsius();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_WhenNothingIsSetDefaultValueIs1_ReturnIs256()
        {
            Conversion c = new();
            Double expectedValue = 256;

            Double value = c.ConvertFahrenheitToKelvin();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_WhenReturnIsDouble_ReturnTrue()
        {
            Conversion c = new(100);

            Assert.IsTrue(c.ConvertFahrenheitToKelvin().GetType() == typeof(double));
        }

        [Test]
        public void ConvertFahrenheitToKelvin_WhenInputIs100_ReturnIs310()
        {
            Conversion c = new(100);
            Double expectedValue = 310;

            Double value = c.ConvertFahrenheitToKelvin();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_WhenInputIsNegative460_ReturnIs0()
        {
            Conversion c = new(-460);
            Double expectedValue = 0;

            Double value = c.ConvertFahrenheitToKelvin();

            Assert.AreEqual(expectedValue, value);
        }


        [Test]
        public void ConvertKelvinToCelsius_WhenNothingIsSetDefaultValueIs1_ReturnIsNegative272()
        {
            Conversion c = new();
            Double expectedValue = -272;

            Double value = c.ConvertKelvinToCelsius();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertKelvinToCelsius_WhenReturnIsDouble_ReturnTrue()
        {
            Conversion c = new(100);

            Assert.IsTrue(c.ConvertKelvinToCelsius().GetType() == typeof(double));
        }

        [Test]
        public void ConvertKelvinToCelsius_WhenInputIs100_ReturnIsNegative173()
        {
            Conversion c = new(100);
            Double expectedValue = -173;

            Double value = c.ConvertKelvinToCelsius();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertKelvinToCelsius_WhenInputIsNegative173_ReturnIsNegative446()
        {
            Conversion c = new(-173);
            Double expectedValue = -446;

            Double value = c.ConvertKelvinToCelsius();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_WhenNothingIsSetDefaultValueIs1_ReturnIsNegative458()
        {
            Conversion c = new();
            Double expectedValue = -458;

            Double value = c.ConvertKelvinToFahrenheit();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_WhenReturnIsDouble_ReturnTrue()
        {
            Conversion c = new(100);

            Assert.IsTrue(c.ConvertKelvinToFahrenheit().GetType() == typeof(double));
        }

        [Test]
        public void ConvertKelvinToFahrenheit_WhenInputIs100_ReturnIsNegative279()
        {
            Conversion c = new(100);
            Double expectedValue = -279;

            Double value = c.ConvertKelvinToFahrenheit();

            Assert.AreEqual(expectedValue, value);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_WhenInputIs0_ReturnIsNegative459()
        {
            Conversion c = new(0);
            Double expectedValue = -459;

            Double value = c.ConvertKelvinToFahrenheit();

            Assert.AreEqual(expectedValue, value);
        }
    }
}