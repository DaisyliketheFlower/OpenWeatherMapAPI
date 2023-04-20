using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMap
{
	internal class WeatherMap
	{
		public static double GetTemp(string apiCall)
		{
			var client = new HttpClient();

			var reponse = client.GetStringAsync(apiCall).Result;

            var temp = double.Parse(JObject.Parse(reponse)["main"]["temp"].ToString());

			return temp;
		}
	}
}

