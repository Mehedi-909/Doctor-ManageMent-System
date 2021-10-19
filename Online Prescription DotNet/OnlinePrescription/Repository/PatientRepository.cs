using OnlinePrescription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Repository
{
    public class PatientRepository: DatabaseRepository
    {
        public bool Add(Patient patient)
        {
            databaseContext.PatientTable.Add(patient);
            databaseContext.SaveChanges();
            return true;
        }

        public List<Patient> getAll(int doctorId)
        {
            return databaseContext.PatientTable.Where(Patient => Patient.doctorId == doctorId).ToList();
        }

        public Patient getById(int patientId) 
        {
            return databaseContext.PatientTable.SingleOrDefault(Patient=> Patient.id == patientId);
        }

        public bool Update(Patient patient)
        {
            databaseContext.PatientTable.Update(patient);
            databaseContext.SaveChanges();
            return true;
        }

        public bool Remove(int patientId)
        {
            databaseContext.PatientTable.Remove(getById(patientId));
            databaseContext.SaveChanges();
            return true;
        }
    }
}
