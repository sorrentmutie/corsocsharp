// See https://aka.ms/new-console-template for more information
using DemoCorsoCSharp;

Console.WriteLine("Hello, World!");


new CSVGenerator<Book>(BookData.Books, "MyBooks").Generate();
new CSVGenerator<Weather>(WeatherData.Weather, "MyWeather").Generate();