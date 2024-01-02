using KarigarBotique.Services.CustomerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace KarigarBotique.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;
       

        public CustController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;

        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomer()
        {
            return _customerServices.GetAllCustomer();
            
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<List<Customer>>> GetSingleCustomer(int id)
        {
            var result = _customerServices.GetSingleCustomer(id);
            if (result == null)
            {
                return NotFound("Sorry, But Customer does not exist!");
            }
            return Ok(result);

        }

        [HttpPost]

        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer customer)
        {
            var result = _customerServices.AddCustomer(customer);

            return Ok(result);

        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<Customer>>> UpdateCustomer(int id, Customer req)
        {
            var result = _customerServices.UpdateCustomer(id,req);
            if (result == null)
            {
                return NotFound("Sorry, But Customer does not exist!");
            }
            
            return Ok(result);

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Customer>>> DeleteCustomer(int id)
        {
            var result = _customerServices.DeleteCustomer(id);
            if (result == null) 
            return NotFound("Sorry,Customer not exist!");
            return Ok(result);

        }
    }
}
   