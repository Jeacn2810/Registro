using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDiseño.DATA
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string DocumentoIdentidad { get;set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public byte[] Foto { get; set; }
        
    }
}
