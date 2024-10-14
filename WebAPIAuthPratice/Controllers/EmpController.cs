using Microsoft.AspNetCore.Mvc;
using WebAPIAuthPratice.Data;
using WebAPIAuthPratice.Helpers;
using WebAPIAuthPratice.Model;

namespace WebAPIAuthPratice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Authorize]
    public class EmpController : ControllerBase
    {
        private readonly EmpDbContext _empDbContext;

        public EmpController(EmpDbContext empDbContext)
        {
            _empDbContext = empDbContext;
        }


        [HttpGet]
        public List<Employee> Employees()
        {
            return _empDbContext.Employees.ToList();
        }
    }
}
