using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WCF_TuyenDung
{
    public class ResponseModel
    {
        public int Returncode { get; set; }
        public string ReturnMessage { get; set; }
        public object Data { get; set; }
    }
}