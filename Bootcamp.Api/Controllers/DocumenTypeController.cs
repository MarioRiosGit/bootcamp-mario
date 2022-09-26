using Bootcamp.Queries.DocumentType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumenTypeController : ControllerBase
    {
        private readonly IDocumenTypeQueries _documenTypeQueries;

        public DocumenTypeController(IDocumenTypeQueries documenTypeQueries)
        {
            _documenTypeQueries = documenTypeQueries;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _documenTypeQueries.GetAll();
            return Ok(result);
        }
    }
}
