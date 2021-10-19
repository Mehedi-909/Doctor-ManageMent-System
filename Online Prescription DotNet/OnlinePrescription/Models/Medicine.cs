using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Models
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string indication { get; set; }
        public string usage { get; set; }
        public string instruction { get; set; }
        public int doctorId { get; set; }
    }
}
