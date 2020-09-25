
using LIB.DATA.IDataAccess;
using LIB.DATA.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.DataAccess
{
    public class DATA : IDATA
    {
        
        public ResponseResult InsertLogGin(LOGIN model)
        {
            try
            {
                var lp = new List<SqlParameter>
                {
                    new SqlParameter("@username",model.userName),
                    new SqlParameter("@pas",model.userPassword),
                    new SqlParameter("@status",model.statusLG),
                    new SqlParameter("@type",model.typeLogin),
                };
                return CONNECT.CONNECT.ExecuteSP<ResponseResult>("insert_Login", lp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DOLOGIN DoLogin(string username, string password)
        {
            var lp = new List<SqlParameter>
                {
                    new SqlParameter("@username",username),
                    new SqlParameter("@pas",password),                  
                };
            return CONNECT.CONNECT.ExecuteSP<DOLOGIN>("DoLogin", lp);
        }

        public ResponseResult UpdateLogin(string uname, string upass, string newupass)
        {
            try
            {
                var lp = new List<SqlParameter>
                {
                    new SqlParameter("@username",uname),
                    new SqlParameter("@userPassword",upass),
                    new SqlParameter("@newuserPassword",newupass)
                };
                return CONNECT.CONNECT.ExecuteSP<ResponseResult>("update_Login", lp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ResponseResult Insert_Experiences(INSERT_EXPERIENCES model)
        {
            try
            {
                var lp = new List<SqlParameter>
                {
                    new SqlParameter("@idExperiences",model.idExperiences),
                    new SqlParameter("@idUser",model.idUser),
                    new SqlParameter("@title",model.titleJob),
                    new SqlParameter("@nameCompanny",model.nameComoanny),
                    new SqlParameter("@startDay",model.starDay),
                    new SqlParameter("@endDay",model.endDay),
                    new SqlParameter("@statusDoingJob",model.statusDoingJob),
                    new SqlParameter("@note",model.note),
                };
                return CONNECT.CONNECT.ExecuteSP<ResponseResult>("inser_Experience", lp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ResponseResult update_Experiences(INSERT_EXPERIENCES model)
        {
            try
            {
                var lp = new List<SqlParameter>
                {
                    new SqlParameter("@idExperiences",model.idExperiences),
                    new SqlParameter("@idUser",model.idUser),
                    new SqlParameter("@title",model.titleJob),
                    new SqlParameter("@nameCompanny",model.nameComoanny),
                    new SqlParameter("@startDay",model.starDay),
                    new SqlParameter("@endDay",model.endDay),
                    new SqlParameter("@statusDoingJob",model.statusDoingJob),
                    new SqlParameter("@note",model.note),
                };
                return CONNECT.CONNECT.ExecuteSP<ResponseResult>("inser_Experience", lp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
