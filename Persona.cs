using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netdictionary
{
    public class Persona
    {
        private string  ?id;
        private string ?name;
        private string ?emailAddress;
        private DateTime dateRegistered;

        public Persona(){

        }
        public Persona(string id, string name, string emailAddress, DateTime date){
            this.id = id;
            this.name = name;
            this.emailAddress = emailAddress;
            this.dateRegistered = date;

        }

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public string? EmailAddress { get => emailAddress; set => emailAddress = value; }
        public DateTime DateRegistered { get => dateRegistered; set => dateRegistered = value; }
    }
}