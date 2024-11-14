using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FirstProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        [Route("GetStudents")]
        public List<string> GetStudents()
        {
            return new List<string>()
            {
                "Siva", "Karthik" , "Keerthi"
            };
        }


        [HttpGet]
        [Route("GetMajorStudents")]
        public List<string> GetMajorStudents()
        {
            return new List<string>()
            {
                "abc" , "def"
            };
        }



        [HttpGet]
        [Route("GetMajorStudents1")]
        public List<string> GetMajorStudents1()
        {
            return new List<string>()
            {
                "abcdefghi" , "defasdfasda"
            };
        }
    }
}
