using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WCF_TuyenDung
{
    
        public class LOGIN_INPUT
        {
            public string userNam { get; set; }
            public string passWord { get; set; }
            public int? statusLG { get; set; }
            public int typeLogin { get; set; }
         }
    public class Do_Login_Input
    {
        public string uname { get; set; }
        public string upass { get; set; }

    }
    public class UPDATE_LOGIN
    {
        public string uname { get; set; }
        public string upass { get; set; }
        public string newupass { get; set; }

    }
    public class INSERT_EXPERIENCES_INPUT
    {
        public int idExperiences { get; set; }
        public int idUser { get; set; }
        public string titleJob { get; set; }
        public string nameCompanny { get; set; }
        public string startDay { get; set; }
        public string endDay { get; set; }
        public bool statusDoingJob { get; set; }
        public string note { get; set; }
    }

    public class DELETE_EXPERIENCES_INPUT
    {
        public int idExperiences { get; set; }
        public int idUser { get; set; }
    }
    public class GET_EXPERIENCES_INPUT
    {
        public int id { get; set; }
    }

    public class INSERT_CANDIDATE_INPUT
    {
        public int userName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string School { get; set; }
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Skill { get; set; }
        public string Image { get; set; }
        public string CareerGoal { get; set; }
        public string DateBirth { get; set; }
        public string Specialized { get; set; }
        public string Interests { get; set; }
    }
    public class GET_CANDIDATE_INPUT
    {
        public int id { get; set; }
    }
    public class GET_LOGIN_INPUT
    {
        public int id { get; set; }
    }
    public class INSERT_COMPANY_INPUT
    {
        public int IdCompany { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Node { get; set; }
    }
    public class INSERT_JOB_INPUT
    {
        public int IdCompany { get; set; }
        public string TitleJob { get; set; }
        public string JobDescription { get; set; }
        public string Request { get; set; }
        public string Benefits { get; set; }
        public string Deadline { get; set; }
    }
}