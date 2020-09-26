using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WCF_TuyenDung
{
    public class DoLogin_Out
    {
        public int id { get; set; }
        public int stype { get; set; }
    }
    public class GET_EXPERIENCE_OUT
    {
        public int idExperiencs { get; set; }
        public string titleJob { get; set; }
        public string nameCompanny { get; set; }
        public string startDay { get; set; }
        public string endDay { get; set; }
        public bool? statusDoingJob { get; set; }
        public string note { get; set; }
    }
    public class GET_LIST_EXPERIENCE_OUT
    {
        public List<GET_EXPERIENCE_OUT> GetListExperiences { get; set; }
    }
    public class GET_CANDIDATE_OUT
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
        public List<GET_EXPERIENCE_OUT> listExperiences { get; set; }
    }
    public class GET_ALL_JOB_OUT
    {
        public int IdJob { get; set; }
        public int IdCompany { get; set; }
        public string TitleJob { get; set; }
        public string JobDescription { get; set; }
        public string Request { get; set; }
        public string Benefits { get; set; }
        public string Deadline { get; set; }
    }
    public class GET_LIST_JOB_OUT
    {
        public List<GET_ALL_JOB_OUT> getalljobs { get; set; }
    }

}