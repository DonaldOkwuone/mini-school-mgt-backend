using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Noori_Course_Enrollment.Data;
using Noori_Course_Enrollment.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Noori_Course_Enrollment.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentController(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Noori_Student noori_Student)
        {
            await _dbContext.noori_students.AddAsync(noori_Student);
            _dbContext.SaveChanges();

            return Ok("completed");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

