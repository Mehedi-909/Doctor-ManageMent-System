using Microsoft.AspNetCore.Mvc;
using OnlinePrescription.Models;
using OnlinePrescription.Repository;

namespace OnlinePrescription.Controllers
{
    public class PatientInfoController : Controller
    {
        private readonly PatientRepository _patientRepository = new PatientRepository();

        [HttpPost("patient/add")]
        public IActionResult AddPatient([FromBody] Patient patient)
        {
            var result = _patientRepository.Add(patient);

            if (result == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }

        [HttpGet("patient/getAll")]
        public IActionResult GetAllPatient(int doctorId)
        {
            var result = _patientRepository.getAll(doctorId);

            return Ok(result);
        }

        [HttpPost("patient/update")]
        public IActionResult UpdatePatient([FromBody] Patient patient)
        {
            var result = _patientRepository.Update(patient);

            if (result == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }

        [HttpDelete("patient/remove")]
        public IActionResult RemovePatient(int patientId)
        {
            var result = _patientRepository.Remove(patientId);

            if (result == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }
    }
}
