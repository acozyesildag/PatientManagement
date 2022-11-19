using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Models
{
    public class PatientModel
    {
        public string Patientid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phonenumber { get; set; }

        public string Gender { get; set; }

        public string Countryid { get; set; }

    }

}
