using LIB.DATA.DataAccess;
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
        public static string DoLogin(Do_Login_Input d)
        {
            ResponseModel rs = new ResponseModel();
            var res = IData.DoLogin(d.uname, d.upass);
            if (res.ResponseCode != -1)
            {
                var dto = new DoLogin_Out()
                {
                    id = res.id,
                    stype = res.statusLG,
                };
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.Data = dto;
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Đăng nhập thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
        public static string Update_Login(UPDATE_LOGIN up)
        {
            ResponseModel rs = new ResponseModel();
            var res = IData.UpdateLogin(up.uname, up.upass, up.newupass);
            if (res.ResponseCode == 1)
            {
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.ReturnMessage = "Đổi mật khẩu thành công";
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Đổi mật khẩu thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
        public static string Insert_Experiences(INSERT_EXPERIENCES_INPUT d)
        {
            ResponseModel rs = new ResponseModel();
            var dto = new INSERT_EXPERIENCES
            {
                idUser = d.idUser,
                titleJob = d.titleJob,
                nameComoanny = d.nameCompanny,
                starDay = d.startDay,
                endDay = d.endDay,
                statusDoingJob = d.statusDoingJob,
                note = d.note
            };
            var res = IData.Insert_Experiences(dto);
            if (res.ResponseCode == 1)
            {
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.ReturnMessage = "Thêm kinh nghiệm thành công";
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Thêm kinh nghiệm thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;
        }

        public static string Update_Experience(INSERT_EXPERIENCES_INPUT up)
        {
            ResponseModel rs = new ResponseModel();
            var dto = new INSERT_EXPERIENCES
            {
                idExperiences=up.idExperiences,
                idUser=up.idUser,
                titleJob=up.titleJob,
                starDay=up.startDay,
                endDay=up.endDay,
                nameComoanny=up.nameCompanny,
                statusDoingJob=up.statusDoingJob,
                note=up.note
            };
            var res = IData.update_Experiences(dto);
            if (res.ResponseCode == 1)
            {
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.ReturnMessage = "Cập nhật kinh nghiệm thành công";
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Cập nhật kinh nghiệm thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;

        }

        public static string Delect_Experience(DELETE_EXPERIENCES_INPUT d)
        {
            ResponseModel rs = new ResponseModel();
            var res = IData.delete_Experiences(d.idExperiences, d.idUser);
            if (res.ResponseCode == 1)
            {
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.ReturnMessage = "Xóa thành công";
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Xóa thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
        public static string Get_List_Experiences(GET_EXPERIENCES_INPUT m)
        {
            ResponseModel rs = new ResponseModel();
            var dto = new GET_LIST_EXPERIENCE_OUT();
            var res = IData.Get_List_Experiences(m.id);
            if (res != null)
            {
                dto = new GET_LIST_EXPERIENCE_OUT
                {
                    GetListExperiences = res.Select(x => new GET_EXPERIENCE_OUT()
                    {
                        idExperiencs = x.idExperiences,
                        titleJob = x.Title,
                        nameCompanny = x.NameCompanny,
                        startDay = x.StartDay,
                        endDay = x.EndDay,
                        statusDoingJob = x.StatusDoingJob,
                        note = x.Note
                    }).ToList(),
                };
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.Data = dto;
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
        public static string Insert_Candidate(INSERT_CANDIDATE_INPUT d)
        {
            ResponseModel rs = new ResponseModel();
            var dto = new INSERT_CANDIDATE
            {
                userName = d.userName,
                FullName = d.FullName,
                Address = d.Address,
                School = d.School,
                PhoneNumber = d.PhoneNumber,
                Email = d.Email,
                Skill = d.Skill,
                Specialized = d.Specialized,
                CareerGoal = d.CareerGoal,
                DateBirth = d.DateBirth              
            };
            var res = IData.insert_Candidate(dto);
            if (res.ResponseCode == 1)
            {
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.ReturnMessage = "Thêm thông tin  thành công";
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Thêm thông tin thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
        public static string update_Candidate(INSERT_CANDIDATE_INPUT d)
        {
            ResponseModel rs = new ResponseModel();
            var dto = new INSERT_CANDIDATE
            {
                userName = d.userName,
                FullName = d.FullName,
                Address = d.Address,
                School = d.School,
                PhoneNumber = d.PhoneNumber,
                Email = d.Email,
                Skill = d.Skill,
                Specialized = d.Specialized,
                CareerGoal = d.CareerGoal,
                DateBirth = d.DateBirth
            };
            var res = IData.update_Candidate(dto);
            if (res.ResponseCode == 1)
            {
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.ReturnMessage = "Cập nhật thông tin  thành công";
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Cập nhật tin thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;
        }

        public static string get_Candidate(GET_CANDIDATE_INPUT d)
        {
            ResponseModel rs = new ResponseModel();
            var dto = new GET_CANDIDATE_OUT();
            var res = IData.get_Candidate(d.id);

            if (res!=null)
            {
                dto = new GET_CANDIDATE_OUT
                {
                    userName = res.userName,
                    FullName = res.FullName,
                    Address = res.Address,
                    School = res.School,
                    PhoneNumber = res.PhoneNumber,
                    Email = res.Email,
                    Skill = res.Skill,
                    Specialized = res.Specialized,
                    CareerGoal = res.CareerGoal,
                    DateBirth = res.DateBirth,
                    listExperiences = res.Experiences.Select(x => new GET_EXPERIENCE_OUT()
                    {
                        idExperiencs = x.idExperiences,
                        titleJob=x.Title,
                        nameCompanny=x.NameCompanny,
                        startDay=x.StartDay,
                        endDay = x.EndDay,
                        statusDoingJob=x.StatusDoingJob,
                        note=x.Note
                    }).ToList()

                };
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.Data = dto;
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();               
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
        public static string Delect_Login(GET_LOGIN_INPUT d)
        {
            ResponseModel rs = new ResponseModel();
            var res = IData.delete_Login(d.id);
            if (res.ResponseCode == 1)
            {
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.ReturnMessage = "Xóa thành công";
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Xóa thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
        public static string Insert_Company(INSERT_COMPANY_INPUT d)
        {
            ResponseModel rs = new ResponseModel();
            var dto = new INSERT_COMPANY
            {
                IdCompany = d.IdCompany,
                FullName = d.FullName,
                Address = d.Address,              
                PhoneNumber = d.PhoneNumber,
                Email = d.Email,
                Node = d.Node,
                Image=d.Image
            };
            var res = IData.insert_Company(dto);
            if (res.ResponseCode == 1)
            {
                rs.Returncode = ResponseCodeEnum.Success.GetHashCode();
                rs.ReturnMessage = "Thêm công tuy  thành công";
            }
            else
            {
                rs.Returncode = ResponseCodeEnum.Failed.GetHashCode();
                rs.ReturnMessage = "Thêm công tuy thất bại";
            }
            string js = CONVERJS.convert(rs);
            return js;
        }
    }
}