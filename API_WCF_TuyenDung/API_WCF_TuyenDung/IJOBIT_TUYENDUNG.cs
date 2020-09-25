using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API_WCF_TuyenDung
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJOBIT_TUYENDUNG" in both code and config file together.
    [ServiceContract]
    public interface IJOBIT_TUYENDUNG
    {
        [OperationContract]
        void DoWork();
    }
}
