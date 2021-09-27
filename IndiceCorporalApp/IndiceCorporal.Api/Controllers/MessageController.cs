using System.Net.Security;
using System.Reflection.PortableExecutable;
using System.IO.Pipes;
using Microsoft.AspNetCore.Mvc;
using IndiceCorporal.Service;

namespace IndiceCorporal.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var srv = new MessageService();
            var ps = 55;
            var al = 1.62;
            var imc = ps / (al * al);
            var cc = "comprobacion";
            if (imc < 18.5)
            {
                cc = "peso inferior al normal.";
            }
           else
           {
               if (imc >= 18.5 && imc < 25)
               {
                   cc = "peso normal.";
               }
               else
               {
                   if (imc >= 25 && imc < 30)
                   {
                       cc = "peso superior a lo normal.";
                   }
                   else
                   {
                       cc = "tiene obesidad.";
                   }
               }
           }
            var msg = srv.IMC(imc,cc);
            return Ok(msg);
        }
    }
}