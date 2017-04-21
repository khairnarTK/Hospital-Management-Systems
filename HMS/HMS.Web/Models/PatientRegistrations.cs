using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Web.Models
{
    public class PatientRegistrations
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }

        public string City { get; set; }
        public string Address { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Maritial_Status { get; set;}
        public string Occupation { get; set;}
        public string Blood_Group { get; set; }
         public string MobileNo { get; set; }
        public string EmailAdd { get; set; }
        public string Disease { get; set; }
        public DateTime  Date_Of_Join { get; set; }
        public string Department { get; set; }
        public string Ward_Name { get; set; }
        public int Bed_No { get; set; }

    }
}