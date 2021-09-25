using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;

var client = new HttpClient();


var weatherForecasts =
    await client.GetFromJsonAsync<List<WeatherForecast>>(
        "https://localhost:7138/weatherforecast");


//Console.WriteLine(weatherForecasts);

foreach (var weatherForecast in weatherForecasts)
{
    Console.WriteLine(
        $"Date:{weatherForecast.Date}, TemperatureC:{weatherForecast.TemperatureC}, Summary:{weatherForecast.Summary}");
}

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
