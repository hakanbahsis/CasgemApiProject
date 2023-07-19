using Casgem.BusinessLayer.Abstract;
using Casgem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getCustomerList")]
        public IActionResult GetCustomerList()
        {
            var values=_customerService.GetAll();
            return Ok(values);
        }

        [HttpPost("addCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.Add(customer);
            return Ok();
        }

        [HttpGet("getCustomer/{id}")]
        public IActionResult GetCustomer(int id)
        {
            var values=_customerService.GetById(id);
            return Ok(values);
        }

        [HttpDelete("deleteCustomer")]
        public IActionResult DeleteCustomer(int id)
        {
            var values = _customerService.GetById(id);
            _customerService.Delete(values);
            return Ok();
        }

        [HttpPut("updateCustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.Update(customer);
            return Ok();
        }
    }
}
