using Newtonsoft.Json.Linq;
using OpenWeatherMap;

string key = File.ReadAllText("appsettings.json");
string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

Console.WriteLine("Please enter your zipcode");
var zipCode = Console.ReadLine();

string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}";

Console.WriteLine();
Console.WriteLine($"It is currently{WeatherMap.GetTemp(apiCall)}degrees F");



