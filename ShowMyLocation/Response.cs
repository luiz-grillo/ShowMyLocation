using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMyLocation
{
    public class Response
    {
        public string status {get;set;}
        public string message {get; set;}

        public string continent {get; set;}

        public string continentCode {get; set;}

        public string country {get; set;}

        public string countryCode {get; set;}

        public string region {get; set;}

        public string regionName {get; set;}

        public string city {get; set;}

        public string district {get; set;}

        public string zip { get; set;}

        public double lat {get; set;}

        public double lon {get; set;}

        public string timezone {get; set;}

        public double offset {get; set;}

        public string currency {get; set;}

        public string isp {get; set;}

        public string org {get; set;}

        public string asnumber {get; set;}

        [JsonProperty(PropertyName = "as")]
        public string asname {get; set;}

        public string reverse {get; set;}

        public bool mobile {get; set;}

        public bool proxy {get; set;}

        public bool hosting {get; set;}

        public string query {get; set;}
    }
}
