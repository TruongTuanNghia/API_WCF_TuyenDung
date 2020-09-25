using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API_WCF_TuyenDung
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JOBIT_TUYENDUNG" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JOBIT_TUYENDUNG.svc or JOBIT_TUYENDUNG.svc.cs at the Solution Explorer and start debugging.
    public class JOBIT_TUYENDUNG : IJOBIT_TUYENDUNG
    {
        public Stream DoLogin(Do_Login_Input up)
        {
            var ls = Services.DoLogin(up);
            return CONVERJS.ReturnResult(ls);
        }

        public Stream InsertLogGin(LOGIN_INPUT model)
        {
            var isl = Services.Insert_Login(model);
            return CONVERJS.ReturnResult(isl);
        }
       
    }
}
