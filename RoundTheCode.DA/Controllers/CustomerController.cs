using Microsoft.AspNetCore.Mvc;
using RoundTheCode.DA.Models;

namespace RoundTheCode.DA.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(CustomerModel customerModel)
        {
            return Ok(customerModel);
        }
    }
}