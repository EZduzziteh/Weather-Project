namespace Weather_Project
{
    public class DayModel
    {
        public float temp { get; set; }
        public float humidity { get; set; }
        public float precip { get; set; }
        public float precipprob { get; set; }
        public string conditions { get; set; }
        public float windgust { get; set; }
        public float windspeed { get; set; }
        public DateTime datetime { get; set; }
        public string precipstyle { get; set; }
        public float tempmax { get; set; }
        public float tempmin { get; set; }
        public string icon { get; set; }

        public DateTime sunrise { get; set; }
        public DateTime sunset { get; set; }
        public float feelslikemin{ get; set; }
        public float feelslikemax { get; set; }
        public float feelslike { get; set; }
        public float pressure { get; set; } 

        /*
        "datetime":"2022-12-05",
         "datetimeEpoch":1670223600,  
         "tempmax":19.1,    //fahrenheit
         "tempmin":-3.0,    //fahrenheit
         "temp":12.0,                //fahrenheit
         "feelslikemax":17.3,     //fahrenheit
         "feelslikemin":-13.2, //fahrenheit
         "feelslike":1.2, //fahrenheit
         "dew":7.4,
         "humidity":81.3,    //percentage
         "precip":0.08,  //amount in inches
         "precipprob":100.0,  //percentage
         "precipcover":37.5,
         "preciptype"*/   //string eg: "rain", "snow"
    }
}