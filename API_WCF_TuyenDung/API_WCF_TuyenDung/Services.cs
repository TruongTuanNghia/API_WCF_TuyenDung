﻿using LIB.DATA.DataAccess;
using LIB.DATA.IDataAccess;
using LIB.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WCF_TuyenDung
{
    public class Services
    {
        private static IDATA _IData;

        public static IDATA IData
        {
            get { return _IData ?? (_IData = new DATA()); }
        }
        public static string Insert_Login(LOGIN_INPUT model)
        {
            ResponseModel rs = new ResponseModel();
            if (string.IsNullOrEmpty(model.userNam))
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Tên tài khoản không được để trống";
            }
            else
                if (string.IsNullOrEmpty(model.passWord))
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Mật khẩu không được để trống";
            }
            else
            {

                var dto = new LOGIN
                {
                    userName = model.userNam,
                    userPassword = model.passWord,
                    statusLG = model.statusLG,
                    typeLogin=model.typeLogin

                };
                var res = IData.InsertLogGin(dto);
                if (res.ResponseCode == 1)
                {
                    rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                    rs.ReturnMessage = "thêm tài khoản thành công";
                    rs.Data = dto;
                }
                else
                {
                    rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                    rs.ReturnMessage = "thêm tài khoản thất bại";
                }
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
    }
}