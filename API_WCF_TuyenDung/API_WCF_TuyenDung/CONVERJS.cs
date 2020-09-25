using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using Newtonsoft.Json;
namespace API_WCF_TuyenDung
{
    public class CONVERJS
    {
        public static string convert<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }


        public static Stream ReturnResult(string strResult)
        {
            var resultBytes = Encoding.UTF8.GetBytes(strResult);
            if (WebOperationContext.Current != null)
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json";

            return new MemoryStream(resultBytes);
        }
    }
}