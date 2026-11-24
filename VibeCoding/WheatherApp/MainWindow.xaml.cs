using System.Windows;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp;

public partial class MainWindow : Window {
    private readonly WeatherService _weatherService = new();

    private List<CityInfo> _cities = new()
{
    new CityInfo
    {
        Name = "東京",
        Latitude = 35.6895,
        Longitude = 139.6917
    },

    new CityInfo
    {
        Name = "大阪",
        Latitude = 34.6937,
        Longitude = 135.5023
    },

    new CityInfo
    {
        Name = "名古屋",
        Latitude = 35.1815,
        Longitude = 136.9066
    },

    new CityInfo
    {
        Name = "前橋",
        Latitude = 36.3895,
        Longitude = 139.0634
    }
};


    public MainWindow()
{
    InitializeComponent();

    CityComboBox.ItemsSource = _cities;
    CityComboBox.DisplayMemberPath = "Name";
    CityComboBox.SelectedIndex = 0;
}

    private async void CityComboBox_SelectionChanged(
    object sender,
    System.Windows.Controls.SelectionChangedEventArgs e) {
        if (CityComboBox.SelectedItem is not CityInfo city)
            return;

        var weather =
            await _weatherService.GetWeatherAsync(
                city.Latitude,
                city.Longitude);

        if (weather == null) {
            TemperatureText.Text = "取得失敗";
            return;
        }

        TemperatureText.Text = $"{weather.Temperature} ℃";
        WeatherTextBlock.Text = weather.WeatherText;

        ForecastListView.ItemsSource = weather.DailyForecasts;
    }
}