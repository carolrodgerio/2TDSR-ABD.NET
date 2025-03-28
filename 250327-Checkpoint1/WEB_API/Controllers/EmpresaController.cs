using Microsoft.AspNetCore.Mvc;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("POST");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("PUT");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("DELETE");
        }
    }
}