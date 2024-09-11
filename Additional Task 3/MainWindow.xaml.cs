using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Weathercast.Models;

namespace Weathercast
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient httpClient = new HttpClient();
        static private string uri = "http://api.openweathermap.org/data/2.5/weather";
        public MainWindow()
        {
            InitializeComponent();
        }


        public async Task<WeatherResponse> GetWeatherByLocationAsync(string location)
        {
            return await SendApi<WeatherResponse>(uri + $"?q={location}&units=metric&lang=ru");
        }

        private static async Task<T> SendApi<T>(string query)
        {
            string apiKey = GetWeatherApiKey();

            HttpClient httpClient = new HttpClient();

            HttpResponseMessage responseMessage = await httpClient.GetAsync(query + $"&appid={apiKey}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var result = await responseMessage.Content.ReadFromJsonAsync<T>();
                return result;
            }
            else
            {
                throw new Exception("Error. Try again later.");
            }
        }

        private static string GetWeatherApiKey()
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());


            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();

            var connectionString = config.GetSection("WeatherApi:ApiKey");
            return connectionString.Value;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(locationTextBox.Text))
            {
                MessageBox.Show("Введите локацию.");
                return;
            }
            var result = await GetWeatherByLocationAsync(locationTextBox.Text);

            locationLabel.Content = result.name;
            weatherLabel.Content = result.weather[0].description;
            tempLabel.Content = result.main.temp.ToString() + " °C";
            feelsLikeLabel.Content = result.main.feels_like.ToString() + " °C";
            windSpeedLabel.Content = result.wind.speed.ToString() + " м/c";


            string imageUrl = $"http://openweathermap.org/img/wn/{result.weather[0].icon}.png";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imageUrl, UriKind.Absolute);
            bitmap.EndInit();
            weatherIcon.Source = bitmap;
        }
    }
}