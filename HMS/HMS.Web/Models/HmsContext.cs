using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HMS.Web.Models
{
    public class HmsContext:DbContext
    {
        public DbSet<PatientRegistrations> PatientRegistrationes { get; set; }
        public DbSet<PatientSurgeryReservation> PatientSurgeryReservations { get; set;}
    }
}