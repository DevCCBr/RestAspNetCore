using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRestPersons.Model
{
    public class Person
    {
        public long id { get;set; }
        public string primeiroNome { get;set ;}
        public string segundoNome { get;set ;}
        public string Endereço { get;set ;}
        public string Genero { get;set ;}
    }
}
