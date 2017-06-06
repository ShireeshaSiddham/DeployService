using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeployService.Models.Database
{
    public enum ResponseStatus
    {
        RESPONSE_OK = 1000,
        RESPONSE_ERROR_PARAM = 2000,
        RESPONSE_ERROR_PROCESS = 2001,
        RESPONSE_ERROR_EXCEPTION = 2999
    }
    public class ResponseModel
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public ResponseStatus iResponseStatus;
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Include)]
        public string strResponseStatusMessage;
        [JsonProperty("data", NullValueHandling = NullValueHandling.Include)]
        public object objData;
    }
}