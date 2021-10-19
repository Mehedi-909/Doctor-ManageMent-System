using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Models
{
    public class DatabaseContext : DbContext
    {
        //public AuthenticationContext(DbContext option)
        public const string ConnectionString = @"Server=DESKTOP-5TT304Q\SQLEXPRESS; Database=OnlinePrescription2 ; Trusted_Connection=true";

        public DbSet<DoctorAuth> DoctorAuthTable { get; set; }
        public DbSet<DoctorInfo> DoctorInfoTable { get; set; }
        public DbSet<Medicine> MedicineTable { get; set; }
        public DbSet<Patient> PatientTable { get; set; }
        public DbSet<Prescription> PrescriptionTable { get; set; }
        public DbSet<PrescribedMedicine> PrescribedMedicine { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
