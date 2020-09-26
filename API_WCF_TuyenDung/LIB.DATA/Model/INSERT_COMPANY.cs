using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.Model
{
    public class INSERT_COMPANY
    {
        public int IdCompany { get; set; }   
        public string FullName { get; set; }
        public string Address { get; set; }      
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }     
        public string Image { get; set; }
        public string Node { get; set; }
    }
}
