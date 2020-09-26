using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.Model
{
    public class INSERT_JOB
    {
        public int IdCompany { get; set; }
        public string TitleJob { get; set; }
        public string JobDescription { get; set; }
        public string Request { get; set; }
        public string Benefits { get; set; }
        public string Deadline { get; set; }
    }
}
