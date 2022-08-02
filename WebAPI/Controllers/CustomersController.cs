using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpPost("add")]
        public IActionResult Add(Customers customer) 
        {
            var result = _customerService.Add(customer);
            if(result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customers customer) 
        {
            var result = _customerService.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Customers customers) 
        {
            var result = _customerService.Update(customers);
            if(result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
