using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace API_WCF_TuyenDung
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJOBIT_TUYENDUNG" in both code and config file together.
    [ServiceContract]
    public interface IJOBIT_TUYENDUNG
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
              UriTemplate = "/insertLogin")]
        Stream InsertLogGin(LOGIN_INPUT model);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DoLogin")]
        Stream DoLogin(Do_Login_Input up);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/UpdateLogin/")]
        Stream Update_Login(UPDATE_LOGIN up);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/InsertExperiences")]
        Stream Insert_Experiences(INSERT_EXPERIENCES_INPUT up);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/UpdateExperience")]
        Stream Update_Experience(INSERT_EXPERIENCES_INPUT up);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DeleteExperience/")]
        Stream Delete_Experience(DELETE_EXPERIENCES_INPUT up);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetListExperiences")]
        Stream Get_List_Experiences(GET_EXPERIENCES_INPUT up);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "/insertCandidate")]
        Stream InsertCandidate(INSERT_CANDIDATE_INPUT model);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "/updateCandidate")]
        Stream updateCandidate(INSERT_CANDIDATE_INPUT model);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "/getCandidate")]
        Stream getCandidate(GET_CANDIDATE_INPUT model);
    }   

}
