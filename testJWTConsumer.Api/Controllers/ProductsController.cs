using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testJWTConsumer.Data.Interfaces;
using testJWTConsumer.Data.Models;
using testJWTConsumer.RabbitMQ;

namespace testJWTConsumer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            Product newProduct = new Product() { Name = product.Name };
            _unitOfWork.ProductRepository.Add(newProduct);
            _unitOfWork.Complete();

            new PublisherHelper("ulkerlog", product.Name);
           // new ConsumerHelper("ulkerlog"); kuyruğu okur
            return new JsonResult(newProduct);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
