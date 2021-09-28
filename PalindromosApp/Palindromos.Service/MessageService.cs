using System.Net.Http;
using System;
using Palindromos.Infraestructure;

namespace Palindromos.Service
{
    public class MessageService
    {
        public string PLM (string conf, int cpl)
        {
            var repo = new MessageRepository();
            var msg = repo.Sentence();
            return $"{msg.Summary} {conf} {", la cantidad de palabras es "} {cpl}";
        }
    }
}
