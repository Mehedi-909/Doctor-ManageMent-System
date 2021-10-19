using OnlinePrescription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Repository
{
    public class DoctorInfoRepository: DatabaseRepository
    {
        public DoctorInfo Add(DoctorInfo doctorInfo)
        {
            databaseContext.DoctorInfoTable.Add(doctorInfo);
            databaseContext.SaveChanges();
            return doctorInfo;
        }


        public DoctorInfo GetByEmail(string email)
        {
            return databaseContext.DoctorInfoTable.SingleOrDefault(DoctorInfo => DoctorInfo.email == email);
        }


        public DoctorInfo Update(DoctorInfo doctorInfo)
        {
            databaseContext.DoctorInfoTable.Update(doctorInfo);
            databaseContext.SaveChanges();
            return doctorInfo;
        }
    }
}
