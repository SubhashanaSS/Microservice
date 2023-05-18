using Microsoft.AspNetCore.Mvc;
using Client.Service.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService?? throw new ArgumentNullException(nameof(clientService));
        }

        // GET: api/<ClientController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientService.GetClients());
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _clientService.GetClient(id) != null? Ok(_clientService.GetClient(id)) : NoContent();
        }

        // POST api/<ClientController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Client client)
        {
            return Ok(_clientService.AddClient(client));
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Client client)
        {
            return Ok(_clientService.UpdateClient(client));
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _clientService.DeleteClient(id);
            return result.HasValue & result == true ? Ok($"Client with ID: {id} got deleted successfully.")
                : BadRequest($"Unable to delete the client with ID:{id}");
        }
    }
}
