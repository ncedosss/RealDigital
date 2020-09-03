using ACMERecognition.ManagementService.DTO.Data;
using ACMERecognition.ManagementService.DTO.Mapping;
using Newtonsoft.Json;
using System.Configuration;
using System.IO;
using System.Net;

namespace ACMERecognition.ManagementService.Logic.Common
{
    public static class Manager
    {
        public static EmployeeMapping GetEmployee()
        {
            HttpWebRequest httpWebRequest = null;
            HttpWebResponse httpWebResponse = null;
            string result = "";
            string url = ConfigurationManager.AppSettings["GetEmployee"].ToString();

            httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format(url, null));
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<EmployeeMapping>(result);
        }
    }
}
