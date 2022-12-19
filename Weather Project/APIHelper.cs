using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Weather_Project
{

    public static class APIHelper
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static HttpClient ApiClient { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
                              //YR3HWVP2ZUK54M27FMQSDB973
                              //https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/London,UK?key=YOUR_API_KEY 


        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }




    }
}
