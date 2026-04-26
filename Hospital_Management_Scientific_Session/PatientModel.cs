using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Scientific_Session
{
    public class PatientModel : Person
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public override string GetDetails()
        {
            return $"Patient: {Name}, Age: {Age}";
        }
    }
}
