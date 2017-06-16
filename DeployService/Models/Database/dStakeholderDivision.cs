using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeployService.Models.Database
{
    public class dStakeholderDivision
    {
        [JsonProperty("DIVISION", NullValueHandling = NullValueHandling.Include)]
        public string Division { get; set; }

        [JsonProperty("DEPT", NullValueHandling = NullValueHandling.Include)]
        public string Dept { get; set; }

        [JsonProperty("CREATED_BY", NullValueHandling = NullValueHandling.Include)]
        public string CreatedBy { get; set; }

        [JsonProperty("CREATED_ON", NullValueHandling = NullValueHandling.Include)]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("MODIFIED_BY", NullValueHandling = NullValueHandling.Include)]
        public string ModifiedBy { get; set; }

        [JsonProperty("MODIFIED_ON", NullValueHandling = NullValueHandling.Include)]
        public DateTime ModifiedOn { get; set; }
    }
}