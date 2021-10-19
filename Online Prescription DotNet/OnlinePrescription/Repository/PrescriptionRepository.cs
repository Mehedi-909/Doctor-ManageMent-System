using OnlinePrescription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Repository
{
    public class PrescriptionRepository: DatabaseRepository
    {
        public bool Add(Prescription prescription) 
        {
            databaseContext.PrescriptionTable.Add(prescription);
            databaseContext.SaveChanges();
            return true;
        }

        public List<Prescription> getAll(int doctorId, int patientId)
        {
            List<Prescription> prescriptions = databaseContext.PrescriptionTable.Where(x => x.doctorId == doctorId && x.patientId == patientId).OrderByDescending(x=>x.dateAndTime).ToList();

            foreach (Prescription prescription in prescriptions)
            {
                prescription.prescribedMedicines = databaseContext.PrescribedMedicine.Where(x => x.Prescriptionid == prescription.id).ToList();
            }

            return prescriptions;
        }

        public Prescription getById(int prescriptionId)
        {
            return databaseContext.PrescriptionTable.SingleOrDefault(x => x.id == prescriptionId);
        }

        public List<PrescribedMedicine> getByPrescriptoinId(int prescriptionId)
        {
            return databaseContext.PrescribedMedicine.Where(x => x.Prescriptionid == prescriptionId).ToList();
        }

        public bool Update(Prescription prescription)
        {
            foreach (var medicine in getByPrescriptoinId(prescription.id))
            {
                databaseContext.PrescribedMedicine.Remove(medicine);
            }

            databaseContext.PrescriptionTable.Update(prescription);
            databaseContext.SaveChanges();
            return true;
        }

        public bool Remove(int prescriptionId)
        {
            databaseContext.PrescriptionTable.Remove(getById(prescriptionId));
        
            foreach (var medicine in getByPrescriptoinId(prescriptionId))  
            {
                databaseContext.PrescribedMedicine.Remove(medicine);
            }

            databaseContext.SaveChanges();
            return true;
        }
    }
}
