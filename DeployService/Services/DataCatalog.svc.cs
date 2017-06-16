using DeployService.ConcentoAuthentication;
using DeployService.Models.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DeployService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataCatalog" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DataCatalog.svc or DataCatalog.svc.cs at the Solution Explorer and start debugging.
    public class DataCatalog : IDataCatalog
    {
        public System.IO.Stream CreateStreamForResponse(
         ResponseStatus iResponseStatus,
         string strResponseMessage,
         Object objToSerialize)
        {
            ResponseModel response = new ResponseModel();
            response.iResponseStatus = iResponseStatus;
            response.strResponseStatusMessage = strResponseMessage;
            response.objData = objToSerialize;

            JsonSerializerSettings settings = new JsonSerializerSettings();
            ////used for handling null values
            settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            ////convert the object into a string format
            String strResponseDataSet = JsonConvert.SerializeObject(response, settings);
            //have the control over the json
            byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
            return new System.IO.MemoryStream(responseData);
        }
        //Authenticate login credentials
        public System.IO.Stream Authenticate(auth_req areq)
        {
            try
            {
                ConcentoSecurityDataContext dc = new ConcentoSecurityDataContext();

                WebClient WC = new WebClient();
                WC.Headers.Add("Content-Type", "application/json");
                WC.Headers.Add("User-Agent", WebOperationContext.Current.IncomingRequest.UserAgent);
                WC.Encoding = Encoding.UTF8;

                MemoryStream MS = new MemoryStream();
                DataContractJsonSerializer JSrz = new DataContractJsonSerializer(typeof(auth_req));
                JSrz.WriteObject(MS, areq);

                if (Convert.ToBoolean(
                        ConfigurationManager.AppSettings["ignoreSSLCertificateValidation"]))
                {
                    ServicePointManager
                        .ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                }


                byte[] res1 = WC.UploadData("http://localhost:50611/Services/Authentication.svc/sec/auth/verify", "POST", MS.ToArray());
                //byte[] res1 = WC.UploadData(
                //    "https://dev.dmroffice.com/Deploy2/ConcentoSecurity/Services/Authentication.svc/sec/auth/verify",
                //    "POST",
                //    MS.ToArray());
                MS = new MemoryStream(res1);
                var serializer = new StreamReader(MS);
                var resp = serializer.ReadToEnd();

                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                return CreateStreamForResponse(ResponseStatus.RESPONSE_OK, "Success", resp);
            }
            catch (Exception ex)
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.ServiceUnavailable;
                return null;
                //CreateStreamForResponse(ResponseStatus.RESPONSE_ERROR_EXCEPTION, "Exception", ex);
            }

        }

        //Get Employees details
        public System.IO.Stream GetEmployees()
        {
            try
            {
                DataSetDBModel dataSetModel = new DataSetDBModel();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                //used for handling null values
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                //convert the object into a string format
                string strResponseDataSet = JsonConvert.SerializeObject(
                    dataSetModel.GetEmployees(), settings);
                //have the control over the json
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                return new System.IO.MemoryStream(responseData);
            }
            catch (Exception ex)
            {
                string strResponseDataSet = JsonConvert.SerializeObject(ex.Message);
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                return new System.IO.MemoryStream(responseData);
            }
        }

        //Get Mapping Actions
        public System.IO.Stream GetMappingActions()
        {
            try
            {
                DataSetDBModel dataSetModel = new DataSetDBModel();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                //used for handling null values
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                //convert the object into a string format
                string strResponseDataSet = JsonConvert.SerializeObject(
                    dataSetModel.GetMappingActions(), settings);
                //have the control over the json
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                return new System.IO.MemoryStream(responseData);
            }
            catch (Exception ex)
            {
                string strResponseDataSet = JsonConvert.SerializeObject(ex.Message);
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                return new System.IO.MemoryStream(responseData);
            }
        }

        //Get Object Types
        public System.IO.Stream GetObjectTypes()
        {
            try
            {
                DataSetDBModel dataSetModel = new DataSetDBModel();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                //used for handling null values
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                //convert the object into a string format
                string strResponseDataSet = JsonConvert.SerializeObject(
                    dataSetModel.GetObjectTypes(), settings);
                //have the control over the json
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                return new System.IO.MemoryStream(responseData);
            }
            catch (Exception ex)
            {
                string strResponseDataSet = JsonConvert.SerializeObject(ex.Message);
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                return new System.IO.MemoryStream(responseData);
            }
        }

        //Get Priority calculated
        public System.IO.Stream GetPriorityCalc()
        {
            try
            {
                DataSetDBModel dataSetModel = new DataSetDBModel();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                //used for handling null values
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                //convert the object into a string format
                string strResponseDataSet = JsonConvert.SerializeObject(
                    dataSetModel.GetPriorityCalc(), settings);
                //have the control over the json
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                return new System.IO.MemoryStream(responseData);
            }
            catch (Exception ex)
            {
                string strResponseDataSet = JsonConvert.SerializeObject(ex.Message);
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                return new System.IO.MemoryStream(responseData);
            }
        }

        //Get Stakeholder Division
        public System.IO.Stream GetStakeholderDivision()
        {
            try
            {
                DataSetDBModel dataSetModel = new DataSetDBModel();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                //used for handling null values
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                //convert the object into a string format
                string strResponseDataSet = JsonConvert.SerializeObject(
                    dataSetModel.GetStakeholderDivision(), settings);
                //have the control over the json
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                return new System.IO.MemoryStream(responseData);
            }
            catch (Exception ex)
            {
                string strResponseDataSet = JsonConvert.SerializeObject(ex.Message);
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                return new System.IO.MemoryStream(responseData);
            }
        }

        //Get Stakeholder Dept
        public System.IO.Stream GetStakeholderDept(string strDivision)
        {
            try
            {
                DataSetDBModel dataSetModel = new DataSetDBModel();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                //used for handling null values
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                //convert the object into a string format
                string strResponseDataSet = JsonConvert.SerializeObject(
                    dataSetModel.GetStakeholderDept(strDivision), settings);
                //have the control over the json
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                return new System.IO.MemoryStream(responseData);
            }
            catch (Exception ex)
            {
                string strResponseDataSet = JsonConvert.SerializeObject(ex.Message);
                byte[] responseData = Encoding.UTF8.GetBytes(strResponseDataSet);
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                return new System.IO.MemoryStream(responseData);
            }
        }


        public System.IO.Stream DeleteUIGridRow(dEmployees emp)
        {
            try
            {
                DDataPolicyDataContext dc = new DDataPolicyDataContext();
                RefEmployee updateEmp = dc.RefEmployees.Where(o => o.EMPLOYEE_ID == emp.EmpID).FirstOrDefault();

                dc.RefEmployees.DeleteOnSubmit(updateEmp);
                dc.SubmitChanges();

                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                return CreateStreamForResponse(ResponseStatus.RESPONSE_OK, "Success", null);
            }
            catch (Exception ex)
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.ServiceUnavailable;
                return null;
                //CreateStreamForResponse(ResponseStatus.RESPONSE_ERROR_EXCEPTION, "Exception", ex);
            }
        }
       
    }
}
