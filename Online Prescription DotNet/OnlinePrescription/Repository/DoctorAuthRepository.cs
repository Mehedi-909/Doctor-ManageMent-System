using OnlinePrescription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Repository
{
    public class DoctorAuthRepository: DatabaseRepository
    {
        public bool Add(DoctorAuth doctorAuth)
        {
            databaseContext.DoctorAuthTable.Add(doctorAuth);
            databaseContext.SaveChanges();
            return true;
        }


        public DoctorAuth GetByEmail(string email)
        {
            return databaseContext.DoctorAuthTable.SingleOrDefault(DoctorAuth => DoctorAuth.email == email);
        }
    }
}
