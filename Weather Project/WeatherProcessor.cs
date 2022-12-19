using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
namespace Weather_Project
{
    public class WeatherProcessor
    {
        

        public static async Task<WeatherDataModel> LoadWeatherByCityName(string cityName)
        {
            string url = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/";
            url += cityName;   
            url+="?key=YR3HWVP2ZUK54M27FMQSDB973";
            
                //https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Calgary?key=YR3HWVP2ZUK54M27FMQSDB973";


            using (HttpResponseMessage res = await APIHelper.ApiClient.GetAsync(url))
            {
                if (res.IsSuccessStatusCode)
                {

                    WeatherDataModel weather = await res.Content.ReadAsAsync<WeatherDataModel>();
                    Console.WriteLine("temp: "+weather.days[0].temp);
                    return weather;
                }
                else
                {
                    throw new Exception(res.ReasonPhrase);
                }
            }


        }

        
    }
}
