using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Models
{
    public class DoctorInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string email { get; set; }
        public string doctorName { get; set; }
        public string qualification { get; set; }
        public string mobileNumber { get; set; }
    }
}
