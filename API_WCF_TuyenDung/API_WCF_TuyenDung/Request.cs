﻿using System;
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
}