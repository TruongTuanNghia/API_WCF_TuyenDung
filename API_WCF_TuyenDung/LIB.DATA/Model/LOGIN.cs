using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.Model
{
    public class LOGIN
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
        public int? statusLG { get; set; }
        public int typeLogin { get; set; }
    }
}
