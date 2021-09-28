using System;
using Anagrama.Infraestructure;

namespace Anagrama.Service
{
    public class MessageService
    {
        public string CAnagrama(string conf)
        {
            var repo = new MessageRepository();
            var msg = repo.GetFirst();
            return $"{msg.Summary}{conf}";
        }
    }
}
