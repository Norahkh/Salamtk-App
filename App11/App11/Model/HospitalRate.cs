using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11.Model
{
    public class HospitalRate
    {
        public int User_ID { get; set; }
        public int Hospital_ID { get; set; }
        public int Hospital_Quistions_ID { get; set; }
        public string Answer { get; set; }
    }
}
