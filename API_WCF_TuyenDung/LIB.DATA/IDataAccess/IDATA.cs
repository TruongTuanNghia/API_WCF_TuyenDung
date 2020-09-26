using LIB.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.IDataAccess
{
    public interface IDATA
    {
        ResponseResult InsertLogGin(LOGIN model);
        DOLOGIN DoLogin(string uname, string upass);
        ResponseResult UpdateLogin(string uname, string upass, string newupass);
        ResponseResult Insert_Experiences(INSERT_EXPERIENCES model);
        ResponseResult update_Experiences(INSERT_EXPERIENCES model);
        ResponseResult delete_Experiences(int idExperiences, int idUser);
        List<GET_EXPERIENCE> Get_List_Experiences(int id);
        ResponseResult insert_Candidate(INSERT_CANDIDATE model);
        ResponseResult update_Candidate(INSERT_CANDIDATE model);
        GET_CANDIDATE get_Candidate(int id);
        ResponseResult delete_Login(int id);
        ResponseResult insert_Company(INSERT_COMPANY model);
    }
}
