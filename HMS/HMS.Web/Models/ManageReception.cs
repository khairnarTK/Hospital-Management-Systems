using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Web.Models
{
    public class ManageReception
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set;}
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone {get; set;}
    }
}