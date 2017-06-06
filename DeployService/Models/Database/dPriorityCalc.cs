using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DeployService.Models.Database
{
    [DataContract]
    [Serializable]
    public class dPriorityCalc
    {
        [JsonProperty("REQUEST_VALUE", NullValueHandling = NullValueHandling.Include)]
        public string ReqVal { get; set; }

        [JsonProperty("EFFORT", NullValueHandling = NullValueHandling.Include)]
        public string Effort { get; set; }

        [JsonProperty("CALC_PRIORITY", NullValueHandling = NullValueHandling.Include)]
        public int CalcPriority { get; set; }

    }
}