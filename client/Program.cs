using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;

var client = new HttpClient();


var weatherForecasts =
    await client.GetFromJsonAsync<List<WeatherForecast>>(
        "https://localhost:7138/weatherforecast");


foreach (var weatherForecast in weatherForecasts)
{
    Console.WriteLine(
        $"Date:{weatherForecast.Date}, TemperatureC:{weatherForecast.TemperatureC}, Summary:{weatherForecast.Summary}");
}

record WeatherForecast (DateTime Date,int TemperatureC,string? Summary );

