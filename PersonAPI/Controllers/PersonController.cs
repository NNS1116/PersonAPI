using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonLibrary;

namespace PersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("getPhoneNumber")]
        public IActionResult GetPhoneNumber()
        {
            Student student = new Student();
            string phoneNumber = student.GetCellPhoneNumber();
            return Ok(phoneNumber); 
        }
    }
}
