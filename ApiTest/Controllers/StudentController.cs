using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // Props
        private List<string> names;



        // Constructor
        public StudentController()
        {
            names = new List<string> { "Boby", "Dody", "Oggy", "Diddi" };
        }


        // GET
        [HttpGet]
        public async Task<IActionResult> GetStudents(int id)
        {
           return  Ok(names[id]);
        }


        // Post
        [HttpPost("Create")]
        public async Task<IActionResult> PostStudents(Student student)
        {
            return Ok();
        }
    }
}
