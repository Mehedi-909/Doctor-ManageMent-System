using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int doctorId { get; set; }
        public int patientId { get; set; }
        public DateTime dateAndTime { get; set; }
        public List<PrescribedMedicine> prescribedMedicines { get; set; }
        public string suggestion { get; set; }
    }

    public class PrescribedMedicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string medicineName { get; set; }
        public bool morning { get; set; }
        public bool noon { get; set; }
        public bool night { get; set; }
        public bool beforeEating { get; set; }
        public bool afterEating { get; set; }
        public string otherInfo { get; set; }
        public string numberOfDaysToTake { get; set; }
        public int Prescriptionid { get; set; }
    }
}
