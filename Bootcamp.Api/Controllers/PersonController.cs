using Bootcamp.Model;
using Bootcamp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Create([FromBody] Person person)
        {
            var result = await _personRepository.Create(person);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _personRepository.GetAll();
            return Ok(result);
        }

        [HttpPut]
        [Route("Update")]

        public async Task<ActionResult> Update([FromBody] Person person)
        {
            var result = await _personRepository.Update(person);
            return Ok(result);
        }

        [HttpDelete]
        [Route("Delete")]

        public async Task<ActionResult> Delete()
        {
            var result = await _personRepository.Delete();
            return Ok(result);
        }


    }
}
