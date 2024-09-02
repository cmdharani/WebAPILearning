using Microsoft.AspNetCore.Mvc;
using WebAPIAuthPratice.Model;

namespace WebAPIAuthPratice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
       
        [HttpGet]
        public List<Employee> Employees()
        {
            return new List<Employee> 
            { new Employee { Id = 1, Email = "dsad@re.com",FirstName="asd",LastName="sa" } };
        }
    }
}
