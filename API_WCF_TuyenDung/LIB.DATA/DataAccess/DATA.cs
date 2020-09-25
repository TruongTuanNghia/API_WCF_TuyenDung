
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

    }
}
