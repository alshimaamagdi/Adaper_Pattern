using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.WebSockets;
using toutorial.usedClasses;

namespace toutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollCalculatorController : ControllerBase
    {
        [HttpPost("CaculateValue")]
        public IActionResult CaculateValue(Employee emp)
        {
            var obj = new Calculater();
            var result= obj.calculateValues(emp);
            return Ok(result);
        }
    }
}
