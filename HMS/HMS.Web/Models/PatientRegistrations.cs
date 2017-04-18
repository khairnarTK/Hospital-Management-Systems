using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Web.Models
{
    public class PatientRegistrations
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Blood_Group { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public int MobileNo { get; set; }
        public string EmailAdd { get; set; }
        public string Disease { get; set; }
        public DateTime DateOfJoin { get; set; }
    }
}