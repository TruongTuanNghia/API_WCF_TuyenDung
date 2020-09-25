﻿
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
                return CONNECT.CONNECT.ExecuteSP<ResponseResult>("updateExperiences", lp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ResponseResult delete_Experiences(int idExperiences, int idUser)
        {
            try
            {
                var lp = new List<SqlParameter>
                {
                    new SqlParameter("@idExperiences",idExperiences),
                    new SqlParameter("@idUser",idUser)
                    
                };
                return CONNECT.CONNECT.ExecuteSP<ResponseResult>("deleteExperiences", lp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<GET_EXPERIENCE> Get_List_Experiences(int id)
        {          
            try
            {
                var lp = new List<SqlParameter>
                {
                    new SqlParameter("@idUser",id)
                };
                return CONNECT.CONNECT.ExecuteSPList<GET_EXPERIENCE>("GetListExperience", lp);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public ResponseResult insert_Candidate(INSERT_CANDIDATE model)
        {
            try
            {
                var lp = new List<SqlParameter>
                {
                    new SqlParameter("@userName",model.userName),
                    new SqlParameter("@FullName",model.FullName),
                    new SqlParameter("@Address",model.Address),
                    new SqlParameter("@School",model.School),
                    new SqlParameter("@PhoneNumber",model.PhoneNumber),
                    new SqlParameter("@Email",model.Email),
                    new SqlParameter("@Skill",model.Skill),
                    new SqlParameter("@Image",model.Image),
                    new SqlParameter("@CareerGoal",model.CareerGoal),
                    new SqlParameter("@DateBirth",model.DateBirth),
                    new SqlParameter("@Specialized",model.Specialized),
                    new SqlParameter("@Interests",model.Interests),
                };
                return CONNECT.CONNECT.ExecuteSP<ResponseResult>("insert_Candidate", lp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
