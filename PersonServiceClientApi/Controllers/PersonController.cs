
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonService;

namespace PersonServiceClientApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("GetPerson")]
        public async Task<ActionResult<Response>> GetPersonAsync(string firstName)
        {
            PersonServiceClient personClient = new PersonServiceClient();
            Response response = await personClient.GetPersonAsync(new Request { FirstName = firstName } );

            return Ok(new { response.ResponseMessage, response.PersonList });
        }
    }
}
