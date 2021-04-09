using SpacecraftInterface;
using System;

namespace WeatherAnalysis
{
    public interface IWeather
    {
        double GetTemperature();
    }
    public class Weather : IWeather
    {
        public double GetTemperature()
        {
            return Telemetry.GetTempFromSpacecraft();
        }

    }

    public static class WeatherUtilities
    {
        public static string JudgeWeatherByWaterState(IWeather w)
        {
            double tempCelsius = w.GetTemperature();
            if (tempCelsius < -273)
            {
                throw new ColderThanAbsoluteZeroException();
            }
            else if (tempCelsius <= 0)
            {
                return ("Freezing");
            }
            else if (tempCelsius > 99)
            {
                return ("Boiling");
            }
            else
            {
                return ("Wet");
            }
        }

        public static string JudgeWeatherByEarthHistory(IWeather eH)
        {
            double tempCelsius = eH.GetTemperature();
            if (tempCelsius < -273)
            {
                throw new ColderThanAbsoluteZeroException();
            }
            else if (tempCelsius < -89)
            {
                return ("Colder than Earth");
            }
            else if (tempCelsius > 56)
            {
                return ("Hotter than Earth");
            }
            else
            {
                return ("Meh");
            }

        }

        public class ColderThanAbsoluteZeroException : Exception
        {
            public ColderThanAbsoluteZeroException()
            {
                throw new ArgumentException("ColderThanAbsoluteZero");
            }

            public ColderThanAbsoluteZeroException(string message)
                : base(message)
            {
            }

            public ColderThanAbsoluteZeroException(string message, Exception inner)
                : base(message, inner)
            {
            }

        }
    }

}
