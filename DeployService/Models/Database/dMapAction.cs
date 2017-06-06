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
    public class dMapAction
    {
        [JsonProperty("MAP_ACTION", NullValueHandling = NullValueHandling.Include)]
        public string MapAction { get; set; }

        [JsonProperty("SOURCE_TABLE", NullValueHandling = NullValueHandling.Include)]
        public int SourceTable { get; set; }

        [JsonProperty("SOURCE_FIELD", NullValueHandling = NullValueHandling.Include)]
        public int SourceField { get; set; }

        [JsonProperty("DEFAULT", NullValueHandling = NullValueHandling.Include)]
        public int Default { get; set; }

        [JsonProperty("MAPPING_RULE", NullValueHandling = NullValueHandling.Include)]
        public string MappingRule { get; set; }
    }
}