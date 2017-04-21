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
        public DbSet<OpeartionTheatre> OpeartionTheatres { get; set;}
        public DbSet<ManageReception> ManageReceptions { get; set;}
        public DbSet<ManageDoctors> ManageDoctors { get; set;}
        public DbSet<ManageDoctorsDepartment> ManageDoctorsDepartments {get;set;}
    }
}