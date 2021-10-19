using OnlinePrescription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Repository
{
    public class MedicineRepository: DatabaseRepository
    {
        public bool Add(Medicine medicine) {
            databaseContext.MedicineTable.Add(medicine);
            databaseContext.SaveChanges();
            return true;
        }

        public List<Medicine> getAll(int doctorId) {
            return databaseContext.MedicineTable.Where(Medicine=> Medicine.doctorId==doctorId).OrderBy(Medicine=> Medicine.name).ToList();
        }

        public List<String> getAllMedicineName(int doctorId) 
        {
            return databaseContext.MedicineTable.Where(Medicine => Medicine.doctorId == doctorId).OrderBy(Medicine => Medicine.name).Select(Medicine => Medicine.name).ToList();
        }

        public Medicine getById(int medicineId)
        {
            return databaseContext.MedicineTable.SingleOrDefault(Medicine => Medicine.id == medicineId);
        }

        public Medicine getByName(string medicineName)
        {
            return databaseContext.MedicineTable.SingleOrDefault(Medicine => Medicine.name == medicineName);
        }

        public bool Update(Medicine medicine)
        {
            databaseContext.MedicineTable.Update(medicine);
            databaseContext.SaveChanges();
            return true;
        }

        public bool Remove(int medicineId)
        {
            databaseContext.MedicineTable.Remove(getById(medicineId));
            databaseContext.SaveChanges();
            return true;
        }
    }
}
