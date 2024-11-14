using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //http://localhost:4600/Test/GetTestData
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("GetTestData")]
        public string GetTestData()
        {
            return "Test Data";
        }
    }
}
