using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HMS.Web.Models
{
    public class HmsContext:DbContext
    {
        public DbSet <PatientRegistration> PatientRegistrations { get; set; }

        public DbSet<PatientRegistrations> PatientRegistrationes { get; set; }

    }
}