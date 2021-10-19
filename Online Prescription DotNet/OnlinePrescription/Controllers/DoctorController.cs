using Microsoft.AspNetCore.Mvc;
using OnlinePrescription.Models;
using OnlinePrescription.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Controllers
{
    public class DoctorController : Controller
    {
        private readonly DoctorAuthRepository _doctorAuthRepository = new DoctorAuthRepository();
        private readonly DoctorInfoRepository _doctorInfoRepository = new DoctorInfoRepository();

        [HttpPost("doctor/signUp")]
        public IActionResult DoctorSignUp([FromBody] DoctorAuth doctorAuth)
        {
            var checkAccount = _doctorAuthRepository.GetByEmail(doctorAuth.email);

            if (checkAccount == null)
            {
                var addedDoctor = _doctorAuthRepository.Add(doctorAuth);

                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }

        [HttpPost("doctor/addDoctorInfo")]
        public IActionResult AddDoctorInfo([FromBody] DoctorInfo doctorInfo)
        {

            var addedDoctorInfo = _doctorInfoRepository.Add(doctorInfo);

            return Ok(addedDoctorInfo);
        }

        [HttpPost("doctor/signIn")]
        public IActionResult DoctorSignIn([FromBody] DoctorAuth doctorAuth)
        {
            var checkAccount = _doctorAuthRepository.GetByEmail(doctorAuth.email);
            if (checkAccount != null)
            {
                if (checkAccount.password == doctorAuth.password)
                {
                    return Ok(_doctorInfoRepository.GetByEmail(checkAccount.email));
                }
            }

            return Ok(false);
        }



        [HttpPost("doctor/editDoctorInfo")]
        public IActionResult EditDoctorInfo([FromBody] DoctorInfo doctorInfo)
        {
            var result = _doctorInfoRepository.Update(doctorInfo);
            return Ok(result);
        }
    }
}
