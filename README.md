# Stubs
Space Stub

You need to build unit tests for the class “WeatherUtilities”. The funky thing about WeatherUtilities is that it relies on telemetry data from a spacecraft in flight to do its thing. 

Specifically:
-	The class WeatherUtilities has a method named JudgeWeatherByWaterState().  It invokes a method named GetTemperature() on a Weather object.
-	GetTemperature’s job is to ask for real-time sensor data from a spacecraft that is tooling around somewhere in the solar system.  It does so by invoking GetTempFromSpacecraft. 

The main task here to create a stub that will allow you to fake out the object so that you don’t have to wait for someone to launch a probe to test your code.
