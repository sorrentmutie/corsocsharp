using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCorsoCSharp;

public  class Weather
{
    [ReportItem(1)]
    public string? City{ get; set; }
    [ReportItem(20)]
    public string? Description{ get; set; }
    [ReportItem(21, Heading = "Temperature", Units = "°C" )]
    public double TemperatureCentrigrade{ get; set; }
    [ReportItem(22, Heading = "Rainfall", Units = "mm", Format ="N2")]
    public double RainfallInches { get; set; }
}

public static class WeatherData
{
    public static IEnumerable<Weather> Weather = new Weather[]
        {
            new () { City="London", Description="Sunny spells", TemperatureCentrigrade=19, RainfallInches=0},
            new () { City="Paris", Description="Very hot", TemperatureCentrigrade=27, RainfallInches=0},
            new() { City = "New York", Description = "Heavy rain", TemperatureCentrigrade = 8, RainfallInches = 6.598 },
            new() { City = "Munich", Description = "Foggy", TemperatureCentrigrade = 12, RainfallInches = 2.134 },
            new() { City = "Istanbul", Description = "Sunshine and showers", TemperatureCentrigrade = 22, RainfallInches = 8.5 },
            new() { City = "Santiago", Description = "Strong winds", TemperatureCentrigrade = 15, RainfallInches = 0.125 },
        };

}