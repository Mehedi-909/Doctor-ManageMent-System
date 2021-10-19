using Microsoft.AspNetCore.Mvc;
using OnlinePrescription.Models;
using OnlinePrescription.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Controllers
{
    public class MedicineInfoController : Controller
    {
        private readonly MedicineRepository _medicineRepository = new MedicineRepository();

        [HttpPost("medicine/add")]
        public IActionResult AddMedicine([FromBody] Medicine medicine) 
        {
            var restult = _medicineRepository.getByName(medicine.name) ;

            if (restult != null) 
            {
                return Ok(false);
            }

            var result2 = _medicineRepository.Add(medicine);

            if (result2 == true) 
            {
                return Ok(true);
            }

            return Ok(false);
        }

        [HttpGet("medicine/getAll")]
        public IActionResult GetAll(int doctorId)
        {
            var result = _medicineRepository.getAll(doctorId);

            return Ok(result);
        }

        [HttpGet("medicine/getAllMedicineName")]
        public IActionResult GetAllMedicineName(int doctorId)
        {
            var result = _medicineRepository.getAllMedicineName(doctorId);

            return Ok(result);
        }

        [HttpPost("medicine/update")]
        public IActionResult UpdateMedicine([FromBody] Medicine medicine)
        {
            var restult = _medicineRepository.getByName(medicine.name);

            if (restult != null)
            {
                return Ok(false);
            }

            var result2 = _medicineRepository.Update(medicine);

            if (result2 == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }

        [HttpDelete("medicine/remove")]
        public IActionResult RemoveMedicine(int medicineId)
        {
            var result = _medicineRepository.Remove(medicineId);

            if (result == true)
            {
                return Ok(true);
            }

            return Ok(false);
        }

    }
}
