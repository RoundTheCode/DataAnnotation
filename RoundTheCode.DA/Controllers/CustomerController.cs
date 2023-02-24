using Microsoft.AspNetCore.Mvc;
using RoundTheCode.DA.Models;

namespace RoundTheCode.DA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(CustomerModel customerModel)
        {
            return Ok(customerModel);
        }
    }
}