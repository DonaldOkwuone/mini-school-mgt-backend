using System;
using Microsoft.AspNetCore.Mvc;
using Noori_Course_Enrollment.Data;
using Noori_Course_Enrollment.Model;

namespace Noori_Course_Enrollment.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController: ControllerBase{

        private readonly IStudentRepo _studentRepo;
        public RegisterController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpGet]
        public IActionResult Get(){
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Noori_Student student){
            
            _studentRepo.AddStudent(student);
            _studentRepo.SaveChanges();
            return Ok("Done");
        }
    }
}