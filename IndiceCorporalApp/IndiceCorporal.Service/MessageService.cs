using System.Xml.Linq;
using System.Text.RegularExpressions;
using System;
using IndiceCorporal.Infraestructure;

namespace IndiceCorporal.Service
{
    public class MessageService
    {
        public string IMC(double imc, string cc)
        {
            var repo = new MesssageRepository();
            var msg = repo.Intro();
            return $"{msg.Summary} {imc} {cc}";
        }
    }
}
