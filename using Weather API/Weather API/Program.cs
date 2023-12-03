using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiKey = "7783afebfc4f04ecf66e305d37d36eeb";
        Console.Write("Enter city name: ");
        string cityName = Console.ReadLine();
        try
        {

            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    dynamic weatherData = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                    string weatherDescription = weatherData.weather[0].description;
                    double temperature = weatherData.main.temp;
                    string locationCoords = weatherData.coord.lon;
                    locationCoords += locationCoords + weatherData.coord.lat;
                    string pressure = weatherData.main.pressure;
                    string humidity = weatherData.main.humidity;
                    string visibility = weatherData.visibility;
                    string wind = weatherData.wind.speed;

                    Console.WriteLine($"Weather in {cityName}: {weatherDescription}");
                    Console.WriteLine($"Temperature: {temperature}°C");
                    Console.WriteLine($"City Coordination: {locationCoords}");
                    Console.WriteLine($"City pressure: {pressure}");
                    Console.WriteLine($"City humidity: {humidity}");
                    Console.WriteLine($"City visibility: {visibility} meters");
                    Console.WriteLine($"City wind: {wind}km/h");
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve data. Status code: {response.StatusCode}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
