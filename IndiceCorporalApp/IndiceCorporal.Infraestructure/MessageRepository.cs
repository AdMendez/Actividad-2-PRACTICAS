using System;
using IndiceCorporal.Domain;

namespace IndiceCorporal.Infraestructure
{
    public class MesssageRepository
    {
        public Message Intro()
        {
            var msg = new Message("Su índice corporal es...");
            return msg;
        }
    }
}
