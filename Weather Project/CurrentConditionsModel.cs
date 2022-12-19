namespace Weather_Project
{
    public class CurrentConditionsModel
    {
        public float temp { get; set; }
        public float humidity { get; set; }
        public float precip { get; set; }
        public string conditions { get; set; }
        public float windspeed { get; set; }
        public DateTime sunrise { get; set; }
        public DateTime sunset { get; set; }
        public float feelslike { get; set; }
        public float pressure { get; set; }
        public string icon { get; set; }
        public float moonphase { get; set; }
    }



    /*
     
     "datetime":"13:00:00",
      "datetimeEpoch":1670961600,
      "temp":24.8,
      "feelslike":16.3,
      "humidity":68.82,
      "dew":16.0,
      "precip":0.0,
      "precipprob":0.0,
      "snow":0.0,
      "snowdepth":0.39,
      "preciptype":null,
      "windgust":5.1,
      "windspeed":7.7,
      "winddir":213.0,
      "pressure":1018.9,
      "visibility":9.8,
      "cloudcover":100.0,
      "solarradiation":56.0,
      "solarenergy":0.2,
      "uvindex":1.0,
      "severerisk":10.0,
      "conditions":"Overcast",
      "icon":"cloudy",
      "stations":[
         
      ],
      "source":"obs",
      "sunrise":"08:31:44",
      "sunriseEpoch":1670945504,
      "sunset":"16:29:21",
      "sunsetEpoch":1670974161,
      "moonphase":0.62
     
     */



}