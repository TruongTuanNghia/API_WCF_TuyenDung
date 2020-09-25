using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.Model
{
    public class GET_CANDIDATE
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
        public List<EXPERIENCES> Experiences { get; set; }
    }
    public class EXPERIENCES
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
