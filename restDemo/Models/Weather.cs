using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace restDemo.Models
{
    [DataContract]    
    public class Weather
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }
        
        [DataMember(Name = "degree")]
        public float Degrees{ get; set; }

        [DataMember(Name = "dateTime")]
        public DateTime DateTime { get; set; }

    }
}