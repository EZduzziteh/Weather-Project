using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Project { 
    public class WeatherDataModel
    {
        public float tzoffset { get; set; }
        public string address { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string description { get; set; }
        public string resolvedAddress { get; set; }

        public CurrentConditionsModel? currentConditions { get; set; }
        public DayModel[]? days { get; set; }
    }
}



/*
 
 queryCost":1,
   "latitude":51.0453,
   "longitude":-114.063,
   "resolvedAddress":"Calgary, AB, Canada",
   "address":"Calgary",
   "timezone":"America/Edmonton",
   "tzoffset":-7.0,
   "description":"Cooling down with a chance of snow tomorrow & Saturday.",
   "days"
   "alerts"
   "stations"
   "currentConditions:="
 
 
 
 
 */
