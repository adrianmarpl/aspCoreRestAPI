using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreRestAPI.Contracts;
using AspCoreRestAPI.Entities;
using AspCoreRestAPI.Entities.Models;
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
        [HttpGet("{id}", Name = "GetClientById")]
        public IActionResult GetById(int id)
        {
            var client = _repoWrapper.Client.GetClientById(id);
            if (client == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(client);
            }

        }
        
        [HttpPost]
        public IActionResult CreateClient([FromBody]Client client)
        {
            if (client == null)
            {
                return BadRequest("Client object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            _repoWrapper.Client.Create(client);

            return CreatedAtRoute("GetClientById", new { id = client.ID }, client);
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
