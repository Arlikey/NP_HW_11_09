using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weathercast.Models
{
    public class WeatherResponse
    {
        public Weather[] weather { get; set; }

        public Main main { get; set; }

        public string name { get; set; }
        public Wind wind { get; set; }
    }

    public class Weather
    {
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
    }

    public class Wind
    {
        public float speed { get; set; }
    }
}
