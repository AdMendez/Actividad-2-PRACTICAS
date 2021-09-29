using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Security;
using System.Reflection.PortableExecutable;
using System.IO.Pipes;
using Microsoft.AspNetCore.Mvc;
using Anagrama.Service;
using System.Security.Cryptography;
using System.Linq;

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

            var palabra1 = "Aretes";
            var palabra2 = "Teresa";

            palabra1 = Regex.Replace(palabra1, @"\s", "");//quita los espacios reemplazando
            palabra2 = Regex.Replace(palabra2, @"\s", "");

            palabra1 = palabra1.ToLower(); //lo volvemos minuscula
            palabra2 = palabra2.ToLower();
            
            var conf = "";

            string ordenado = new String(palabra1.OrderBy(x => x).ToArray()); //acomoda las letras en orden alfabetico
            string ordenado2 = new String(palabra2.OrderBy(x => x).ToArray());
            
            if (ordenado == ordenado2)
            {
                conf = "si son anagramas";
            }
            else
            {
                conf = "no son anagramas";
            }
            

            var msg = srv.CAnagrama(conf);
            return Ok(msg);
        }
    }
}