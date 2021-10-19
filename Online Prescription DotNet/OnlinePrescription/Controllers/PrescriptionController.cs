using Microsoft.AspNetCore.Mvc;
using OnlinePrescription.Models;
using OnlinePrescription.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Controllers
{
    public class PrescriptionController : Controller
    {
        private readonly PrescriptionRepository _prescriptionRepository= new PrescriptionRepository();

        [HttpPost("prescription/add")]
        public IActionResult AddPrescription([FromBody] Prescription prescription)
        {
            prescription.dateAndTime = DateTime.Now;
            var result = _prescriptionRepository.Add(prescription);

            if (result == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }

        [HttpGet("prescription/getAll")]
        public IActionResult GetAllPrescription(int doctorId, int patientId)
        {
            var result = _prescriptionRepository.getAll(doctorId, patientId);

            return Ok(result);
        }

        [HttpPost("prescription/update")]
        public IActionResult UpdatePatient([FromBody] Prescription prescription)
        {
            prescription.dateAndTime = DateTime.Now;
            var result = _prescriptionRepository.Update(prescription);

            if (result == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }

        [HttpDelete("prescription/remove")]
        public IActionResult RemovePrescription(int prescriptionId)
        {
            var result = _prescriptionRepository.Remove(prescriptionId);

            if (result == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }
    }
}
