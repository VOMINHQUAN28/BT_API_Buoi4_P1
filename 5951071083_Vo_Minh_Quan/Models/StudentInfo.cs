using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071083_Vo_Minh_Quan.Models
{
    public class StudentInfo
    {
        public string MaSoSv { get; internal set; }
        public string Lop { get; internal set; }
        public DateTime NgaySinh { get; internal set; }
        public string Hoten { get; internal set; }

        [DataContract]
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
}