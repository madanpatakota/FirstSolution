using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{

    //localhost:5161/Developer/GetSkillSet
    [ApiController]
    [Route("[controller]")]
    public class Developer : ControllerBase
    {
        //

        [HttpGet]
        [Route("GetSkillSet")]
        public List<string> SkillsSet()
        {
            Console.WriteLine("Start");
            return new List<string>
            {
                "Csharp" , "Angular" , ".netCore"
            };
        }


    }
}
