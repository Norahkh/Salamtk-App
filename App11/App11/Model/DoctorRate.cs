using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11.Model
{
    public class DoctorRate
    {
        public int User_ID { get; set; }
        public int Doctor_ID { get; set; }
        public int Doc_Quistions_ID { get; set; }
        public string Answer { get; set; }
    }
}
