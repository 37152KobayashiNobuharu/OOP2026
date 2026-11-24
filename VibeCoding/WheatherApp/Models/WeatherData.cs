namespace WeatherApp.Models;

public class WeatherData {
    public double Temperature { get; set; }

    public int WeatherCode { get; set; }

    public string WeatherText { get; set; } = "";

    public List<DailyForecast> DailyForecasts { get; set; } = new();
}