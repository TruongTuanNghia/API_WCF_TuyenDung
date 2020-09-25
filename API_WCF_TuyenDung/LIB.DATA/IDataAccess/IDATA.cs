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
    }
}
