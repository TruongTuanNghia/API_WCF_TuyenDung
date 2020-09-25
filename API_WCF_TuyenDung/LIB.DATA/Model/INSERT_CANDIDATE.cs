using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.Model
{
    public class INSERT_CANDIDATE
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
}
