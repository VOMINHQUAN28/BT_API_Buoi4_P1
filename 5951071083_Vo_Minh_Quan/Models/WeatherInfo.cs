using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071083_Vo_Minh_Quan.Models
{
    public class WeatherInfo
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }
        [DataMember(Name = "degree")]

        public float Degree { get; set; }
        [DataMember(Name = "dateTime")]

        public DateTime DateTime { get; set; }
    }
}
    
