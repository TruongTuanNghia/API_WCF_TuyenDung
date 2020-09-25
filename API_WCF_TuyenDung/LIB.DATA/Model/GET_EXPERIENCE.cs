using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.Model
{
     public class GET_EXPERIENCE
    {
        public int idExperiences { get; set; }
        public string Title { get; set; }
        public string NameCompanny { get; set; }
        public string StartDay { get; set; }
        public string EndDay { get; set; }
        public bool? StatusDoingJob { get; set; }
        public string Note { get; set; }
    }
}
