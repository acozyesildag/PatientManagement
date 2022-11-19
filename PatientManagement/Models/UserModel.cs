using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Usertype { get; set; }
        public string Surname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash  { get; set; }

    }
}
