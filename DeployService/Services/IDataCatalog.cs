
using DeployService.ConcentoAuthentication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using DeployService.Models.Database;
using System.Text;

namespace DeployService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataCatalog" in both code and config file together.
    [ServiceContract]
    public interface IDataCatalog
    {
        //Authenticate login credentials
        [OperationContract]
        [WebInvoke(Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "login/authenticate")]
        System.IO.Stream Authenticate(auth_req arequest);

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "GetEmployees")]
        System.IO.Stream GetEmployees();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "GetMappingActions")]
        System.IO.Stream GetMappingActions();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "GetObjectTypes")]
        System.IO.Stream GetObjectTypes();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "GetPriorityCalc")]
        System.IO.Stream GetPriorityCalc();
    }
}
