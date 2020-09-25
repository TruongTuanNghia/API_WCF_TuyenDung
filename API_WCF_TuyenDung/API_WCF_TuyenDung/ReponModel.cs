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
}