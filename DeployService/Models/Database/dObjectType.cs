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
    public class dObjectType
    {
        [JsonProperty("SORT_ORDER", NullValueHandling = NullValueHandling.Include)]
        public int SortOrder { get; set; }

        [JsonProperty("OBJECT_TYPE_ID", NullValueHandling = NullValueHandling.Include)]
        public int ID { get; set; }

        [JsonProperty("OBJECT_TYPE", NullValueHandling = NullValueHandling.Include)]
        public string ObjectType { get; set; }

        [JsonProperty("PAGE_ID", NullValueHandling = NullValueHandling.Include)]
        public Guid PageID { get; set; }

        [JsonProperty("URL", NullValueHandling = NullValueHandling.Include)]
        public string URL { get; set; }
    }
}