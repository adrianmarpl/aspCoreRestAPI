using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreRestAPI.Contracts;
using AspCoreRestAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public ClientController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            //_repoWrapper.Client.Create(new Entities.Models.Client() { CompanyName = "AMC" });
            //_repoWrapper.Save();
            var clients = _repoWrapper.Client.FindAll();
            return Ok(clients);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
