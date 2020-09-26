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
        public Stream DeleteLogin(GET_LOGIN_INPUT model)
        {
            var l = Services.Delect_Login(model);
            return CONVERJS.ReturnResult(l);
        }

        public Stream Delete_Experience(DELETE_EXPERIENCES_INPUT up)
        {
            var l = Services.Delect_Experience(up);
            return CONVERJS.ReturnResult(l);
        }

        public Stream DoLogin(Do_Login_Input up)
        {
            var ls = Services.DoLogin(up);
            return CONVERJS.ReturnResult(ls);
        }

        public Stream GetAllJob(GET_ALL_JOB_INPUT model)
        {
            var ls = Services.get_All_Job(model);
            return CONVERJS.ReturnResult(ls);
        }

        public Stream getCandidate(GET_CANDIDATE_INPUT model)
        {
            var ls = Services.get_Candidate(model);
            return CONVERJS.ReturnResult(ls);
        }

        public Stream Get_List_Experiences(GET_EXPERIENCES_INPUT up)
        {
            var l = Services.Get_List_Experiences(up);
            return CONVERJS.ReturnResult(l);
        }

        public Stream InsertCandidate(INSERT_CANDIDATE_INPUT model)
        {
            var l = Services.Insert_Candidate(model);
            return CONVERJS.ReturnResult(l);
        }

        public Stream insertCompany(INSERT_COMPANY_INPUT model)
        {
            var l = Services.Insert_Company(model);
            return CONVERJS.ReturnResult(l);
        }

        public Stream insertJob(INSERT_JOB_INPUT model)
        {
            var l = Services.Insert_Job(model);
            return CONVERJS.ReturnResult(l);
        }

        public Stream InsertLogGin(LOGIN_INPUT model)
        {
            var isl = Services.Insert_Login(model);
            return CONVERJS.ReturnResult(isl);
        }

        public Stream Insert_Experiences(INSERT_EXPERIENCES_INPUT up)
        {
            var l = Services.Insert_Experiences(up);
            return CONVERJS.ReturnResult(l);
        }

        public Stream updateCandidate(INSERT_CANDIDATE_INPUT model)
        {
            var l = Services.update_Candidate(model);
            return CONVERJS.ReturnResult(l);
        }

        public Stream updateCompany(INSERT_COMPANY_INPUT model)
        {
            var l = Services.Update_Company(model);
            return CONVERJS.ReturnResult(l);
        }

        public Stream updateJob(UPDATE_JOB_INPUT model)
        {
            var l = Services.Update_Job(model);
            return CONVERJS.ReturnResult(l);
        }

        public Stream Update_Experience(INSERT_EXPERIENCES_INPUT up)
        {
            var l = Services.Update_Experience(up);
            return CONVERJS.ReturnResult(l);
        }

        public Stream Update_Login(UPDATE_LOGIN up)
        {
            var l = Services.Update_Login(up);
            return CONVERJS.ReturnResult(l);
        }
        

    }
}
