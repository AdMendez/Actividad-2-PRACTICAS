using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System;
using Microsoft.AspNetCore.Mvc;
using Palindromos.Service;

namespace Palindromos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var srv = new MessageService();
            var frase = "ana";
            //contar palabras
            int cont = 0;
            for (int a = 0; a < frase.Length; a++)
            {
                if (frase[a] == ' ' && frase [a+1] != ' ')
                {
                    cont++;
                }    
            }
            cont = cont + 1;

            frase = frase.ToLower();//convierte la frase en minusculas
            frase = Regex.Replace(frase, @"\s", "");//reemplaza los espacios a espacios vacios
            frase = Regex.Replace(frase, @",", "");//reempleza las comas a espacios vacios
            var inverso = "";
            var caracter = "";
            int i;
            i = frase.Length;
            for(int x = i - 1; x >= 0; x--)
            {
                caracter = frase.Substring(x, 1);//se ordena la frase en forma inversa
                inverso = inverso + caracter;
            }
            var conf = "";
            if(frase == inverso)
            {
                conf = "es palíndromo";
            }
            else
            {
                conf = "no es palíndromo";
            }
            
            var msg = srv.PLM(conf,cont);
            return Ok(msg);


        }
    }
}