using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HMS.Web.Models
{
    public class HmsContext : DbContext
    {
        public DbSet<PatientRegistrations> PatientRegistrationes { get; set; }
        public DbSet<PatientSurgeryReservation> PatientSurgeryReservations { get; set; }
        public DbSet<OpeartionTheatre> OpeartionTheatres { get; set; }
        public DbSet<ManageReception> ManageReceptions { get; set; }
        public DbSet<ManageDoctors> ManageDoctors { get; set; }
        public DbSet<ManageDoctorsDepartment> ManageDoctorsDepartments { get; set; }
        public DbSet<ManagePatient> ManagePatients { get; set; }
        public DbSet<ManagePrescription> ManagePrescriptions { get; set; }
        public DbSet<ManageVisitorPass> ManageVisitorPass { get; set;}
        public DbSet<ManageReport> ManageReports { get; set;}
        public DbSet<ManageNurse> ManageNurse { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ManageNurse>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<HMS.Web.ManageNurseRepository> ManageNurseRepositories { get; set; }
    }
}