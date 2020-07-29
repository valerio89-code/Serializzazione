using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializzazione.Code
{
    [DataContract]
    public class Persona
    {
        public Persona(string nome)
        {
            Nome = nome;
        }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cognome { get; set; }

        public int Età { get; set; }

        public Automobile Auto { get; set; }

        public string GetAnnoDiNascita()
        {
            return DateTime.Now.AddYears(-Età).Year.ToString();
        }
    }


    public class Automobile
    {

        public string Marca { get; set; }

        public int Cilindrata { get; set; }
    }


    //public class Studente : Persona
    //{
    //    public int Matricola { get; set; }
    //}
}
