using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DeployService.Models.Database
{
    public class dEmployees
    {
        [JsonProperty("EMPLOYEE_ID", NullValueHandling = NullValueHandling.Include)]
        public string EmpID { get; set; }

        [JsonProperty("FIRST_NAME", NullValueHandling = NullValueHandling.Include)]
        public string FName { get; set; }

        [JsonProperty("LAST_NAME", NullValueHandling = NullValueHandling.Include)]
        public string LName { get; set; }

        [JsonProperty("EMAIL", NullValueHandling = NullValueHandling.Include)]
        public string Email { get; set; }
    }
}