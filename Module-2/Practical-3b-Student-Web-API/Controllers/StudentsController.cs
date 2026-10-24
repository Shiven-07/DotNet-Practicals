using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Course = "BSc IT", Age = 20, Percentage = 85.5
},
            new Student { Id = 2, Name = "Bob", Course = "BCA", Age = 21, Percentage = 78.0 },
            new Student { Id = 3, Name = "Carol", Course = "BSc CS", Age = 19, Percentage = 91.2
}
        };

// GET: api/students
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
            => Ok(students);

        // GET: api/students/1
        [HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var s = students.FirstOrDefault(x => x.Id == id);
            if (s == null) return NotFound(new { message = "Student not found" });
            return Ok(s);
        }
    }
}
