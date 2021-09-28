using System;
using Anagrama.Domain;

namespace Anagrama.Infraestructure
{
    public class MessageRepository
    {
        public Message GetFirst()
        {
            var msg = new Message("Las palabras ");
            return msg;
        }
    }
}
