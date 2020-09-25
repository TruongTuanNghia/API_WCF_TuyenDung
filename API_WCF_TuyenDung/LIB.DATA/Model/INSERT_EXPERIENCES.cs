using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.DATA.Model
{
    public class INSERT_EXPERIENCES
    {
        public int idUser { get; set; }
        public string titleJob { get; set; }
        public string nameComoanny { get; set; }
        public string starDay { get; set; }
        public string endDay { get; set; }
        public bool statusDoingJob { get; set; }
        public string note { get; set; }
    }
}
