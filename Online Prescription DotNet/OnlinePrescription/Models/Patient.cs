using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string bloodGroup { get; set; }
        public string weight { get; set; }
        public string mobileNumber { get; set; }
        public string address { get; set; }

        public string disease { get; set; }
        public int doctorId { get; set; }

    }
}
