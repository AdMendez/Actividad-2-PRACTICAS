using System.Net.Security;
using System.Reflection.PortableExecutable;
using System.IO.Pipes;
using Microsoft.AspNetCore.Mvc;
using Anagrama.Service;

namespace Anagrama.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var srv = new MessageService();
            
        }
    }
}