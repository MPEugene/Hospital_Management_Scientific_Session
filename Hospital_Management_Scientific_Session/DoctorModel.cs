using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Scientific_Session
{

    public class DoctorModel : Person
    {
        public int Experience { get; set; }
        public string Password { get; set; }

        public override string GetDetails()
        {
            return $"Doctor: {Name}, Experience: {Experience}";
        }
    }
}
