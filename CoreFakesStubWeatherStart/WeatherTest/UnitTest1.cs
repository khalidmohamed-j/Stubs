using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherAnalysis.Fakes;
using SUT = WeatherAnalysis.WeatherUtilities;
using System;
using FluentAssertions;

namespace WeatherTest
{
    [TestClass]
    public class JudgeWeatherByWaterState_Should
    {
        [DataTestMethod]
        [DataRow(0, "Freezing")]
        [DataRow(100, "Boiling")]
        [DataRow(20, "Wet")]
        public void ReturnWeatherByWaterState_WhenTemperatureIsTaken(double w, string expected)
        {
            //Arrange
            string actual;

            var weather = new StubIWeather()
            {
                GetTemperature = () => { return w; }
            };

            //Act
            actual = SUT.JudgeWeatherByWaterState(weather);

            //Assert
            //Assert.AreEqual(actual, expected);

            expected.Should().Be(actual);
        }

        [DataTestMethod]
        [DataRow(-275)]
        public void ReturnArgumentException_WhenTemperatureByWaterStateIsBelowNegative273(double w)
        {
            //Arrange

            StubIWeather weather = new StubIWeather()
            {
                GetTemperature = () => { return w; }
            };

            //Act-Assert
            //Assert.ThrowsException<ArgumentException>(() => SUT.JudgeWeatherByWaterState(weather));
           
            Action test = () => SUT.JudgeWeatherByWaterState(weather);
            test.Should().Throw<ArgumentException>();
        }
    }


    [TestClass]
    public class JudgeWeatherByEarthHistory_Should
    {
        [DataTestMethod]
        [DataRow(-100, "Colder than Earth")]
        [DataRow(89, "Hotter than Earth")]
        [DataRow(27, "Meh")]
        public void ReturnWeatherByEarthHistory_WhenTemperatureIsTaken(double eH, string expected)
        {
            //Arrange
            string actual;

            StubIWeather weather = new StubIWeather()
            {
                GetTemperature = () => { return eH; }
            };

            //Act
            actual = SUT.JudgeWeatherByEarthHistory(weather);

            //Assert
            //Assert.AreEqual(actual, expected);

            expected.Should().Be(actual);
        }

        [DataTestMethod]
        [DataRow(-283)]
        public void ReturnArgumentException_WhenTemperatureByEarthHistoryIsBelowNegative273(double w)
        {
            //Arrange

            StubIWeather weather = new StubIWeather()
            {
                GetTemperature = () => { return w; }
            };

            //Act - Assert
            //Assert.ThrowsException<ArgumentException>(() => SUT.JudgeWeatherByEarthHistory(weather));

            Action test = () => SUT.JudgeWeatherByEarthHistory(weather);
            test.Should().Throw<ArgumentException>();
        }
    }
}

