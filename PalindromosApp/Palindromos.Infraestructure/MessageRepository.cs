using System;
using Palindromos.Domain;

namespace Palindromos.Infraestructure
{
    public class MessageRepository
    {
        public Message Sentence()
        {
            var msg = new Message("La frase");
            return msg;
        }
    }
}
