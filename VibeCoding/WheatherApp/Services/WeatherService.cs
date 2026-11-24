using System.Net.Http;
using System.Text.Json;
using WeatherApp.Models;
using System.Linq;

namespace WeatherApp.Services;

public class WeatherService {
    private readonly HttpClient _httpClient = new();

    public async Task<WeatherData?> GetWeatherAsync(double latitude,double longitude) {
        string url =
            $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current=temperature_2m,weather_code&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max&timezone=Asia%2FTokyo"; ;

        var response = await _httpClient.GetStringAsync(url);

        using JsonDocument doc = JsonDocument.Parse(response);

        int weatherCode =
            doc.RootElement
               .GetProperty("current")
               .GetProperty("weather_code")
               .GetInt32();

        var daily = doc.RootElement.GetProperty("daily");

        var dates =
            daily.GetProperty("time")
                 .EnumerateArray()
                 .Select(x => x.GetString()!)
                 .ToList();

        var maxTemps =
            daily.GetProperty("temperature_2m_max")
                 .EnumerateArray()
                 .Select(x => x.GetDouble())
                 .ToList();

        var minTemps =
            daily.GetProperty("temperature_2m_min")
                 .EnumerateArray()
                 .Select(x => x.GetDouble())
                 .ToList();

        var rainProbabilities =
            daily.GetProperty("precipitation_probability_max")
                 .EnumerateArray()
                 .Select(x => x.GetInt32())
                 .ToList();

        var weatherCodes =
            daily.GetProperty("weather_code")
                 .EnumerateArray()
                 .Select(x => x.GetInt32())
                 .ToList();

        List<DailyForecast> forecasts = new();

        for (int i = 0; i < dates.Count; i++) {
            forecasts.Add(new DailyForecast {
                Date = dates[i],
                MaxTemperature = maxTemps[i],
                MinTemperature = minTemps[i],
                PrecipitationProbability = rainProbabilities[i],
                WeatherText = GetWeatherText(weatherCodes[i])
            });
        }


        return new WeatherData {
            Temperature =
        doc.RootElement
           .GetProperty("current")
           .GetProperty("temperature_2m")
           .GetDouble(),

            WeatherCode = weatherCode,

            WeatherText = GetWeatherText(weatherCode),

            DailyForecasts = forecasts
        };
    }

    private string GetWeatherText(int code) {
        return code switch {
            0 => "快晴",
            1 => "晴れ",
            2 => "一部曇り",
            3 => "曇り",
            45 => "霧",
            48 => "霧",
            51 => "弱い霧雨",
            53 => "霧雨",
            55 => "強い霧雨",
            61 => "弱い雨",
            63 => "雨",
            65 => "大雨",
            71 => "弱い雪",
            73 => "雪",
            75 => "大雪",
            80 => "にわか雨",
            81 => "強いにわか雨",
            82 => "激しいにわか雨",
            95 => "雷雨",
            _ => "不明"
        };
    }
}